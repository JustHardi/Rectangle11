using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("milk.png");
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
            pictureBox1.Image = Image.FromFile("milk.png");
        }
        public void ss2(StringBuilder sb)
        {
            // = sb.ToString();

        }

        public void ShowXapak(Scheme scheme)
        {
            this.Show();   
        }
    }
}
