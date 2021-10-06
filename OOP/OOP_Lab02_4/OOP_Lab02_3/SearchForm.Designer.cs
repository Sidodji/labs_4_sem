namespace OOP_Lab02_3
{
    partial class SearchForm
    {
        Library library;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.inputBookTitle = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.listBoxSearchResult = new System.Windows.Forms.ListBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.gbSearchFormat = new System.Windows.Forms.GroupBox();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.rbLinq = new System.Windows.Forms.RadioButton();
            this.btnUploadToFile = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PageSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnVissible = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbSearchFormat.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBookTitle
            // 
            this.inputBookTitle.Location = new System.Drawing.Point(16, 61);
            this.inputBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.inputBookTitle.Name = "inputBookTitle";
            this.inputBookTitle.Size = new System.Drawing.Size(469, 22);
            this.inputBookTitle.TabIndex = 0;
            this.inputBookTitle.TextChanged += new System.EventHandler(this.inputBookTitle_TextChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(206, 40);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(76, 17);
            this.lable.TabIndex = 1;
            this.lable.Text = "Book title";
            // 
            // listBoxSearchResult
            // 
            this.listBoxSearchResult.FormattingEnabled = true;
            this.listBoxSearchResult.ItemHeight = 16;
            this.listBoxSearchResult.Location = new System.Drawing.Point(16, 97);
            this.listBoxSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSearchResult.Name = "listBoxSearchResult";
            this.listBoxSearchResult.Size = new System.Drawing.Size(469, 196);
            this.listBoxSearchResult.TabIndex = 2;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(15, 297);
            this.labelFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(64, 17);
            this.labelFound.TabIndex = 3;
            this.labelFound.Text = "Found: 0";
            // 
            // gbSearchFormat
            // 
            this.gbSearchFormat.Controls.Add(this.rbRegex);
            this.gbSearchFormat.Controls.Add(this.rbLinq);
            this.gbSearchFormat.ForeColor = System.Drawing.Color.Black;
            this.gbSearchFormat.Location = new System.Drawing.Point(509, 61);
            this.gbSearchFormat.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchFormat.Name = "gbSearchFormat";
            this.gbSearchFormat.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchFormat.Size = new System.Drawing.Size(125, 106);
            this.gbSearchFormat.TabIndex = 4;
            this.gbSearchFormat.TabStop = false;
            this.gbSearchFormat.Text = "Search format";
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(9, 54);
            this.rbRegex.Margin = new System.Windows.Forms.Padding(4);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(69, 21);
            this.rbRegex.TabIndex = 1;
            this.rbRegex.Text = "Regex";
            this.rbRegex.UseVisualStyleBackColor = true;
            this.rbRegex.CheckedChanged += new System.EventHandler(this.rbSearchFormat_CheckedChanged);
            // 
            // rbLinq
            // 
            this.rbLinq.AutoSize = true;
            this.rbLinq.Checked = true;
            this.rbLinq.Location = new System.Drawing.Point(9, 25);
            this.rbLinq.Margin = new System.Windows.Forms.Padding(4);
            this.rbLinq.Name = "rbLinq";
            this.rbLinq.Size = new System.Drawing.Size(61, 21);
            this.rbLinq.TabIndex = 0;
            this.rbLinq.TabStop = true;
            this.rbLinq.Text = "LINQ";
            this.rbLinq.UseVisualStyleBackColor = true;
            this.rbLinq.CheckedChanged += new System.EventHandler(this.rbSearchFormat_CheckedChanged);
            // 
            // btnUploadToFile
            // 
            this.btnUploadToFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUploadToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUploadToFile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUploadToFile.Location = new System.Drawing.Point(509, 252);
            this.btnUploadToFile.Name = "btnUploadToFile";
            this.btnUploadToFile.Size = new System.Drawing.Size(125, 41);
            this.btnUploadToFile.TabIndex = 6;
            this.btnUploadToFile.Text = "upload to file";
            this.btnUploadToFile.UseVisualStyleBackColor = false;
            this.btnUploadToFile.Click += new System.EventHandler(this.loadInFile_Click2);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.PageSort,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(646, 27);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "YearSort";
            this.toolStripButton1.Click += new System.EventHandler(this.YearSort_Click);
            // 
            // PageSort
            // 
            this.PageSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PageSort.Image = ((System.Drawing.Image)(resources.GetObject("PageSort.Image")));
            this.PageSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PageSort.Name = "PageSort";
            this.PageSort.Size = new System.Drawing.Size(29, 24);
            this.PageSort.Text = "PageSort";
            this.PageSort.Click += new System.EventHandler(this.PageSort_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "UploadSort";
            this.toolStripButton3.Click += new System.EventHandler(this.UploadSort_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Clear area";
            this.toolStripButton2.Click += new System.EventHandler(this.buttonClearArea);
            // 
            // btnVissible
            // 
            this.btnVissible.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVissible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVissible.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVissible.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVissible.Location = new System.Drawing.Point(509, 188);
            this.btnVissible.Name = "btnVissible";
            this.btnVissible.Size = new System.Drawing.Size(125, 41);
            this.btnVissible.TabIndex = 8;
            this.btnVissible.Text = "tool strip";
            this.btnVissible.UseVisualStyleBackColor = false;
            this.btnVissible.Click += new System.EventHandler(this.buttonVisible);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 322);
            this.Controls.Add(this.btnVissible);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnUploadToFile);
            this.Controls.Add(this.gbSearchFormat);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.listBoxSearchResult);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.inputBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.gbSearchFormat.ResumeLayout(false);
            this.gbSearchFormat.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBookTitle;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ListBox listBoxSearchResult;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.GroupBox gbSearchFormat;
        private System.Windows.Forms.RadioButton rbRegex;
        private System.Windows.Forms.RadioButton rbLinq;
        private System.Windows.Forms.Button btnUploadToFile;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton PageSort;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnVissible;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}