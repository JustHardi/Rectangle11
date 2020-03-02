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
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
            pictureBox1.Image = Image.FromFile(@"../../Images/milk.png");
            this.textBox1.Text = "Error";
        }      

        public void ShowEquipmentDetails(Equipments scheme)
        {
            if (scheme != null)
            {
                this.pictureBox1.Image = Image.FromFile(@"../../Images/" + scheme.ImageName + ".png");
                this.textBox1.Text = scheme != null ? scheme.ToString() : "Hello";
            }
            this.Show();
            
        }

        public void ShowPoductDetails(Product product)
        {
            if (product != null)
            {
                this.pictureBox1.Image = Image.FromFile(@"../../Images/" + product.ImageName + ".png");
                this.textBox1.Text = product != null ? product.ToString() : "Hello";
            }
            this.Show();

        }
        
    }
}
