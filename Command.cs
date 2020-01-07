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
    public struct Filters
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
        private Filters allFilters;
        private Filters availableFilters;
        private Filters selectedFilters;

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
            allFilters = availableFilters;
            selectedFilters = availableFilters;

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

        public Filters applyFilter(Tabs tab, List<string> filteredList)
        {
            // Filter out the elements not matching the filter
            if (Tabs.categories == tab)
            {
                selectedFilters.categories = filteredList;
            }
            else if (Tabs.families == tab)
            {
                selectedFilters.families = filteredList;
            }
            else if (Tabs.types == tab)
            {
                selectedFilters.types = filteredList;
            }
            else if (Tabs.worksets == tab)
            {
                selectedFilters.worksets = filteredList;
            }
            filterElements();

            // Return the available filters
            determineAvailableFilters();
            return availableFilters;
        }

        public Filters clearFilter(Tabs tab)
        {
            if (Tabs.all == tab)
            {
                // Clear all filters
                selectedFilters = allFilters;
            }
            else if (Tabs.categories == tab)
            {
                // Clear category, family, and type filters
                selectedFilters.categories = allFilters.categories;
                selectedFilters.families = allFilters.families;
                selectedFilters.types = allFilters.types;
            }
            else if (Tabs.families == tab)
            {
                // Clear family and type filters
                selectedFilters.families = allFilters.families;
                selectedFilters.types = allFilters.types;
            }
            else if (Tabs.types == tab)
            {
                // Clear type filter
                selectedFilters.types = allFilters.types;
            }
            else if (Tabs.worksets == tab)
            {
                // Clear workset filter
                selectedFilters.categories = allFilters.categories;
            }
            filterElements();

            // Return the available filters
            determineAvailableFilters();
            return availableFilters;
        }

        private void filterElements()
        {
            filteredElements = allElements.Where(filterableElement => {
                bool categoryMatches = selectedFilters.categories.Contains(filterableElement.category);
                bool familyMatches = selectedFilters.families.Contains(filterableElement.family);
                bool typeMatches = selectedFilters.types.Contains(filterableElement.type);
                bool worksetMatches = selectedFilters.worksets.Contains(filterableElement.workset);

                return categoryMatches && familyMatches && typeMatches && worksetMatches;
            }).ToList();
        }

        private void determineAvailableFilters()
        {
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
