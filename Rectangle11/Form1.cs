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
             
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("milk.png");

            

            // handler

        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();            
            if (e.Location.X >= 5 && e.Location.Y >= 300 && e.Location.X <= 180 && e.Location.Y <= 470) //x+30 
            {           
                if (e.Button == MouseButtons.Left)
                {                    
                    Form2 newForm = new Form2(this);
                    newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                    IsShowDetails = true;
                    newForm.ShowXapak(null);
                }
            }

            //else if (e.Location.X > 110 && e.Location.Y > 110)
            //{
            //    // pictureBox1.ClientRectangle.
            //    MessageBox.Show("hello11", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

            if (e.Location.X >= 181 && e.Location.Y >= 300 && e.Location.X <= 216 && e.Location.Y <= 470)//насос
            {
                if (e.Button == MouseButtons.Left)
                {                    
                    Form2 newForm = new Form2(this);
                    newForm.ShowXapak(null);
                }
            }
            if (e.Location.X >= 217 && e.Location.Y >= 300 && e.Location.X <= 257 && e.Location.Y <= 470)//весы
            {
                if (e.Button == MouseButtons.Left)
                {
                    Form2 newForm = new Form2(this);
                    newForm.ShowXapak(null);
                }
            }
            if (e.Location.X >= 258 && e.Location.Y >= 300 && e.Location.X <= 353 && e.Location.Y <= 470)//охладитель
            {
                if (e.Button == MouseButtons.Left)
                {
                    Form2 newForm = new Form2(this);
                    newForm.ShowXapak(null);
                }
            }
            if (e.Location.X >= 354 && e.Location.Y >= 300 && e.Location.X <= 524 && e.Location.Y <= 470)//резервуар
            {
                if (e.Button == MouseButtons.Left)
                {
                    Form2 newForm = new Form2(this);
                    newForm.ShowXapak(null);
                }
            }

        }

        public void ss()
        {
            List<Equipment> Equipments = new List<Equipment>();

            Equipments.Add(new Nasos());

            foreach (var ob in Equipments)
            {
                if (ob.Coordinates.IsVisible(new Point()))
                {
                    ss2(ob.Show());
                }
            }
        }

        public void ss2(StringBuilder sb)
        {
            //textBox1.Text = sb.ToString();

        }

        public abstract class Equipment
        {
            public virtual GraphicsPath Coordinates { get; set; }

            public virtual int Mass { get; set; } = 0;

            public virtual int Power { get; set; } = 0;

            public virtual int Temperature { get; set; } = 0;
           
            public virtual int Storage { get; set; } = 0; //хранение
           
            public virtual int Pressure { get; set; } = 0; //давление
            
            public virtual int Delay { get; set; } = 0; //выдержка

            public StringBuilder Show()
            {
                StringBuilder sb = new StringBuilder();

                if (Mass != 0)
                {
                    sb.AppendLine("Mass:" + Mass + "");
                }

                if (Power != 0)
                {
                    sb.AppendLine("Power:" + Power + "");
                }

                return sb;
            }
        }

        public class Nasos : Equipment
        {
            public override GraphicsPath Coordinates { get; set; }

        }
              
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            if (e.Location.X >= 5 && e.Location.Y >= 300 && e.Location.X <= 180 && e.Location.Y <= 470)
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 5, 300, 175, 170);
                }                
            }

            if (e.Location.X >= 181 && e.Location.Y >= 300 && e.Location.X <= 216 && e.Location.Y <= 470)//насос
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 181, 300, 35, 170);
                }
            }
            if (e.Location.X >= 217 && e.Location.Y >= 300 && e.Location.X <= 257 && e.Location.Y <= 470)//весы
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 217, 300, 40, 170);
                }
            }
            if (e.Location.X >= 258 && e.Location.Y >= 300 && e.Location.X <= 353 && e.Location.Y <= 470)//охладитель
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 258, 300, 95, 170);
                }
            }
            if (e.Location.X >= 354 && e.Location.Y >= 300 && e.Location.X <= 524 && e.Location.Y <= 470)//резервуар
            {
                using (Graphics G = pictureBox1.CreateGraphics())
                {
                    G.DrawRectangle(Pens.Blue, 354, 300, 170, 170);
                }
            }

        }

        private void CloseDetails(object sender, FormClosingEventArgs e)
        {
            IsShowDetails = false;
        }
    }
}
