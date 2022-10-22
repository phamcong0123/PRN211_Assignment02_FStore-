﻿namespace SalesWinApp
{
    partial class frmMembers
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
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbSearchID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgData
            // 
            this.dvgData.AllowUserToAddRows = false;
            this.dvgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Location = new System.Drawing.Point(11, 12);
            this.dvgData.MultiSelect = false;
            this.dvgData.Name = "dvgData";
            this.dvgData.ReadOnly = true;
            this.dvgData.RowHeadersVisible = false;
            this.dvgData.RowHeadersWidth = 51;
            this.dvgData.RowTemplate.Height = 29;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(780, 459);
            this.dvgData.TabIndex = 0;
            this.dvgData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgData_CellFormatting);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(936, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 67);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(819, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 67);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbSearchID
            // 
            this.lbSearchID.AutoSize = true;
            this.lbSearchID.Location = new System.Drawing.Point(18, 31);
            this.lbSearchID.Name = "lbSearchID";
            this.lbSearchID.Size = new System.Drawing.Size(92, 20);
            this.lbSearchID.TabIndex = 1;
            this.lbSearchID.Text = "Search By ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(142, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 27);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Location = new System.Drawing.Point(18, 77);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(117, 20);
            this.lbSearchName.TabIndex = 2;
            this.lbSearchName.Text = "Search By Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cboCity
            // 
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(142, 128);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(146, 28);
            this.cboCity.TabIndex = 2;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(142, 185);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(146, 28);
            this.cboCountry.TabIndex = 4;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(18, 132);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 5;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(18, 189);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 6;
            this.lbCountry.Text = "Country";
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(49, 293);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(222, 45);
            this.btnSortByName.TabIndex = 7;
            this.btnSortByName.Text = "Sort by name (Descending)";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 238);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 48);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear filter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbFilter
            // 
            this.grbFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbFilter.Controls.Add(this.btnClear);
            this.grbFilter.Controls.Add(this.btnSortByName);
            this.grbFilter.Controls.Add(this.lbCountry);
            this.grbFilter.Controls.Add(this.lbCity);
            this.grbFilter.Controls.Add(this.cboCountry);
            this.grbFilter.Controls.Add(this.cboCity);
            this.grbFilter.Controls.Add(this.txtName);
            this.grbFilter.Controls.Add(this.lbSearchName);
            this.grbFilter.Controls.Add(this.txtID);
            this.grbFilter.Controls.Add(this.lbSearchID);
            this.grbFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbFilter.Location = new System.Drawing.Point(819, 14);
            this.grbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbFilter.Size = new System.Drawing.Size(315, 353);
            this.grbFilter.TabIndex = 9;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1050, 386);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 67);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1179, 485);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dvgData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgData;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lbSearchID;
        private TextBox txtID;
        private Label lbSearchName;
        private TextBox txtName;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Label lbCity;
        private Label lbCountry;
        private Button btnSortByName;
        private Button btnClear;
        private GroupBox grbFilter;
        private Button btnRemove;
    }
}