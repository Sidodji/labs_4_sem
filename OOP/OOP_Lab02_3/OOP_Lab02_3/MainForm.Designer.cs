namespace Library
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
            this.clear = new System.Windows.Forms.Button();
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
            this.nameLable.Size = new System.Drawing.Size(112, 17);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Название книги";
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
            this.authorLabel.Size = new System.Drawing.Size(47, 17);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Автор";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(16, 169);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 17);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Год";
            // 
            // inputYearField
            // 
            this.inputYearField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inputYearField.Location = new System.Drawing.Point(16, 193);
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
            this.publisherLabel.Size = new System.Drawing.Size(71, 17);
            this.publisherLabel.TabIndex = 5;
            this.publisherLabel.Text = "Издатель";
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
            this.bookSizeLabel.Size = new System.Drawing.Size(144, 17);
            this.bookSizeLabel.TabIndex = 7;
            this.bookSizeLabel.Text = "Количество страниц";
            this.bookSizeLabel.Click += new System.EventHandler(this.bookSizeLabel_Click);
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
            this.formatBox.Location = new System.Drawing.Point(16, 390);
            this.formatBox.Margin = new System.Windows.Forms.Padding(4);
            this.formatBox.Name = "formatBox";
            this.formatBox.Padding = new System.Windows.Forms.Padding(4);
            this.formatBox.Size = new System.Drawing.Size(212, 123);
            this.formatBox.TabIndex = 9;
            this.formatBox.TabStop = false;
            this.formatBox.Text = "Электронный формат";
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
            this.fileSizeLabel.Size = new System.Drawing.Size(104, 17);
            this.fileSizeLabel.TabIndex = 11;
            this.fileSizeLabel.Text = "Размер файла";
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
            this.uplDateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.uplDateLabel.Location = new System.Drawing.Point(16, 587);
            this.uplDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uplDateLabel.Name = "uplDateLabel";
            this.uplDateLabel.Size = new System.Drawing.Size(103, 17);
            this.uplDateLabel.TabIndex = 13;
            this.uplDateLabel.Text = "Дата загрузки";
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
            this.loadInFile.Size = new System.Drawing.Size(100, 50);
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
            this.loadFromFile.Location = new System.Drawing.Point(385, 43);
            this.loadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(100, 50);
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
            this.listBox.Location = new System.Drawing.Point(267, 103);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(333, 628);
            this.listBox.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searhToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(616, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // searhToolStripMenuItem
            // 
            this.searhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.searhToolStripMenuItem.Name = "searhToolStripMenuItem";
            this.searhToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searhToolStripMenuItem.Text = "Меню";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.aboutToolStripMenuItem.Text = "Помощь";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem1.Text = "Автор";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.Control;
            this.clear.Location = new System.Drawing.Point(500, 43);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 53);
            this.clear.TabIndex = 15;
            this.clear.Text = "Сlear output";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.ClearListBox);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(616, 758);
            this.Controls.Add(this.clear);
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
            this.Text = "Электронная библиотека";
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
        private System.Windows.Forms.Button clear;
    }
}

