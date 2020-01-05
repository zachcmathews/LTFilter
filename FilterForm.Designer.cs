namespace LTFilter
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.categoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.familiesTab = new System.Windows.Forms.TabPage();
            this.familiesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.typesTab = new System.Windows.Forms.TabPage();
            this.typesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.worksetsTab = new System.Windows.Forms.TabPage();
            this.worksetsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.clearTabButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.categoriesTab.SuspendLayout();
            this.familiesTab.SuspendLayout();
            this.typesTab.SuspendLayout();
            this.worksetsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.categoriesTab);
            this.tabControl.Controls.Add(this.familiesTab);
            this.tabControl.Controls.Add(this.typesTab);
            this.tabControl.Controls.Add(this.worksetsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(280, 334);
            this.tabControl.TabIndex = 0;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.categoriesCheckedListBox);
            this.categoriesTab.Location = new System.Drawing.Point(4, 36);
            this.categoriesTab.Margin = new System.Windows.Forms.Padding(1);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(4);
            this.categoriesTab.Size = new System.Drawing.Size(272, 294);
            this.categoriesTab.TabIndex = 3;
            this.categoriesTab.Text = "Category";
            this.categoriesTab.UseVisualStyleBackColor = true;
            this.categoriesTab.Leave += new System.EventHandler(this.categoriesTab_Leave);
            // 
            // categoriesCheckedListBox
            // 
            this.categoriesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesCheckedListBox.CheckOnClick = true;
            this.categoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesCheckedListBox.FormattingEnabled = true;
            this.categoriesCheckedListBox.Location = new System.Drawing.Point(4, 4);
            this.categoriesCheckedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesCheckedListBox.Name = "categoriesCheckedListBox";
            this.categoriesCheckedListBox.Size = new System.Drawing.Size(264, 285);
            this.categoriesCheckedListBox.TabIndex = 2;
            // 
            // familiesTab
            // 
            this.familiesTab.AutoScroll = true;
            this.familiesTab.Controls.Add(this.familiesCheckedListBox);
            this.familiesTab.Location = new System.Drawing.Point(4, 36);
            this.familiesTab.Margin = new System.Windows.Forms.Padding(1);
            this.familiesTab.Name = "familiesTab";
            this.familiesTab.Padding = new System.Windows.Forms.Padding(4);
            this.familiesTab.Size = new System.Drawing.Size(272, 294);
            this.familiesTab.TabIndex = 0;
            this.familiesTab.Text = "Family";
            this.familiesTab.UseVisualStyleBackColor = true;
            this.familiesTab.Leave += new System.EventHandler(this.familiesTab_Leave);
            // 
            // familiesCheckedListBox
            // 
            this.familiesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.familiesCheckedListBox.CheckOnClick = true;
            this.familiesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.familiesCheckedListBox.FormattingEnabled = true;
            this.familiesCheckedListBox.Location = new System.Drawing.Point(4, 4);
            this.familiesCheckedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.familiesCheckedListBox.Name = "familiesCheckedListBox";
            this.familiesCheckedListBox.Size = new System.Drawing.Size(264, 285);
            this.familiesCheckedListBox.TabIndex = 0;
            // 
            // typesTab
            // 
            this.typesTab.Controls.Add(this.typesCheckedListBox);
            this.typesTab.Location = new System.Drawing.Point(4, 36);
            this.typesTab.Margin = new System.Windows.Forms.Padding(1);
            this.typesTab.Name = "typesTab";
            this.typesTab.Padding = new System.Windows.Forms.Padding(4);
            this.typesTab.Size = new System.Drawing.Size(272, 294);
            this.typesTab.TabIndex = 2;
            this.typesTab.Text = "Type";
            this.typesTab.UseVisualStyleBackColor = true;
            this.typesTab.Leave += new System.EventHandler(this.typesTab_Leave);
            // 
            // typesCheckedListBox
            // 
            this.typesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typesCheckedListBox.CheckOnClick = true;
            this.typesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.typesCheckedListBox.FormattingEnabled = true;
            this.typesCheckedListBox.Location = new System.Drawing.Point(4, 4);
            this.typesCheckedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.typesCheckedListBox.Name = "typesCheckedListBox";
            this.typesCheckedListBox.Size = new System.Drawing.Size(264, 285);
            this.typesCheckedListBox.TabIndex = 2;
            // 
            // worksetsTab
            // 
            this.worksetsTab.AutoScroll = true;
            this.worksetsTab.Controls.Add(this.worksetsCheckedListBox);
            this.worksetsTab.Location = new System.Drawing.Point(4, 36);
            this.worksetsTab.Margin = new System.Windows.Forms.Padding(1);
            this.worksetsTab.Name = "worksetsTab";
            this.worksetsTab.Padding = new System.Windows.Forms.Padding(4);
            this.worksetsTab.Size = new System.Drawing.Size(272, 294);
            this.worksetsTab.TabIndex = 1;
            this.worksetsTab.Text = "Workset";
            this.worksetsTab.UseVisualStyleBackColor = true;
            this.worksetsTab.Leave += new System.EventHandler(this.worksetsTab_Leave);
            // 
            // worksetsCheckedListBox
            // 
            this.worksetsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worksetsCheckedListBox.CheckOnClick = true;
            this.worksetsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.worksetsCheckedListBox.FormattingEnabled = true;
            this.worksetsCheckedListBox.Location = new System.Drawing.Point(4, 4);
            this.worksetsCheckedListBox.Margin = new System.Windows.Forms.Padding(0);
            this.worksetsCheckedListBox.Name = "worksetsCheckedListBox";
            this.worksetsCheckedListBox.Size = new System.Drawing.Size(264, 285);
            this.worksetsCheckedListBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(176, 345);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(52, 31);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(230, 345);
            this.applyButton.Margin = new System.Windows.Forms.Padding(1);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(53, 31);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // clearTabButton
            // 
            this.clearTabButton.Location = new System.Drawing.Point(4, 345);
            this.clearTabButton.Name = "clearTabButton";
            this.clearTabButton.Size = new System.Drawing.Size(42, 31);
            this.clearTabButton.TabIndex = 3;
            this.clearTabButton.Text = "Clear";
            this.clearTabButton.UseVisualStyleBackColor = true;
            this.clearTabButton.Click += new System.EventHandler(this.clearTabButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(49, 345);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(55, 31);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // FilterForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(288, 383);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearTabButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LTFilter";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.categoriesTab.ResumeLayout(false);
            this.familiesTab.ResumeLayout(false);
            this.typesTab.ResumeLayout(false);
            this.worksetsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage familiesTab;
        private System.Windows.Forms.TabPage worksetsTab;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckedListBox familiesCheckedListBox;
        private System.Windows.Forms.CheckedListBox worksetsCheckedListBox;
        private System.Windows.Forms.TabPage typesTab;
        private System.Windows.Forms.CheckedListBox typesCheckedListBox;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.CheckedListBox categoriesCheckedListBox;
        private System.Windows.Forms.Button clearTabButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}