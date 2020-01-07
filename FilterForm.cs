using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTFilter
{
    public enum Tabs { categories = 0, families = 1, types = 2, worksets = 3, all = 4 };

    public partial class FilterForm : Form
    {
        private readonly Command filter;

        public FilterForm(Command filter, Filters availableFilters)
        {
            InitializeComponent();
            this.filter = filter;
            drawForm(availableFilters);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (categoriesTab == tabControl.SelectedTab)
            {
                categoriesTab_Leave(sender, e);
            }
            else if (familiesTab == tabControl.SelectedTab)
            {
                familiesTab_Leave(sender, e);
            }
            else if (typesTab == tabControl.SelectedTab)
            {
                typesTab_Leave(sender, e);
            }
            else if (worksetsTab == tabControl.SelectedTab)
            {
                worksetsTab_Leave(sender, e);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void categoriesTab_Leave(object sender, EventArgs e)
        {
            List<string> filteredList = categoriesCheckedListBox.CheckedItems.OfType<string>().ToList();
            if (filteredList.Count > 0)
            {
                Filters availableFilters = filter.applyFilter(Tabs.categories, filteredList);
                drawForm(availableFilters);
            }
        }

        private void familiesTab_Leave(object sender, EventArgs e)
        {
            List<string> filteredList = familiesCheckedListBox.CheckedItems.OfType<string>().ToList();
            if (filteredList.Count > 0)
            {
                Filters availableFilters = filter.applyFilter(Tabs.families, filteredList);
                drawForm(availableFilters);
            }

        }

        private void typesTab_Leave(object sender, EventArgs e)
        {
            List<string> filteredList = typesCheckedListBox.CheckedItems.OfType<string>().ToList();
            if (filteredList.Count > 0)
            {
                Filters availableFilters = filter.applyFilter(Tabs.types, filteredList);
                drawForm(availableFilters);
            }
        }

        private void worksetsTab_Leave(object sender, EventArgs e)
        {
            List<string> filteredList = worksetsCheckedListBox.CheckedItems.OfType<string>().ToList();
            if (filteredList.Count > 0)
            {
                Filters availableFilters = filter.applyFilter(Tabs.worksets, filteredList);
                drawForm(availableFilters);
            }
        }

        private void drawForm(Filters availableFilters)
        {
            // Clear the checklist
            categoriesCheckedListBox.Items.Clear();
            familiesCheckedListBox.Items.Clear();
            typesCheckedListBox.Items.Clear();
            worksetsCheckedListBox.Items.Clear();

            // Show the checklist
            categoriesCheckedListBox.Items.AddRange(availableFilters.categories.ToArray());
            familiesCheckedListBox.Items.AddRange(availableFilters.families.ToArray());
            typesCheckedListBox.Items.AddRange(availableFilters.types.ToArray());
            worksetsCheckedListBox.Items.AddRange(availableFilters.worksets.ToArray());
        }

        private void clearTabButton_Click(object sender, EventArgs e)
        {
            Filters availableFilters = new Filters();
            if (categoriesTab == tabControl.SelectedTab)
            {
                availableFilters = filter.clearFilter(Tabs.categories);
                drawForm(availableFilters);
            }
            else if (familiesTab == tabControl.SelectedTab)
            {
                availableFilters = filter.clearFilter(Tabs.families);
                drawForm(availableFilters);
            }
            else if (typesTab == tabControl.SelectedTab)
            {
                availableFilters = filter.clearFilter(Tabs.types);
                drawForm(availableFilters);
            }
            else if (worksetsTab == tabControl.SelectedTab)
            {
                availableFilters = filter.clearFilter(Tabs.worksets);
                drawForm(availableFilters);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            Filters availableFilters = filter.clearFilter(Tabs.all);
            drawForm(availableFilters);
        }
    }
}
