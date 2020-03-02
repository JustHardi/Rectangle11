using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle11
{
    public partial class Form1 : Form
    {
        public bool IsShowDetails { get; set; } = false;
        public Product product;
        List<Equipments> eq = new List<Equipments>();
             
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"../../Images/milk.png");
            product = FileReader.GetProduct();
            eq = FileReader.GetEquipments();
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();            
            if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 180 && e.Location.Y <= 490) //x+30 машина
            {           
                if (e.Button == MouseButtons.Left && IsShowDetails == false)
                {
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    newForm.ShowPoductDetails(product);
                    IsShowDetails = true;
                    
                }
            }

            if (e.Location.X >= 181 && e.Location.Y >= 270 && e.Location.X <= 216 && e.Location.Y <= 490)//насос
            {
                if (e.Button == MouseButtons.Left && IsShowDetails == false)
                {                    
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    newForm.ShowEquipmentDetails(eq[0]);
                    IsShowDetails = true;
                }
            }
            if (e.Location.X >= 217 && e.Location.Y >= 270 && e.Location.X <= 257 && e.Location.Y <= 490)//весы
            {
                if (e.Button == MouseButtons.Left && IsShowDetails == false)
                {
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    newForm.ShowEquipmentDetails(eq[0]);
                    IsShowDetails = true;
                }
            }
            if (e.Location.X >= 258 && e.Location.Y >= 270 && e.Location.X <= 353 && e.Location.Y <= 490)//охладитель
            {
                if (e.Button == MouseButtons.Left && IsShowDetails == false)
                {
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    newForm.ShowEquipmentDetails(eq[0]);
                    IsShowDetails = true;
                }
            }
            if (e.Location.X >= 354 && e.Location.Y >= 270 && e.Location.X <= 524 && e.Location.Y <= 490)//резервуар
            {
                if (e.Button == MouseButtons.Left && IsShowDetails == false)
                {
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    newForm.ShowEquipmentDetails(eq[0]);
                    IsShowDetails = true;
                }
            }

        }
              
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            

            if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 180 && e.Location.Y <= 490)//машина
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 5, 270, 175, 220);
                }                
            }

            if (e.Location.X >= 181 && e.Location.Y >= 270 && e.Location.X <= 216 && e.Location.Y <= 490)//насос
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 181, 270, 35, 220);
                }
            }
            if (e.Location.X >= 217 && e.Location.Y >= 270 && e.Location.X <= 257 && e.Location.Y <= 490)//весы
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 217, 270, 40, 220);
                }
            }
            if (e.Location.X >= 258 && e.Location.Y >= 270 && e.Location.X <= 353 && e.Location.Y <= 490)//охладитель
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 258, 270, 95, 220);
                }
            }
            if (e.Location.X >= 354 && e.Location.Y >= 270 && e.Location.X <= 524 && e.Location.Y <= 490)//резервуар
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 354, 270, 169, 220);
                }
            }

        }

        private void CloseDetails(object sender, FormClosingEventArgs e)
        {
            IsShowDetails = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void milkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            
        }

        private void исходныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsShowDetails == false)
            {
                Form2 newForm = new Form2(this);
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                newForm.ShowPoductDetails(product);
                IsShowDetails = true;
            }
        }
    }
}
