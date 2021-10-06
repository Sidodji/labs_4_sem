
namespace OOP_Lab02_3
{
    partial class PatternForm
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
            this.nameForm = new System.Windows.Forms.Label();
            this.OutputPatternInfo = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.AbstractFactory = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnBuilder1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bngSingleton = new System.Windows.Forms.Button();
            this.Prototype = new System.Windows.Forms.Button();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.ObjCar1 = new System.Windows.Forms.Button();
            this.ObjCar2 = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameForm.Location = new System.Drawing.Point(224, 9);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(270, 34);
            this.nameForm.TabIndex = 1;
            this.nameForm.Text = "Работа с паттернами";
            // 
            // OutputPatternInfo
            // 
            this.OutputPatternInfo.AutoSize = true;
            this.OutputPatternInfo.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputPatternInfo.Location = new System.Drawing.Point(563, 59);
            this.OutputPatternInfo.Name = "OutputPatternInfo";
            this.OutputPatternInfo.Size = new System.Drawing.Size(169, 29);
            this.OutputPatternInfo.TabIndex = 2;
            this.OutputPatternInfo.Text = "Вывод информации";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(316, 91);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 45);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить листинг";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClearArea);
            // 
            // AbstractFactory
            // 
            this.AbstractFactory.Location = new System.Drawing.Point(12, 98);
            this.AbstractFactory.Name = "AbstractFactory";
            this.AbstractFactory.Size = new System.Drawing.Size(97, 45);
            this.AbstractFactory.TabIndex = 4;
            this.AbstractFactory.Text = "Factory";
            this.AbstractFactory.UseVisualStyleBackColor = true;
            this.AbstractFactory.Click += new System.EventHandler(this.AbstractFactory_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(583, 273);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(8, 8);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(491, 98);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(307, 346);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // btnBuilder1
            // 
            this.btnBuilder1.Location = new System.Drawing.Point(12, 171);
            this.btnBuilder1.Name = "btnBuilder1";
            this.btnBuilder1.Size = new System.Drawing.Size(97, 45);
            this.btnBuilder1.TabIndex = 9;
            this.btnBuilder1.Text = "Builder form";
            this.btnBuilder1.UseVisualStyleBackColor = true;
            this.btnBuilder1.Click += new System.EventHandler(this.BuilderForm_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Builder btn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuilderButton_click);
            // 
            // bngSingleton
            // 
            this.bngSingleton.Location = new System.Drawing.Point(12, 297);
            this.bngSingleton.Name = "bngSingleton";
            this.bngSingleton.Size = new System.Drawing.Size(97, 45);
            this.bngSingleton.TabIndex = 11;
            this.bngSingleton.Text = "Singleton";
            this.bngSingleton.UseVisualStyleBackColor = true;
            this.bngSingleton.Click += new System.EventHandler(this.btnSingleton_click);
            // 
            // Prototype
            // 
            this.Prototype.Location = new System.Drawing.Point(12, 361);
            this.Prototype.Name = "Prototype";
            this.Prototype.Size = new System.Drawing.Size(97, 45);
            this.Prototype.TabIndex = 12;
            this.Prototype.Text = "Prototype";
            this.Prototype.UseVisualStyleBackColor = true;
            this.Prototype.Click += new System.EventHandler(this.Prototype_Click);
            // 
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(132, 98);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(97, 45);
            this.btnAdapter.TabIndex = 13;
            this.btnAdapter.Text = "Adapter";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // ObjCar1
            // 
            this.ObjCar1.Location = new System.Drawing.Point(132, 171);
            this.ObjCar1.Name = "ObjCar1";
            this.ObjCar1.Size = new System.Drawing.Size(97, 45);
            this.ObjCar1.TabIndex = 14;
            this.ObjCar1.Text = "Car obj 1 ";
            this.ObjCar1.UseVisualStyleBackColor = true;
            this.ObjCar1.Click += new System.EventHandler(this.ObjCar1_Click);
            // 
            // ObjCar2
            // 
            this.ObjCar2.Location = new System.Drawing.Point(132, 236);
            this.ObjCar2.Name = "ObjCar2";
            this.ObjCar2.Size = new System.Drawing.Size(97, 45);
            this.ObjCar2.TabIndex = 15;
            this.ObjCar2.Text = "Car obj 2";
            this.ObjCar2.UseVisualStyleBackColor = true;
            this.ObjCar2.Click += new System.EventHandler(this.ObjCar2_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(132, 297);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(97, 45);
            this.Undo.TabIndex = 16;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.ObjCar2);
            this.Controls.Add(this.ObjCar1);
            this.Controls.Add(this.btnAdapter);
            this.Controls.Add(this.Prototype);
            this.Controls.Add(this.bngSingleton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuilder1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AbstractFactory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.OutputPatternInfo);
            this.Controls.Add(this.nameForm);
            this.Name = "PatternForm";
            this.Text = "PatternForm";
            this.Load += new System.EventHandler(this.PatternsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.Label OutputPatternInfo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button AbstractFactory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnBuilder1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bngSingleton;
        private System.Windows.Forms.Button Prototype;
        private System.Windows.Forms.Button btnAdapter;
        private System.Windows.Forms.Button ObjCar1;
        private System.Windows.Forms.Button ObjCar2;
        private System.Windows.Forms.Button Undo;
    }
}