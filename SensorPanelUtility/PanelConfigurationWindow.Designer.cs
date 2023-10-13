﻿namespace SensorPanelUtility
{
    partial class PanelConfigurationWindow
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
            lblScreenTitle = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtSizeWidth = new TextBox();
            label3 = new Label();
            txtSizeHeight = new TextBox();
            lblOpacity = new Label();
            sliderOpacity = new TrackBar();
            chkAlwaysOnTop = new CheckBox();
            label5 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            label7 = new Label();
            dgvWidgets = new DataGridView();
            colIcon = new DataGridViewImageColumn();
            Type = new DataGridViewTextBoxColumn();
            colX = new DataGridViewTextBoxColumn();
            colY = new DataGridViewTextBoxColumn();
            colVisible = new DataGridViewCheckBoxColumn();
            btnAddWidget = new Button();
            btnModifyWidget = new Button();
            btnRemoveWidget = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            txtPositionX = new TextBox();
            txtPositionY = new TextBox();
            ((System.ComponentModel.ISupportInitialize)sliderOpacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWidgets).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblScreenTitle
            // 
            lblScreenTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblScreenTitle, 3);
            lblScreenTitle.Dock = DockStyle.Fill;
            lblScreenTitle.Location = new Point(8, 5);
            lblScreenTitle.Name = "lblScreenTitle";
            lblScreenTitle.Padding = new Padding(0, 10, 0, 0);
            lblScreenTitle.Size = new Size(321, 40);
            lblScreenTitle.TabIndex = 0;
            lblScreenTitle.Text = "New Panel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(8, 45);
            label2.Name = "label2";
            label2.Size = new Size(103, 40);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtName
            // 
            tableLayoutPanel1.SetColumnSpan(txtName, 2);
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(117, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtSizeWidth
            // 
            txtSizeWidth.Dock = DockStyle.Fill;
            txtSizeWidth.Location = new Point(117, 88);
            txtSizeWidth.Name = "txtSizeWidth";
            txtSizeWidth.Size = new Size(103, 23);
            txtSizeWidth.TabIndex = 4;
            txtSizeWidth.TextChanged += txtSizeWidth_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(103, 40);
            label3.TabIndex = 3;
            label3.Text = "Size (W x H)";
            // 
            // txtSizeHeight
            // 
            txtSizeHeight.Dock = DockStyle.Fill;
            txtSizeHeight.Location = new Point(226, 88);
            txtSizeHeight.Name = "txtSizeHeight";
            txtSizeHeight.Size = new Size(103, 23);
            txtSizeHeight.TabIndex = 6;
            txtSizeHeight.TextChanged += txtSizeHeight_TextChanged;
            // 
            // lblOpacity
            // 
            lblOpacity.AutoSize = true;
            lblOpacity.Dock = DockStyle.Fill;
            lblOpacity.Location = new Point(8, 205);
            lblOpacity.Name = "lblOpacity";
            lblOpacity.Size = new Size(103, 40);
            lblOpacity.TabIndex = 5;
            lblOpacity.Text = "Opacity (100%)";
            // 
            // sliderOpacity
            // 
            tableLayoutPanel1.SetColumnSpan(sliderOpacity, 2);
            sliderOpacity.Dock = DockStyle.Fill;
            sliderOpacity.Location = new Point(117, 208);
            sliderOpacity.Maximum = 100;
            sliderOpacity.Name = "sliderOpacity";
            sliderOpacity.Size = new Size(212, 34);
            sliderOpacity.TabIndex = 10;
            sliderOpacity.TickFrequency = 10;
            sliderOpacity.Value = 100;
            sliderOpacity.Scroll += sliderOpacity_Scroll;
            // 
            // chkAlwaysOnTop
            // 
            chkAlwaysOnTop.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(chkAlwaysOnTop, 2);
            chkAlwaysOnTop.Dock = DockStyle.Fill;
            chkAlwaysOnTop.Location = new Point(117, 168);
            chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            chkAlwaysOnTop.Size = new Size(212, 34);
            chkAlwaysOnTop.TabIndex = 11;
            chkAlwaysOnTop.Text = "Always on top";
            chkAlwaysOnTop.UseVisualStyleBackColor = true;
            chkAlwaysOnTop.CheckedChanged += chkAlwaysOnTop_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(8, 165);
            label5.Name = "label5";
            label5.Size = new Size(103, 40);
            label5.TabIndex = 12;
            label5.Text = "Visibility";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(8, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(117, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 34);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label7, 3);
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(335, 5);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 10, 0, 0);
            label7.Size = new Size(321, 40);
            label7.TabIndex = 15;
            label7.Text = "Widgets";
            // 
            // dgvWidgets
            // 
            dgvWidgets.AllowUserToAddRows = false;
            dgvWidgets.AllowUserToDeleteRows = false;
            dgvWidgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWidgets.Columns.AddRange(new DataGridViewColumn[] { colIcon, Type, colX, colY, colVisible });
            tableLayoutPanel1.SetColumnSpan(dgvWidgets, 3);
            dgvWidgets.Dock = DockStyle.Fill;
            dgvWidgets.Location = new Point(335, 48);
            dgvWidgets.Name = "dgvWidgets";
            dgvWidgets.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(dgvWidgets, 5);
            dgvWidgets.RowTemplate.Height = 25;
            dgvWidgets.Size = new Size(321, 194);
            dgvWidgets.TabIndex = 16;
            // 
            // colIcon
            // 
            colIcon.HeaderText = "Icon";
            colIcon.Name = "colIcon";
            colIcon.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Resizable = DataGridViewTriState.True;
            Type.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colX
            // 
            colX.HeaderText = "X";
            colX.Name = "colX";
            colX.ReadOnly = true;
            // 
            // colY
            // 
            colY.HeaderText = "Y";
            colY.Name = "colY";
            colY.ReadOnly = true;
            // 
            // colVisible
            // 
            colVisible.HeaderText = "Visible";
            colVisible.Name = "colVisible";
            colVisible.ReadOnly = true;
            // 
            // btnAddWidget
            // 
            btnAddWidget.Dock = DockStyle.Fill;
            btnAddWidget.Location = new Point(335, 289);
            btnAddWidget.Name = "btnAddWidget";
            btnAddWidget.Size = new Size(103, 34);
            btnAddWidget.TabIndex = 17;
            btnAddWidget.Text = "Add Widget";
            btnAddWidget.UseVisualStyleBackColor = true;
            // 
            // btnModifyWidget
            // 
            btnModifyWidget.Dock = DockStyle.Fill;
            btnModifyWidget.Location = new Point(444, 289);
            btnModifyWidget.Name = "btnModifyWidget";
            btnModifyWidget.Size = new Size(103, 34);
            btnModifyWidget.TabIndex = 18;
            btnModifyWidget.Text = "Modify Widget";
            btnModifyWidget.UseVisualStyleBackColor = true;
            // 
            // btnRemoveWidget
            // 
            btnRemoveWidget.Dock = DockStyle.Fill;
            btnRemoveWidget.Location = new Point(553, 289);
            btnRemoveWidget.Name = "btnRemoveWidget";
            btnRemoveWidget.Size = new Size(103, 34);
            btnRemoveWidget.TabIndex = 19;
            btnRemoveWidget.Text = "Remove Widget";
            btnRemoveWidget.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.Controls.Add(dgvWidgets, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 3, 0);
            tableLayoutPanel1.Controls.Add(lblScreenTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSizeHeight, 2, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtSizeWidth, 1, 2);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 7);
            tableLayoutPanel1.Controls.Add(btnClose, 1, 7);
            tableLayoutPanel1.Controls.Add(btnAddWidget, 3, 7);
            tableLayoutPanel1.Controls.Add(btnModifyWidget, 4, 7);
            tableLayoutPanel1.Controls.Add(btnRemoveWidget, 5, 7);
            tableLayoutPanel1.Controls.Add(lblOpacity, 0, 5);
            tableLayoutPanel1.Controls.Add(sliderOpacity, 1, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(chkAlwaysOnTop, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPositionX, 1, 3);
            tableLayoutPanel1.Controls.Add(txtPositionY, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(664, 331);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(8, 125);
            label6.Name = "label6";
            label6.Size = new Size(103, 40);
            label6.TabIndex = 20;
            label6.Text = "Position (L x T)";
            // 
            // txtPositionX
            // 
            txtPositionX.Dock = DockStyle.Fill;
            txtPositionX.Location = new Point(117, 128);
            txtPositionX.Name = "txtPositionX";
            txtPositionX.Size = new Size(103, 23);
            txtPositionX.TabIndex = 21;
            txtPositionX.TextChanged += txtPositionX_TextChanged;
            // 
            // txtPositionY
            // 
            txtPositionY.Dock = DockStyle.Fill;
            txtPositionY.Location = new Point(226, 128);
            txtPositionY.Name = "txtPositionY";
            txtPositionY.Size = new Size(103, 23);
            txtPositionY.TabIndex = 22;
            txtPositionY.TextChanged += txtPositionY_TextChanged;
            // 
            // PanelConfigurationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 331);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(680, 370);
            Name = "PanelConfigurationWindow";
            Text = "Panel Configuration Window";
            FormClosing += PanelConfigurationWindow_FormClosing;
            Load += PanelConfigurationWindow_Load;
            ((System.ComponentModel.ISupportInitialize)sliderOpacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWidgets).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblScreenTitle;
        private Label label2;
        private TextBox txtName;
        private TextBox txtSizeWidth;
        private Label label3;
        private TextBox txtSizeHeight;
        private Label lblOpacity;
        private TrackBar sliderOpacity;
        private CheckBox chkAlwaysOnTop;
        private Label label5;
        private Button btnSave;
        private Button btnClose;
        private Label label7;
        private DataGridView dgvWidgets;
        private DataGridViewImageColumn colIcon;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colY;
        private DataGridViewCheckBoxColumn colVisible;
        private Button btnAddWidget;
        private Button btnModifyWidget;
        private Button btnRemoveWidget;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private TextBox txtPositionX;
        private TextBox txtPositionY;
    }
}