using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_Lab02_3.Builder
{
    public class FormBuilder : IBuilder
    {
        private Form form = new Form();
        private Button btn = new Button();

        public void SetWindow(System.Drawing.Size sizeWindow)
        {
            form.Size = sizeWindow;
            this.form.Show();
        }

        public void SetButton(Point locationButton, Size sizeButton, string name)
        {
            this.btn.Location = locationButton;
            this.btn.Size = sizeButton;
            this.btn.Text = name;
            this.form.Controls.Add(this.btn);
        }
    }
}
