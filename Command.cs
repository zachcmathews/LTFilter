using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTFilter
{

    public struct FilterableElement
    {
        public ElementId id;
        public string category;
        public string family;
        public string type;
        public string workset;
    }
    public struct AvailableFilters
    {
        public List<string> categories;
        public List<string> families;
        public List<string> types;
        public List<string> worksets;
    }

    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class Command : IExternalCommand
    {
        private List<FilterableElement> allElements;
        private List<FilterableElement> filteredElements;
        private AvailableFilters availableFilters;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            WorksetTable worksetTable = doc.GetWorksetTable();

            // Build hashmap out of all selected elements and store their filterable properties
            Selection selection = uidoc.Selection;
            allElements = selection.GetElementIds().Select(id =>
            {
                Element element = doc.GetElement(id);

                FilterableElement filterableElement;
                filterableElement.id = id;
                filterableElement.category = element.Category.Name;
                filterableElement.family = element.get_Parameter(BuiltInParameter.ELEM_FAMILY_PARAM).AsValueString();
                filterableElement.type = element.get_Parameter(BuiltInParameter.ELEM_TYPE_PARAM).AsValueString();
                filterableElement.workset = worksetTable.GetWorkset(element.WorksetId).Name;

                return filterableElement;
            }).ToList();
            filteredElements = allElements;

            // Determine the values we can filter
            determineAvailableFilters();

            // Show the form
            FilterForm filterForm = new FilterForm(this, availableFilters);
            DialogResult result = filterForm.ShowDialog();
            if (DialogResult.Cancel == result)
            {
                filteredElements = allElements;
            }

            // Select the filtered elements in Revit
            selection.SetElementIds(filteredElements.Select(filterableElement => filterableElement.id).ToList());

            return Result.Succeeded;
        }

        public AvailableFilters applyFilter(Tabs tab, List<string> filteredList)
        {
            // Filter out the elements not matching the filter
            if (Tabs.categories == tab)
            {
                filteredElements = filteredElements
                    .Where(filterableElement => filteredList.Contains(filterableElement.category))
                    .ToList();
            }
            else if (Tabs.families == tab)
            {
                filteredElements = filteredElements
                    .Where(filterableElement => filteredList.Contains(filterableElement.family))
                    .ToList();
            }
            else if (Tabs.types == tab)
            {
                filteredElements = filteredElements
                    .Where(filterableElement => filteredList.Contains(filterableElement.type))
                    .ToList();
            }
            else if (Tabs.worksets == tab)
            {
                filteredElements = filteredElements
                    .Where(filterableElement => filteredList.Contains(filterableElement.workset))
                    .ToList();
            }

            // Update the available filters and return
            determineAvailableFilters();
            return availableFilters;
        }

        public AvailableFilters clearFilter(Tabs tab)
        {
            if (Tabs.all == tab)
            {
                // Clear all filters
                filteredElements = allElements;
            }
            else if (Tabs.categories == tab)
            {
                // Clear category, family, and type filters
                filteredElements = allElements
                    .Where(filterableElement => availableFilters.worksets.Contains(filterableElement.workset))
                    .ToList();
            }
            else if (Tabs.families == tab)
            {
                // Clear family and type filters
                filteredElements = allElements
                    .Where(filterableElement => availableFilters.categories.Contains(filterableElement.category) && availableFilters.worksets.Contains(filterableElement.workset))
                    .ToList();
            }
            else if (Tabs.types == tab)
            {
                // Clear type filter
                filteredElements = allElements
                    .Where(filterableElement => availableFilters.families.Contains(filterableElement.family) && availableFilters.worksets.Contains(filterableElement.workset))
                    .ToList();
            }
            else if (Tabs.worksets == tab)
            {
                // Clear workset filter
                filteredElements = allElements
                    .Where(filterableElement => availableFilters.types.Contains(filterableElement.type))
                    .ToList();
            }

            // Update the available filters and return
            determineAvailableFilters();
            return availableFilters;
        }

        private void determineAvailableFilters()
        {
            // Determine the values we can filter
            availableFilters.categories = filteredElements
                .Select(filterableElement => filterableElement.category)
                .Distinct()
                .ToList();
            availableFilters.families = filteredElements
                .Select(filterableElement => filterableElement.family)
                .Distinct()
                .ToList();
            availableFilters.types = filteredElements
                .Select(filterableElement => filterableElement.type)
                .Distinct()
                .ToList();
            availableFilters.worksets = filteredElements
                .Select(filterableElement => filterableElement.workset)
                .Distinct()
                .ToList();
        }
    }
}
