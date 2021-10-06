namespace OOP_Lab02_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputNameField = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.inputAuthorField = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.inputYearField = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.inputPublisherField = new System.Windows.Forms.TextBox();
            this.bookSizeLabel = new System.Windows.Forms.Label();
            this.bookSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.formatBox = new System.Windows.Forms.GroupBox();
            this.rbFormat3 = new System.Windows.Forms.RadioButton();
            this.rbFormat2 = new System.Windows.Forms.RadioButton();
            this.rbFormat1 = new System.Windows.Forms.RadioButton();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.inputFileSizeField = new System.Windows.Forms.TextBox();
            this.ulpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uplDateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loadInFile = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_clear = new System.Windows.Forms.Button();
            this.inputUdkField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patternMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookSizeTrackBar)).BeginInit();
            this.formatBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputNameField
            // 
            this.inputNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputNameField.Location = new System.Drawing.Point(16, 70);
            this.inputNameField.Margin = new System.Windows.Forms.Padding(4);
            this.inputNameField.Name = "inputNameField";
            this.inputNameField.Size = new System.Drawing.Size(211, 22);
            this.inputNameField.TabIndex = 0;
            this.inputNameField.TextChanged += new System.EventHandler(this.inputNameField_TextChanged);
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(16, 46);
            this.nameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(45, 17);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Name";
            // 
            // inputAuthorField
            // 
            this.inputAuthorField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputAuthorField.Location = new System.Drawing.Point(16, 132);
            this.inputAuthorField.Margin = new System.Windows.Forms.Padding(4);
            this.inputAuthorField.Name = "inputAuthorField";
            this.inputAuthorField.Size = new System.Drawing.Size(211, 22);
            this.inputAuthorField.TabIndex = 1;
            this.inputAuthorField.TextChanged += new System.EventHandler(this.myTextBox_KeyPress);
            this.inputAuthorField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(16, 107);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(50, 17);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(16, 169);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // inputYearField
            // 
            this.inputYearField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputYearField.Location = new System.Drawing.Point(20, 190);
            this.inputYearField.Margin = new System.Windows.Forms.Padding(4);
            this.inputYearField.Name = "inputYearField";
            this.inputYearField.Size = new System.Drawing.Size(211, 22);
            this.inputYearField.TabIndex = 2;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(16, 316);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(67, 17);
            this.publisherLabel.TabIndex = 5;
            this.publisherLabel.Text = "Publisher";
            // 
            // inputPublisherField
            // 
            this.inputPublisherField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputPublisherField.Location = new System.Drawing.Point(16, 341);
            this.inputPublisherField.Margin = new System.Windows.Forms.Padding(4);
            this.inputPublisherField.Name = "inputPublisherField";
            this.inputPublisherField.Size = new System.Drawing.Size(211, 22);
            this.inputPublisherField.TabIndex = 4;
            // 
            // bookSizeLabel
            // 
            this.bookSizeLabel.AutoSize = true;
            this.bookSizeLabel.Location = new System.Drawing.Point(16, 230);
            this.bookSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookSizeLabel.Name = "bookSizeLabel";
            this.bookSizeLabel.Size = new System.Drawing.Size(91, 17);
            this.bookSizeLabel.TabIndex = 7;
            this.bookSizeLabel.Text = "Book size (1)";
            // 
            // bookSizeTrackBar
            // 
            this.bookSizeTrackBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bookSizeTrackBar.LargeChange = 1;
            this.bookSizeTrackBar.Location = new System.Drawing.Point(16, 255);
            this.bookSizeTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.bookSizeTrackBar.Maximum = 300;
            this.bookSizeTrackBar.Minimum = 1;
            this.bookSizeTrackBar.Name = "bookSizeTrackBar";
            this.bookSizeTrackBar.Size = new System.Drawing.Size(212, 56);
            this.bookSizeTrackBar.TabIndex = 3;
            this.bookSizeTrackBar.Value = 1;
            this.bookSizeTrackBar.Scroll += new System.EventHandler(this.bookSizeTrackBar_Scroll);
            // 
            // formatBox
            // 
            this.formatBox.Controls.Add(this.rbFormat3);
            this.formatBox.Controls.Add(this.rbFormat2);
            this.formatBox.Controls.Add(this.rbFormat1);
            this.formatBox.Location = new System.Drawing.Point(16, 417);
            this.formatBox.Margin = new System.Windows.Forms.Padding(4);
            this.formatBox.Name = "formatBox";
            this.formatBox.Padding = new System.Windows.Forms.Padding(4);
            this.formatBox.Size = new System.Drawing.Size(212, 105);
            this.formatBox.TabIndex = 9;
            this.formatBox.TabStop = false;
            this.formatBox.Text = "Format";
            this.formatBox.Enter += new System.EventHandler(this.formatBox_Enter);
            // 
            // rbFormat3
            // 
            this.rbFormat3.AutoSize = true;
            this.rbFormat3.Location = new System.Drawing.Point(4, 81);
            this.rbFormat3.Margin = new System.Windows.Forms.Padding(4);
            this.rbFormat3.Name = "rbFormat3";
            this.rbFormat3.Size = new System.Drawing.Size(56, 21);
            this.rbFormat3.TabIndex = 2;
            this.rbFormat3.Text = "TXT";
            this.rbFormat3.UseVisualStyleBackColor = true;
            // 
            // rbFormat2
            // 
            this.rbFormat2.AutoSize = true;
            this.rbFormat2.Location = new System.Drawing.Point(4, 53);
            this.rbFormat2.Margin = new System.Windows.Forms.Padding(4);
            this.rbFormat2.Name = "rbFormat2";
            this.rbFormat2.Size = new System.Drawing.Size(66, 21);
            this.rbFormat2.TabIndex = 1;
            this.rbFormat2.Text = "EPUB";
            this.rbFormat2.UseVisualStyleBackColor = true;
            // 
            // rbFormat1
            // 
            this.rbFormat1.AutoSize = true;
            this.rbFormat1.Checked = true;
            this.rbFormat1.Location = new System.Drawing.Point(4, 25);
            this.rbFormat1.Margin = new System.Windows.Forms.Padding(4);
            this.rbFormat1.Name = "rbFormat1";
            this.rbFormat1.Size = new System.Drawing.Size(54, 21);
            this.rbFormat1.TabIndex = 0;
            this.rbFormat1.TabStop = true;
            this.rbFormat1.Text = "FB2";
            this.rbFormat1.UseVisualStyleBackColor = true;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(16, 526);
            this.fileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(59, 17);
            this.fileSizeLabel.TabIndex = 11;
            this.fileSizeLabel.Text = "File size";
            // 
            // inputFileSizeField
            // 
            this.inputFileSizeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputFileSizeField.Location = new System.Drawing.Point(16, 550);
            this.inputFileSizeField.Margin = new System.Windows.Forms.Padding(4);
            this.inputFileSizeField.Name = "inputFileSizeField";
            this.inputFileSizeField.Size = new System.Drawing.Size(211, 22);
            this.inputFileSizeField.TabIndex = 5;
            // 
            // ulpDatePicker
            // 
            this.ulpDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ulpDatePicker.Location = new System.Drawing.Point(16, 612);
            this.ulpDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ulpDatePicker.Name = "ulpDatePicker";
            this.ulpDatePicker.Size = new System.Drawing.Size(211, 22);
            this.ulpDatePicker.TabIndex = 6;
            // 
            // uplDateLabel
            // 
            this.uplDateLabel.AutoSize = true;
            this.uplDateLabel.Location = new System.Drawing.Point(16, 587);
            this.uplDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uplDateLabel.Name = "uplDateLabel";
            this.uplDateLabel.Size = new System.Drawing.Size(101, 17);
            this.uplDateLabel.TabIndex = 13;
            this.uplDateLabel.Text = "Date of upload";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(16, 673);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // loadInFile
            // 
            this.loadInFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadInFile.ForeColor = System.Drawing.SystemColors.Window;
            this.loadInFile.Location = new System.Drawing.Point(267, 43);
            this.loadInFile.Margin = new System.Windows.Forms.Padding(4);
            this.loadInFile.Name = "loadInFile";
            this.loadInFile.Size = new System.Drawing.Size(105, 52);
            this.loadInFile.TabIndex = 8;
            this.loadInFile.Text = "Upload to file";
            this.loadInFile.UseVisualStyleBackColor = false;
            this.loadInFile.Click += new System.EventHandler(this.loadInFile_Click);
            // 
            // loadFromFile
            // 
            this.loadFromFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile.ForeColor = System.Drawing.SystemColors.Window;
            this.loadFromFile.Location = new System.Drawing.Point(380, 43);
            this.loadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(105, 52);
            this.loadFromFile.TabIndex = 9;
            this.loadFromFile.Text = "Load from file";
            this.loadFromFile.UseVisualStyleBackColor = false;
            this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(254, 117);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(333, 628);
            this.listBox.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searhToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // searhToolStripMenuItem
            // 
            this.searhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.patternMenuToolStripMenuItem});
            this.searhToolStripMenuItem.Name = "searhToolStripMenuItem";
            this.searhToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.searhToolStripMenuItem.Text = "Menu";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.patternToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(492, 43);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(108, 52);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "Clear area";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.buttonClearArea);
            // 
            // inputUdkField
            // 
            this.inputUdkField.Location = new System.Drawing.Point(16, 388);
            this.inputUdkField.Name = "inputUdkField";
            this.inputUdkField.Size = new System.Drawing.Size(211, 22);
            this.inputUdkField.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "UDK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patternMenuToolStripMenuItem
            // 
            this.patternMenuToolStripMenuItem.Name = "patternMenuToolStripMenuItem";
            this.patternMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patternMenuToolStripMenuItem.Text = "PatternMenu";
            this.patternMenuToolStripMenuItem.Click += new System.EventHandler(this.patternMenuToolStripMenuItem_Click);
            // 
            // patternToolStripMenuItem
            // 
            this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            this.patternToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patternToolStripMenuItem.Text = "Pattern";
            this.patternToolStripMenuItem.Click += new System.EventHandler(this.patternMenuToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputUdkField);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.loadInFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uplDateLabel);
            this.Controls.Add(this.ulpDatePicker);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.inputFileSizeField);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.bookSizeTrackBar);
            this.Controls.Add(this.bookSizeLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.inputPublisherField);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.inputYearField);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.inputAuthorField);
            this.Controls.Add(this.inputNameField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookSizeTrackBar)).EndInit();
            this.formatBox.ResumeLayout(false);
            this.formatBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNameField;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox inputAuthorField;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox inputYearField;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox inputPublisherField;
        private System.Windows.Forms.Label bookSizeLabel;
        private System.Windows.Forms.TrackBar bookSizeTrackBar;
        private System.Windows.Forms.GroupBox formatBox;
        private System.Windows.Forms.RadioButton rbFormat3;
        private System.Windows.Forms.RadioButton rbFormat2;
        private System.Windows.Forms.RadioButton rbFormat1;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.TextBox inputFileSizeField;
        private System.Windows.Forms.DateTimePicker ulpDatePicker;
        private System.Windows.Forms.Label uplDateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadInFile;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox inputUdkField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem patternMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
    }
}

