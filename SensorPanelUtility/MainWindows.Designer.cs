namespace SensorPanelUtility
{
    partial class MainWindows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPanels = new Label();
            listBoxPanels = new ListBox();
            btnNew = new Button();
            btnModify = new Button();
            btnRemove = new Button();
            btnImport = new Button();
            btnExport = new Button();
            picPanelPreview = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPanelPreview).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6633339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6633339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6633339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.010006F));
            tableLayoutPanel1.Controls.Add(lblPanels, 0, 0);
            tableLayoutPanel1.Controls.Add(listBoxPanels, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNew, 0, 2);
            tableLayoutPanel1.Controls.Add(btnModify, 1, 2);
            tableLayoutPanel1.Controls.Add(btnRemove, 2, 2);
            tableLayoutPanel1.Controls.Add(btnImport, 0, 3);
            tableLayoutPanel1.Controls.Add(btnExport, 1, 3);
            tableLayoutPanel1.Controls.Add(picPanelPreview, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(571, 359);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPanels
            // 
            lblPanels.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblPanels, 4);
            lblPanels.Dock = DockStyle.Fill;
            lblPanels.Location = new Point(8, 5);
            lblPanels.Name = "lblPanels";
            lblPanels.Padding = new Padding(0, 10, 0, 0);
            lblPanels.Size = new Size(555, 40);
            lblPanels.TabIndex = 0;
            lblPanels.Text = "Panels";
            // 
            // listBoxPanels
            // 
            tableLayoutPanel1.SetColumnSpan(listBoxPanels, 3);
            listBoxPanels.Dock = DockStyle.Fill;
            listBoxPanels.FormattingEnabled = true;
            listBoxPanels.ItemHeight = 15;
            listBoxPanels.Location = new Point(8, 48);
            listBoxPanels.Name = "listBoxPanels";
            listBoxPanels.Size = new Size(273, 223);
            listBoxPanels.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(8, 277);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 34);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Dock = DockStyle.Fill;
            btnModify.Location = new Point(101, 277);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(87, 34);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Location = new Point(194, 277);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 34);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Delete";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Fill;
            btnImport.Location = new Point(8, 317);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(87, 34);
            btnImport.TabIndex = 5;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Fill;
            btnExport.Location = new Point(101, 317);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(87, 34);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // picPanelPreview
            // 
            picPanelPreview.Dock = DockStyle.Fill;
            picPanelPreview.Location = new Point(287, 48);
            picPanelPreview.Name = "picPanelPreview";
            tableLayoutPanel1.SetRowSpan(picPanelPreview, 3);
            picPanelPreview.Size = new Size(276, 303);
            picPanelPreview.TabIndex = 7;
            picPanelPreview.TabStop = false;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 359);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainWindows";
            Text = "Sensor Panel Utility";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPanelPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPanels;
        private ListBox listBoxPanels;
        private Button btnNew;
        private Button btnModify;
        private Button btnRemove;
        private Button btnImport;
        private Button btnExport;
        private PictureBox picPanelPreview;
    }
}