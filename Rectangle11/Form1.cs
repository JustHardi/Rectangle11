using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle11
{
    public partial class Form1 : Form
    {
        public bool IsShowDetails { get; set; } = false; //проверка открыто ли окно Form2 
        public bool WillRefreshed { get; set; } = false; //для указания мест обновления изображения
        List<Equipments> eq = new List<Equipments>();
        List<Product> prod = new List<Product>();        
        public bool IsShowMilk { get; set; } = false; //проверка показано ли изображение молока
        public bool IsShowKefir { get; set; } = false;
        public bool IsShowSmetana { get; set; } = false;
        public bool IsShowTvorog { get; set; } = false;
        public bool IsShowYogurt { get; set; } = false;


        public Form1()
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/milkavita.gif");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
                        
            hideSubMenu();
            prod = FileReader.GetProduct();
            this.ImagePanel.AutoScroll = true;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;            
        }
        

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 newForm = new Form2();
            pictureBox1.Refresh();
            panelSideMenu.Visible = false;
            pnlSlide.Visible = false;
            try
            {
                if (IsShowMilk == true)
                {
                    if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 180 && e.Location.Y <= 490) //x+30 машина
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[0]);
                            IsShowDetails = true;
                        }
                    }

                    if (e.Location.X >= 181 && e.Location.Y >= 270 && e.Location.X <= 216 && e.Location.Y <= 490)//1 насос
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[1]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 217 && e.Location.Y >= 270 && e.Location.X <= 257 && e.Location.Y <= 490)//2 весы
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[2]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 258 && e.Location.Y >= 270 && e.Location.X <= 353 && e.Location.Y <= 490)//3 охладитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[3]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 354 && e.Location.Y >= 270 && e.Location.X <= 524 && e.Location.Y <= 490)//4 резервуар
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[4]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 684 && e.Location.Y >= 270 && e.Location.X <= 874 && e.Location.Y <= 490)//6 пастеризационно=охладительная установка
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 875 && e.Location.Y >= 270 && e.Location.X <= 955 && e.Location.Y <= 490)//7 сепаратор-сливкоотделитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 956 && e.Location.Y >= 270 && e.Location.X <= 1071 && e.Location.Y <= 490)//8 нормализатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1072 && e.Location.Y >= 270 && e.Location.X <= 1221 && e.Location.Y <= 490)//9 гомогенизатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1222 && e.Location.Y >= 270 && e.Location.X <= 1351 && e.Location.Y <= 490)//10 сепаратор для удаления бактерий
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1352 && e.Location.Y >= 270 && e.Location.X <= 1481 && e.Location.Y <= 490)//11 деаэратор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1482 && e.Location.Y >= 270 && e.Location.X <= 1671 && e.Location.Y <= 490)//12 выдерживатель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1382 && e.Location.Y >= 510 && e.Location.X <= 1511 && e.Location.Y <= 750)//13 резервуар для пастеризованного молока
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[12]);
                            IsShowDetails = true;
                        }
                    }
                    if (e.Location.X >= 1512 && e.Location.Y >= 510 && e.Location.X <= 1701 && e.Location.Y <= 750)//14 фасовочный автомат
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[13]);
                            IsShowDetails = true;
                        }
                    }
                }
                
                if (IsShowKefir == true)
                {
                    if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 177 && e.Location.Y <= 490)//машина
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[0]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 183 && e.Location.Y >= 270 && e.Location.X <= 212 && e.Location.Y <= 490)//1 насос
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[1]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 217 && e.Location.Y >= 270 && e.Location.X <= 253 && e.Location.Y <= 490)//2 весы
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[2]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 258 && e.Location.Y >= 270 && e.Location.X <= 329 && e.Location.Y <= 490)//3 охладитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[3]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 334 && e.Location.Y >= 270 && e.Location.X <= 489 && e.Location.Y <= 490)//4 резервуар
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[4]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 634 && e.Location.Y >= 270 && e.Location.X <= 801 && e.Location.Y <= 490)//6 пастеризационно=охладительная установка
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 806 && e.Location.Y >= 270 && e.Location.X <= 907 && e.Location.Y <= 490)//7 сепаратор-сливкоотделитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 912 && e.Location.Y >= 270 && e.Location.X <= 980 && e.Location.Y <= 490)//8 нормализатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 985 && e.Location.Y >= 270 && e.Location.X <= 1096 && e.Location.Y <= 490)//9 гомогенизатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 1102 && e.Location.Y >= 270 && e.Location.X <= 1225 && e.Location.Y <= 490)//10 сепаратор для удаления бактерий
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 1230 && e.Location.Y >= 270 && e.Location.X <= 1376 && e.Location.Y <= 490)//11 деаэратор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 1381 && e.Location.Y >= 270 && e.Location.X <= 1484 && e.Location.Y <= 490)//12 выдерживатель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 1489 && e.Location.Y >= 270 && e.Location.X <= 1546 && e.Location.Y <= 490)//13 резервуар для пастеризованного молока
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[12]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X >= 1551 && e.Location.Y >= 270 && e.Location.X <= 1778 && e.Location.Y <= 490)//14 фасовочный автомат
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[13]);
                            IsShowDetails = true;
                        }
                    }
                }
                
                if (IsShowSmetana == true)
                {
                    if (e.Location.X > 5 && e.Location.Y > 270 && e.Location.X < 167 && e.Location.Y < 490)//машина
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[0]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 172 && e.Location.Y > 270 && e.Location.X < 205 && e.Location.Y < 490)//1 насос
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[1]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 210 && e.Location.Y > 270 && e.Location.X < 251 && e.Location.Y < 490)//2 весы
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[2]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 256 && e.Location.Y > 270 && e.Location.X < 329 && e.Location.Y < 490)//3 охладитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[3]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 334 && e.Location.Y > 270 && e.Location.X < 499 && e.Location.Y < 490)//4 резервуар
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[4]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 644 && e.Location.Y > 270 && e.Location.X < 822 && e.Location.Y < 490)//6 пастеризационно=охладительная установка
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 824 && e.Location.Y > 270 && e.Location.X < 918 && e.Location.Y < 490)//7 сепаратор-сливкоотделитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 920 && e.Location.Y > 270 && e.Location.X < 1001 && e.Location.Y < 490)//8 нормализатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1023 && e.Location.Y > 270 && e.Location.X < 1089 && e.Location.Y < 490)//9 гомогенизатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1091 && e.Location.Y > 270 && e.Location.X < 1192 && e.Location.Y < 490)//10 сепаратор для удаления бактерий
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1330 && e.Location.Y > 270 && e.Location.X < 1505 && e.Location.Y < 490)//11 деаэратор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1507 && e.Location.Y > 270 && e.Location.X < 1642 && e.Location.Y < 490)//12 выдерживатель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1650 && e.Location.Y > 270 && e.Location.X < 1830 && e.Location.Y < 490)//13 резервуар для пастеризованного молока
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[12]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1421 && e.Location.Y > 520 && e.Location.X < 1533 && e.Location.Y < 760)//14
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[13]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1535 && e.Location.Y > 520 && e.Location.X < 1613 && e.Location.Y < 760)//15
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[14]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1616 && e.Location.Y > 520 && e.Location.X < 1830 && e.Location.Y < 760)//16
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[15]);
                            IsShowDetails = true;
                        }
                    }
                }

                if (IsShowTvorog == true)
                {
                    if (e.Location.X > 5 && e.Location.Y > 270 && e.Location.X < 209 && e.Location.Y < 490)//машина
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[0]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 210 && e.Location.Y > 270 && e.Location.X < 249 && e.Location.Y < 490)//1 насос
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[1]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 251 && e.Location.Y > 270 && e.Location.X < 305 && e.Location.Y < 490)//2 весы
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[2]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 307 && e.Location.Y > 270 && e.Location.X < 391 && e.Location.Y < 490)//4 резервуар
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[3]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 405 && e.Location.Y > 270 && e.Location.X < 586 && e.Location.Y < 490)//5
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[4]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 770 && e.Location.Y > 270 && e.Location.X < 968 && e.Location.Y < 490)//6 пастеризационно=охладительная установка
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 970 && e.Location.Y > 270 && e.Location.X < 1104 && e.Location.Y < 490)//7 сепаратор-сливкоотделитель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1106 && e.Location.Y > 270 && e.Location.X < 1186 && e.Location.Y < 490)//8 нормализатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1188 && e.Location.Y > 270 && e.Location.X < 1319 && e.Location.Y < 490)//9 гомогенизатор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1321 && e.Location.Y > 270 && e.Location.X < 1501 && e.Location.Y < 490)//10 сепаратор для удаления бактерий
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1523 && e.Location.Y > 270 && e.Location.X < 1738 && e.Location.Y < 490)//11 деаэратор
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 160 && e.Location.Y > 520 && e.Location.X < 354 && e.Location.Y < 790)//12 выдерживатель
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 396 && e.Location.Y > 520 && e.Location.X < 510 && e.Location.Y < 790)//13 резервуар для пастеризованного молока
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[12]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 634 && e.Location.Y > 520 && e.Location.X < 822 && e.Location.Y < 790)//14
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[13]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 849 && e.Location.Y > 520 && e.Location.X < 944 && e.Location.Y < 790)//15
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[14]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 984 && e.Location.Y > 520 && e.Location.X < 1148 && e.Location.Y < 790)//16
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[15]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1210 && e.Location.Y > 520 && e.Location.X < 1366 && e.Location.Y < 790)//17
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[16]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1575 && e.Location.Y > 520 && e.Location.X < 1830 && e.Location.Y < 850)//18
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[17]);
                            IsShowDetails = true;
                        }
                    }

                }

                if (IsShowYogurt == true)
                {
                    if (e.Location.X > 210 && e.Location.Y > 220 && e.Location.X < 347 && e.Location.Y < 380)//0 машина
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[0]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 348 && e.Location.Y > 220 && e.Location.X < 377 && e.Location.Y < 380)//1 насос
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[1]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 378 && e.Location.Y > 220 && e.Location.X < 412 && e.Location.Y < 380)//2 весы 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[2]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 414 && e.Location.Y > 220 && e.Location.X < 482 && e.Location.Y < 380)//3 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[3]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 484 && e.Location.Y > 220 && e.Location.X < 624 && e.Location.Y < 380)//4 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[4]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 750 && e.Location.Y > 220 && e.Location.X < 894 && e.Location.Y < 380)//5 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 896 && e.Location.Y > 220 && e.Location.X < 989 && e.Location.Y < 380)//6 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 993 && e.Location.Y > 220 && e.Location.X < 1058 && e.Location.Y < 380)//7
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1059 && e.Location.Y > 220 && e.Location.X < 1151 && e.Location.Y < 380)//8  
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1153 && e.Location.Y > 220 && e.Location.X < 1265 && e.Location.Y < 380)//9  
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1267 && e.Location.Y > 220 && e.Location.X < 1379 && e.Location.Y < 380)//10 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1381 && e.Location.Y > 220 && e.Location.X < 1523 && e.Location.Y < 380)//11
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1525 && e.Location.Y > 220 && e.Location.X < 1617 && e.Location.Y < 380)//12 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[12]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 130 && e.Location.Y > 420 && e.Location.X < 285 && e.Location.Y < 600)//6 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[5]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 286 && e.Location.Y > 420 && e.Location.X < 378 && e.Location.Y < 600)//7 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[6]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 380 && e.Location.Y > 420 && e.Location.X < 442 && e.Location.Y < 600)//8
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[7]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 444 && e.Location.Y > 420 && e.Location.X < 536 && e.Location.Y < 600)//9 
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[8]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 538 && e.Location.Y > 420 && e.Location.X < 650 && e.Location.Y < 600)//10
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[9]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 652 && e.Location.Y > 420 && e.Location.X < 764 && e.Location.Y < 600)//11
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[10]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 766 && e.Location.Y > 420 && e.Location.X < 913 && e.Location.Y < 600)//12
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[11]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 935 && e.Location.Y > 420 && e.Location.X < 1020 && e.Location.Y < 600)//14
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[13]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1021 && e.Location.Y > 420 && e.Location.X < 1075 && e.Location.Y < 600)//15
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[14]);
                            IsShowDetails = true;
                        }
                    }
                    //else if (e.Location.X > 1077 && e.Location.Y > 420 && e.Location.X < 1137 && e.Location.Y < 600)//15
                    //{
                    //    G.DrawRectangle(myPen, 1077, 420, 60, 180);
                    //    WillRefreshed = true;
                    //}
                    else if (e.Location.X > 1139 && e.Location.Y > 420 && e.Location.X < 1260 && e.Location.Y < 600)//16
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[15]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1365 && e.Location.Y > 420 && e.Location.X < 1415 && e.Location.Y < 600)//17
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[16]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1505 && e.Location.Y > 420 && e.Location.X < 1590 && e.Location.Y < 600)//18
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[17]);
                            IsShowDetails = true;
                        }
                    }
                    else if (e.Location.X > 1660 && e.Location.Y > 420 && e.Location.X < 1745 && e.Location.Y < 600)//19
                    {
                        if (e.Button == MouseButtons.Left && IsShowDetails == false)
                        {
                            newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                            newForm.ShowEquipmentDetails(eq[18]);
                            IsShowDetails = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("В некотором файле оборудования не хватает данных для считывания", "Ошибка оборудования");
                return;
            }
        }
                
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen myPen = new Pen(Color.DeepSkyBlue, 2);
            
            using (Graphics G = pictureBox1.CreateGraphics()) // пикчер бокс служит полотном для рисования
            { 

                if (IsShowMilk == true)
                {
                
                    if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 177 && e.Location.Y <= 490)//машина
                    {
                        G.DrawRectangle(myPen, 5, 270, 174, 220);       
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 183 && e.Location.Y >= 270 && e.Location.X <= 214 && e.Location.Y <= 490)//1 насос
                    {                    
                        G.DrawRectangle(myPen, 181, 270, 35, 220);                        
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 221 && e.Location.Y >= 270 && e.Location.X <= 255 && e.Location.Y <= 490)//2 весы
                    {                    
                        G.DrawRectangle(myPen, 218, 270, 39, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 261 && e.Location.Y >= 270 && e.Location.X <= 351 && e.Location.Y <= 490)//3 охладитель
                    {
                        G.DrawRectangle(myPen, 259, 270, 94, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 357 && e.Location.Y >= 270 && e.Location.X <= 522 && e.Location.Y <= 490)//4 резервуар
                    {
                        G.DrawRectangle(myPen, 355, 270, 169, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 686 && e.Location.Y >= 270 && e.Location.X <= 871 && e.Location.Y <= 490)//6 пастеризационно=охладительная установка
                    {
                        G.DrawRectangle(myPen, 684, 270, 189, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 877 && e.Location.Y >= 270 && e.Location.X <= 953 && e.Location.Y <= 490)//7 сепаратор-сливкоотделитель
                    {
                        G.DrawRectangle(myPen, 875, 270, 80, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 959 && e.Location.Y >= 270 && e.Location.X <= 1069 && e.Location.Y <= 490)//8 нормализатор
                    {
                        G.DrawRectangle(myPen, 957, 270, 114, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1075 && e.Location.Y >= 270 && e.Location.X <= 1219 && e.Location.Y <= 490)//9 гомогенизатор
                    {
                        G.DrawRectangle(myPen, 1073, 270, 148, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1225 && e.Location.Y >= 270 && e.Location.X <= 1349 && e.Location.Y <= 490)//10 сепаратор для удаления бактерий
                    {
                        G.DrawRectangle(myPen, 1223, 270, 128, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1354 && e.Location.Y >= 270 && e.Location.X <= 1479 && e.Location.Y <= 490)//11 деаэратор
                    {
                        G.DrawRectangle(myPen, 1353, 270, 128, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1484 && e.Location.Y >= 270 && e.Location.X <= 1669 && e.Location.Y <= 490)//12 выдерживатель
                    {
                        G.DrawRectangle(myPen, 1483, 270, 188, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1384 && e.Location.Y >= 510 && e.Location.X <= 1509 && e.Location.Y <= 750)//13 резервуар для пастеризованного молока
                    {
                        G.DrawRectangle(myPen, 1383, 510, 128, 240);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1514 && e.Location.Y >= 510 && e.Location.X <= 1701 && e.Location.Y <= 750)//14 фасовочный автомат
                    {
                        G.DrawRectangle(myPen, 1513, 510, 188, 240);
                        WillRefreshed = true;
                    }
                    else { WillRefreshed = false; }
                    if(WillRefreshed == false) { pictureBox1.Refresh(); }
                }
                
                if (IsShowKefir == true)
                {
                    if (e.Location.X >= 5 && e.Location.Y >= 270 && e.Location.X <= 177 && e.Location.Y <= 490)//машина
                    {
                        G.DrawRectangle(myPen, 5, 270, 175, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 183 && e.Location.Y >= 270 && e.Location.X <= 212 && e.Location.Y <= 490)//1 насос
                    {
                        G.DrawRectangle(myPen, 181, 270, 33, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 217 && e.Location.Y >= 270 && e.Location.X <= 253 && e.Location.Y <= 490)//2 весы
                    {
                        G.DrawRectangle(myPen, 215, 270, 40, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 258 && e.Location.Y >= 270 && e.Location.X <= 329 && e.Location.Y <= 490)//3 охладитель
                    {
                        G.DrawRectangle(myPen, 256, 270, 75, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 334 && e.Location.Y >= 270 && e.Location.X <= 489 && e.Location.Y <= 490)//4 резервуар
                    {
                        G.DrawRectangle(myPen, 332, 270, 159, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 634 && e.Location.Y >= 270 && e.Location.X <= 801 && e.Location.Y <= 490)//6 пастеризационно=охладительная установка
                    {
                        G.DrawRectangle(myPen, 634, 270, 169, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 806 && e.Location.Y >= 270 && e.Location.X <= 907 && e.Location.Y <= 490)//7 сепаратор-сливкоотделитель
                    {
                        G.DrawRectangle(myPen, 804, 270, 105, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 912 && e.Location.Y >= 270 && e.Location.X <= 980 && e.Location.Y <= 490)//8 нормализатор
                    {
                        G.DrawRectangle(myPen, 910, 270, 72, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 985 && e.Location.Y >= 270 && e.Location.X <= 1096 && e.Location.Y <= 490)//9 гомогенизатор
                    {
                        G.DrawRectangle(myPen, 984, 270, 114, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1102 && e.Location.Y >= 270 && e.Location.X <= 1225 && e.Location.Y <= 490)//10 сепаратор для удаления бактерий
                    {
                        G.DrawRectangle(myPen, 1100, 270, 128, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1230 && e.Location.Y >= 270 && e.Location.X <= 1376 && e.Location.Y <= 490)//11 деаэратор
                    {
                        G.DrawRectangle(myPen, 1228, 270, 151, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1381 && e.Location.Y >= 270 && e.Location.X <= 1484 && e.Location.Y <= 490)//12 выдерживатель
                    {
                        G.DrawRectangle(myPen, 1380, 270, 106, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1489 && e.Location.Y >= 270 && e.Location.X <= 1546 && e.Location.Y <= 490)//13 резервуар для пастеризованного молока
                    {
                        G.DrawRectangle(myPen, 1487, 270, 61, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X >= 1551 && e.Location.Y >= 270 && e.Location.X <= 1778 && e.Location.Y <= 490)//14 фасовочный автомат
                    {
                        G.DrawRectangle(myPen, 1549, 270, 229, 220);
                        WillRefreshed = true;
                    }
                    else { WillRefreshed = false; }
                    if (WillRefreshed == false) { pictureBox1.Refresh(); }
                }

                if (IsShowSmetana == true)
                {
                    if (e.Location.X > 5 && e.Location.Y > 270 && e.Location.X < 167 && e.Location.Y < 490)//машина
                    {
                        G.DrawRectangle(myPen, 5, 270, 165, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 172 && e.Location.Y > 270 && e.Location.X < 205 && e.Location.Y < 490)//1 насос
                    {
                        G.DrawRectangle(myPen, 170, 270, 35, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 210 && e.Location.Y > 270 && e.Location.X < 251 && e.Location.Y < 490)//2 весы
                    {
                        G.DrawRectangle(myPen, 207, 270, 40, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 256 && e.Location.Y > 270 && e.Location.X < 329 && e.Location.Y < 490)//3 охладитель
                    {
                        G.DrawRectangle(myPen, 249, 270, 79, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 334 && e.Location.Y > 270 && e.Location.X < 499 && e.Location.Y < 490)//4 резервуар
                    {
                        G.DrawRectangle(myPen, 332, 270, 169, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 644 && e.Location.Y > 270 && e.Location.X < 822 && e.Location.Y < 490)//6 пастеризационно=охладительная установка
                    {
                        G.DrawRectangle(myPen, 644, 270, 179, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 824 && e.Location.Y > 270 && e.Location.X < 918 && e.Location.Y < 490)//7 сепаратор-сливкоотделитель
                    {
                        G.DrawRectangle(myPen, 824, 270, 95, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 920 && e.Location.Y > 270 && e.Location.X < 1001 && e.Location.Y < 490)//8 нормализатор
                    {
                        G.DrawRectangle(myPen, 920, 270, 82, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1023 && e.Location.Y > 270 && e.Location.X < 1089 && e.Location.Y < 490)//9 гомогенизатор
                    {
                        G.DrawRectangle(myPen, 1023, 270, 67, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1091 && e.Location.Y > 270 && e.Location.X < 1192 && e.Location.Y < 490)//10 сепаратор для удаления бактерий
                    {
                        G.DrawRectangle(myPen, 1091, 270, 102, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1330 && e.Location.Y > 270 && e.Location.X < 1505 && e.Location.Y < 490)//11 деаэратор
                    {
                        G.DrawRectangle(myPen, 1330, 270, 176, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1507 && e.Location.Y > 270 && e.Location.X < 1642 && e.Location.Y < 490)//12 выдерживатель
                    {
                        G.DrawRectangle(myPen, 1507, 270, 136, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1650 && e.Location.Y > 270 && e.Location.X < 1830 && e.Location.Y < 490)//13 резервуар для пастеризованного молока
                    {
                        G.DrawRectangle(myPen, 1650, 270, 181, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1421 && e.Location.Y > 520 && e.Location.X < 1533 && e.Location.Y < 760)//14 
                    {
                        G.DrawRectangle(myPen, 1419, 520, 115, 240);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1535 && e.Location.Y > 520 && e.Location.X < 1613 && e.Location.Y < 760)//15 
                    {
                        G.DrawRectangle(myPen, 1534, 520, 80, 240);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1616 && e.Location.Y > 520 && e.Location.X < 1830 && e.Location.Y < 760)//16 
                    {
                        G.DrawRectangle(myPen, 1615, 520, 215, 240);
                        WillRefreshed = true;
                    }
                    else { WillRefreshed = false; }
                    if (WillRefreshed == false) { pictureBox1.Refresh(); }
                }

                if (IsShowTvorog == true)
                {
                    if (e.Location.X > 5 && e.Location.Y > 270 && e.Location.X < 209 && e.Location.Y < 490)//машина
                    {
                        G.DrawRectangle(myPen, 5, 270, 205, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 210 && e.Location.Y > 270 && e.Location.X < 249 && e.Location.Y < 490)//2 весы
                    {
                        G.DrawRectangle(myPen, 210, 270, 40, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 251 && e.Location.Y > 270 && e.Location.X < 305 && e.Location.Y < 490)//3 охладитель
                    {
                        G.DrawRectangle(myPen, 251, 270, 54, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 307 && e.Location.Y > 270 && e.Location.X < 391 && e.Location.Y < 490)//4 резервуар
                    {
                        G.DrawRectangle(myPen, 307, 270, 85, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 405 && e.Location.Y > 270 && e.Location.X < 586 && e.Location.Y < 490)//5 резервуар
                    {
                        G.DrawRectangle(myPen, 405, 270, 182, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 770 && e.Location.Y > 270 && e.Location.X < 968 && e.Location.Y < 490)//6 пастеризационно=охладительная установка
                    {
                        G.DrawRectangle(myPen, 770, 270, 199, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 970 && e.Location.Y > 270 && e.Location.X < 1104 && e.Location.Y < 490)//7 сепаратор-сливкоотделитель
                    {
                        G.DrawRectangle(myPen, 970, 270, 135, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1106 && e.Location.Y > 270 && e.Location.X < 1186 && e.Location.Y < 490)//8 нормализатор
                    {
                        G.DrawRectangle(myPen, 1105, 270, 82, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1188 && e.Location.Y > 270 && e.Location.X < 1319 && e.Location.Y < 490)//9 гомогенизатор
                    {
                        G.DrawRectangle(myPen, 1187, 270, 133, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1321 && e.Location.Y > 270 && e.Location.X < 1501 && e.Location.Y < 490)//10 сепаратор для удаления бактерий
                    {
                        G.DrawRectangle(myPen, 1320, 270, 182, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1523 && e.Location.Y > 270 && e.Location.X < 1738 && e.Location.Y < 490)//11 деаэратор
                    {
                        G.DrawRectangle(myPen, 1522, 270, 215, 220);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 160 && e.Location.Y > 520 && e.Location.X < 354 && e.Location.Y < 790)//12 насос
                    {
                        G.DrawRectangle(myPen, 160, 520, 195, 270);
                        WillRefreshed = true;
                    }
                    
                    else if (e.Location.X > 396 && e.Location.Y > 520 && e.Location.X < 510 && e.Location.Y < 790)//13 резервуар
                    {
                        G.DrawRectangle(myPen, 395, 520, 115, 270);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 634 && e.Location.Y > 520 && e.Location.X < 822 && e.Location.Y < 790)//14 пастеризационно=охладительная установка
                    {
                        G.DrawRectangle(myPen, 634, 520, 189, 270);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 849 && e.Location.Y > 520 && e.Location.X < 944 && e.Location.Y < 790)//15 сепаратор-сливкоотделитель
                    {
                        G.DrawRectangle(myPen, 849, 520, 95, 270);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 984 && e.Location.Y > 520 && e.Location.X < 1148 && e.Location.Y < 790)//16 выдерживатель
                    {
                        G.DrawRectangle(myPen, 984, 520, 164, 270);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1210 && e.Location.Y > 520 && e.Location.X < 1366 && e.Location.Y < 790)//17 резервуар для пастеризованного молока
                    {
                        G.DrawRectangle(myPen, 1210, 520, 156, 270);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1575 && e.Location.Y > 520 && e.Location.X < 1830 && e.Location.Y < 850)//18 
                    {
                        G.DrawRectangle(myPen, 1575, 520, 165, 330);
                        WillRefreshed = true;
                    }
                    else { WillRefreshed = false; }
                    if (WillRefreshed == false) { pictureBox1.Refresh(); }
                }

                if (IsShowYogurt == true)
                {
                    if (e.Location.X > 210 && e.Location.Y > 220 && e.Location.X < 347 && e.Location.Y < 380)//0 машина
                    {
                        G.DrawRectangle(myPen, 210, 220, 137, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 348 && e.Location.Y > 220 && e.Location.X < 377 && e.Location.Y < 380)//1 насос
                    {
                        G.DrawRectangle(myPen, 348, 220, 29, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 378 && e.Location.Y > 220 && e.Location.X < 412 && e.Location.Y < 380)//2 весы
                    {
                        G.DrawRectangle(myPen, 378, 220, 35, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 414 && e.Location.Y > 220 && e.Location.X < 482 && e.Location.Y < 380)//3 
                    {
                        G.DrawRectangle(myPen, 413, 220, 69, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 484 && e.Location.Y > 220 && e.Location.X < 624 && e.Location.Y < 380)//4 
                    {
                        G.DrawRectangle(myPen, 483, 220, 140, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 750 && e.Location.Y > 220 && e.Location.X < 894 && e.Location.Y < 380)//5 
                    {
                        G.DrawRectangle(myPen, 750, 220, 145, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 896 && e.Location.Y > 220 && e.Location.X < 989 && e.Location.Y < 380)//6 
                    {
                        G.DrawRectangle(myPen, 895, 220, 95, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 993 && e.Location.Y > 220 && e.Location.X < 1058 && e.Location.Y < 380)//7 
                    {
                        G.DrawRectangle(myPen, 993, 220, 65, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1059 && e.Location.Y > 220 && e.Location.X < 1151 && e.Location.Y < 380)//8 
                    {
                        G.DrawRectangle(myPen, 1059, 220, 92, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1153 && e.Location.Y > 220 && e.Location.X < 1265 && e.Location.Y < 380)//9
                    {
                        G.DrawRectangle(myPen, 1153, 220, 112, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1267 && e.Location.Y > 220 && e.Location.X < 1379 && e.Location.Y < 380)//10
                    {
                        G.DrawRectangle(myPen, 1267, 220, 112, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1381 && e.Location.Y > 220 && e.Location.X < 1523 && e.Location.Y < 380)//11
                    {
                        G.DrawRectangle(myPen, 1381, 220, 142, 160);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1525 && e.Location.Y > 220 && e.Location.X < 1617 && e.Location.Y < 380)//12
                    {
                        G.DrawRectangle(myPen, 1525, 220, 92, 160);
                        WillRefreshed = true;
                    }
                    
                    else if (e.Location.X > 130 && e.Location.Y > 420 && e.Location.X < 285 && e.Location.Y < 600)//6 
                    {
                        G.DrawRectangle(myPen, 130, 420, 155, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 286 && e.Location.Y > 420 && e.Location.X < 378 && e.Location.Y < 600)//7 
                    {
                        G.DrawRectangle(myPen, 286, 420, 92, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 380 && e.Location.Y > 420 && e.Location.X < 442 && e.Location.Y < 600)//8 
                    {
                        G.DrawRectangle(myPen, 380, 420, 62, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 444 && e.Location.Y > 420 && e.Location.X < 536 && e.Location.Y < 600)//9 
                    {
                        G.DrawRectangle(myPen, 444, 420, 92, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 538 && e.Location.Y > 420 && e.Location.X < 650 && e.Location.Y < 600)//10
                    {
                        G.DrawRectangle(myPen, 538, 420, 112, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 652 && e.Location.Y > 420 && e.Location.X < 764 && e.Location.Y < 600)//11
                    {
                        G.DrawRectangle(myPen, 652, 420, 112, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 766 && e.Location.Y > 420 && e.Location.X < 913 && e.Location.Y < 600)//12
                    {
                        G.DrawRectangle(myPen, 766, 420, 147, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 935 && e.Location.Y > 420 && e.Location.X < 1020 && e.Location.Y < 600)//14
                    {
                        G.DrawRectangle(myPen, 935, 420, 85, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1021 && e.Location.Y > 420 && e.Location.X < 1075 && e.Location.Y < 600)//15
                    {
                        G.DrawRectangle(myPen, 1021, 420, 55, 180);
                        WillRefreshed = true;
                    }
                    //else if (e.Location.X > 1077 && e.Location.Y > 420 && e.Location.X < 1137 && e.Location.Y < 600)//15
                    //{
                    //    G.DrawRectangle(myPen, 1077, 420, 60, 180);
                    //    WillRefreshed = true;
                    //}
                    else if (e.Location.X > 1139 && e.Location.Y > 420 && e.Location.X < 1260 && e.Location.Y < 600)//16
                    {
                        G.DrawRectangle(myPen, 1139, 420, 120, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1365 && e.Location.Y > 420 && e.Location.X < 1415 && e.Location.Y < 600)//17
                    {
                        G.DrawRectangle(myPen, 1365, 420, 50, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1505 && e.Location.Y > 420 && e.Location.X < 1590 && e.Location.Y < 600)//18
                    {
                        G.DrawRectangle(myPen, 1505, 420, 85, 180);
                        WillRefreshed = true;
                    }
                    else if (e.Location.X > 1660 && e.Location.Y > 420 && e.Location.X < 1745 && e.Location.Y < 600)//19
                    {
                        G.DrawRectangle(myPen, 1660, 420, 85, 180);
                        WillRefreshed = true;
                    }


                    else { WillRefreshed = false; }
                    if (WillRefreshed == false) { pictureBox1.Refresh(); }
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

        #region SubMenu
        
        private void hideSubMenu()
        {
            panelMilkSubMenu.Visible = false;
            panelKefirSubMenu.Visible = false;
            panelSmetanaSubMenu.Visible = false;
            panelTvorogSubMenu.Visible = false;
            panelYogurtSubMenu.Visible = false;
            panelSideMenu.Visible = false; //панель основного меню
            pnlSlide.Visible = false; //панель жирности продуктов

            //отписка от события click для вывода затрат на производство тонны продуктов
            //для молока
            btn1.Click -= new EventHandler(btnM1_Click);
            btn2.Click -= new EventHandler(btnM2_Click);
            //для кефира
            btn1.Click -= new EventHandler(btnK1_Click);
            btn2.Click -= new EventHandler(btnK2_Click);
            //для сметаны
            btn1.Click -= new EventHandler(btnS1_Click);
            btn2.Click -= new EventHandler(btnS2_Click);
            //для творога
            btn1.Click -= new EventHandler(btnT1_Click);
            //btn2.Click -= new EventHandler(btnK2_Click);
            //для йогурта
            btn1.Click -= new EventHandler(btnY1_Click);
            btn2.Click -= new EventHandler(btnY2_Click);
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                panelSideMenu.Visible = true;
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                pnlSlide.Visible = false;
            }
        }

        private void buttonMilk_Click(object sender, EventArgs e)//молоко
        {
            showSubMenu(panelMilkSubMenu);
        }

        private void buttonKefir_Click(object sender, EventArgs e)//кефир
        {
            showSubMenu(panelKefirSubMenu);
        }

        private void buttonSmetana_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSmetanaSubMenu);
        }

        private void buttonTvorog_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTvorogSubMenu);
        }

        private void buttonYogurt_Click(object sender, EventArgs e)
        {
            showSubMenu(panelYogurtSubMenu);
        }
        #endregion

        private void ImagePanel_Resize(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                Size picSize = this.pictureBox1.Image.Size;
                Size panSize = this.panelKefirSubMenu.Size;
                if (picSize.Height < panSize.Height)
                {
                    this.pictureBox1.Location = new Point(this.pictureBox1.Location.X, (panSize.Height - picSize.Height) / 2);
                }
                else
                {
                    this.pictureBox1.Location = new Point(this.pictureBox1.Location.X, 0);
                }
                if (picSize.Width < panSize.Width)
                {
                    this.pictureBox1.Location = new Point((panSize.Width - picSize.Width) / 2, this.pictureBox1.Location.Y);
                }
                else
                {
                    this.pictureBox1.Location = new Point(0, this.pictureBox1.Location.Y);
                }
            }
        }

        
        private void buttonMilkScheme_Click(object sender, EventArgs e) //Схема производства молока
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/milk.png");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
            Helper.pathFile = @"../../Xmls/milk_equipments.xml";
            eq = FileReader.GetEquipments();
            IsShowMilk = true;
            IsShowKefir = false;
            IsShowSmetana = false;
            IsShowTvorog = false;
            IsShowYogurt = false;

            hideSubMenu();
        }

        private void buttonKefirScheme_Click(object sender, EventArgs e)//Схема кефира
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }            
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/kefir.png");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
            Helper.pathFile = @"../../Xmls/kefir_equipments.xml";
            eq = FileReader.GetEquipments();
            IsShowMilk = false;
            IsShowKefir = true;
            IsShowSmetana = false;
            IsShowTvorog = false;
            IsShowYogurt = false;


            hideSubMenu();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible == false)
            {
                panelSideMenu.Visible = true;
                
            }
            else
            {
                panelSideMenu.Visible = false;
                pnlSlide.Visible = false;
            }
        }

        private void buttonSmetanaScheme_Click(object sender, EventArgs e)
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }            
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/smetana.png");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
            Helper.pathFile = @"../../Xmls/smetana_equipments.xml";
            eq = FileReader.GetEquipments();
            IsShowMilk = false;
            IsShowKefir = false;
            IsShowSmetana = true;
            IsShowTvorog = false;
            IsShowYogurt = false;

            hideSubMenu();
        }


        #region Жирность продуктов
        private void movepanel(Control btn) //движущаяся панель
        {
            //задаем размеры и положение панели
            pnlSlide.Top = btn.Top + 15;
            pnlSlide.Width = btn.Width / 2;
            pnlSlide.Left = btn.Right;  
        }

        private void buttonMilkCosts_Click(object sender, EventArgs e)//включение панели вывода жирности для молока
        {
            pnlSlide.Visible = true;
            movepanel(panelMilkSubMenu);                       
            btn1.Text = "" + prod[0].Fat; //жирность продуктов
            btn2.Text = "" + prod[1].Fat;
            btn1.Click += new EventHandler(btnM1_Click);
            btn2.Click += new EventHandler(btnM2_Click);            
        }

        private void buttonKefirCosts_Click(object sender, EventArgs e) //включение панели вывода жирности для кефира
        {
            pnlSlide.Visible = true;
            movepanel(panelKefirSubMenu);            
            btn1.Text = "" + prod[2].Fat;
            btn2.Text = "" + prod[3].Fat;
            btn1.Click += new EventHandler(btnK1_Click);
            btn2.Click += new EventHandler(btnK2_Click);
        }

        private void buttonSmetanaCosts_Click(object sender, EventArgs e) //включение панели вывода жирности для сметаны
        {
            pnlSlide.Visible = true;
            movepanel(panelSmetanaSubMenu);            
            btn1.Text = "" + prod[4].Fat;
            btn2.Text = "" + prod[5].Fat;
            btn1.Click += new EventHandler(btnS1_Click);
            btn2.Click += new EventHandler(btnS2_Click);
        }

        private void buttonTvorogCosts_Click(object sender, EventArgs e) //включение панели вывода жирности для творога
        {
            pnlSlide.Visible = true;
            movepanel(panelTvorogSubMenu);
            btn1.Text = "" + prod[6].Fat;
            btn2.Text = "";
            btn1.Click += new EventHandler(btnT1_Click);
        }

        private void buttonYogurtCosts_Click(object sender, EventArgs e) //включение панели вывода жирности для йогурта
        {
            pnlSlide.Visible = true;
            movepanel(panelYogurtSubMenu);
            btn1.Text = "" + prod[7].Fat;
            btn2.Text = "" + prod[8].Fat;
            btn1.Click += new EventHandler(btnY1_Click);
            btn2.Click += new EventHandler(btnY2_Click);
        }

        private void buttonMilkEquipments_Click(object sender, EventArgs e) //вывод всего оборудования для производства молока по кнопке
        {
            if (IsShowDetails == false)
            {
                Helper.pathFile = @"../../Xmls/milk_equipments.xml";
                eq = FileReader.GetEquipments();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                for (int i = 0; i < eq.Count; i++)
                {
                    newForm.ShowEquipmentDetails(eq[i]);
                }
                IsShowDetails = true;
            }

            hideSubMenu();
        }

        private void buttonKefirEquipments_Click(object sender, EventArgs e) //вывод всего оборудования для производства кефира по кнопке
        {
            if (IsShowDetails == false)
            {
                Helper.pathFile = @"../../Xmls/kefir_equipments.xml";
                eq = FileReader.GetEquipments();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                for (int i = 0; i < eq.Count; i++)
                {
                    newForm.ShowEquipmentDetails(eq[i]);
                }
                IsShowDetails = true;
            }

            hideSubMenu();
        }

        private void btnM1_Click(object sender, EventArgs e) //вывод молока для одной жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[0]);

                IsShowDetails = true;
            }
        }
        private void btnM2_Click(object sender, EventArgs e) //вывод молока для другой жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[1]);

                IsShowDetails = true;
            }
        }
        private void btnK1_Click(object sender, EventArgs e) //вывод кефира для одной жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[2]);

                IsShowDetails = true;
            }
        }

        private void btnK2_Click(object sender, EventArgs e) //вывод кефира для другой жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[3]);

                IsShowDetails = true;
            }
        }

        private void btnS1_Click(object sender, EventArgs e) //вывод сметаны для одной жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[4]);

                IsShowDetails = true;
            }
        }

        private void btnS2_Click(object sender, EventArgs e) //вывод сметаны для другой жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[5]);

                IsShowDetails = true;
            }
        }

        private void btnT1_Click(object sender, EventArgs e) //вывод творога для одной жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[6]);

                IsShowDetails = true;
            }
        }

        private void btnY1_Click(object sender, EventArgs e) //вывод йогурта для одной жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[7]);

                IsShowDetails = true;
            }
        }

        private void btnY2_Click(object sender, EventArgs e) //вывод йогурта для другой жирности
        {
            if (IsShowDetails == false)
            {
                prod = FileReader.GetProduct();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);

                newForm.ShowPoductDetails(prod[8]);

                IsShowDetails = true;
            }
        }

        #endregion





        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ImagePanel.Controls.Add(childForm);
            ImagePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormCalculate());
        }

        private void buttonTvorogScheme_Click(object sender, EventArgs e)
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }            
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/tvorog.png");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
            Helper.pathFile = @"../../Xmls/tvorog_equipments.xml";
            eq = FileReader.GetEquipments();
            IsShowMilk = false;
            IsShowKefir = false;
            IsShowSmetana = false;
            IsShowYogurt = false;
            IsShowTvorog = true;

            hideSubMenu();
        }

        private void buttonYogurtScheme_Click(object sender, EventArgs e)
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }            
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/yogurt.png");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }
            Helper.pathFile = @"../../Xmls/yogurt_equipments.xml";
            eq = FileReader.GetEquipments();
            IsShowMilk = false;
            IsShowKefir = false;
            IsShowSmetana = false;
            IsShowTvorog = false;
            IsShowYogurt = true;

            hideSubMenu();
        }

        private void buttonSmetanaEquipments_Click(object sender, EventArgs e)
        {
            if (IsShowDetails == false)
            {
                Helper.pathFile = @"../../Xmls/smetana_equipments.xml";
                eq = FileReader.GetEquipments();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                for (int i = 0; i < eq.Count; i++)
                {
                    newForm.ShowEquipmentDetails(eq[i]);
                }
                IsShowDetails = true;
            }

            hideSubMenu();
        }

        private void buttonTvorogEquipments_Click(object sender, EventArgs e)
        {
            if (IsShowDetails == false)
            {
                Helper.pathFile = @"../../Xmls/tvorog_equipments.xml";
                eq = FileReader.GetEquipments();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                for (int i = 0; i < eq.Count; i++)
                {
                    newForm.ShowEquipmentDetails(eq[i]);
                }
                IsShowDetails = true;
            }

            hideSubMenu();
        }

        private void buttonYogurtEquipments_Click(object sender, EventArgs e)
        {
            if (IsShowDetails == false)
            {
                Helper.pathFile = @"../../Xmls/yogurt_equipments.xml";
                eq = FileReader.GetEquipments();
                Form2 newForm = new Form2();
                newForm.FormClosing += new FormClosingEventHandler(CloseDetails);
                for (int i = 0; i < eq.Count; i++)
                {
                    newForm.ShowEquipmentDetails(eq[i]);
                }
                IsShowDetails = true;
            }

            hideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm is FormCalculate)
            { activeForm.Close(); }
            IsShowMilk  = false; //проверка показано ли изображение молока
             IsShowKefir  = false;
             IsShowSmetana  = false;
             IsShowTvorog  = false;
             IsShowYogurt  = false;
            try
            {
                pictureBox1.Image = Image.FromFile(@"../../Images/milkavita.gif");
            }
            catch { pictureBox1.Image = Image.FromFile(@"../../Images/notfound.png"); }

            
        }
    }
}
