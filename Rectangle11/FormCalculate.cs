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
    public partial class FormCalculate : Form
    {
        List<Equipments> eq = new List<Equipments>();
        List<Product> prod = new List<Product>();
        
        public virtual double W { get; set; } = 0;


        public FormCalculate()
        {
            InitializeComponent();
            
            prod = FileReader.GetProduct();

            comboBoxProducts.Width = 100; //ширина для comboBoxProducts
            comboBoxProducts.Items.Add("Молоко");
            comboBoxProducts.Items.Add("Кефир");
            comboBoxProducts.Items.Add("Сметана");
            comboBoxProducts.Items.Add("Творог");
            comboBoxProducts.Items.Add("Йогурт");
            comboBoxProducts.SelectedIndex = 0; //по умолчанию выбрано "Молоко"
            comboBoxEquipments.Width = 50;

            label1text.Text = ("Удельный расход электроэнергии на производство продукции на рабочих машинах," +
                " аппаратах, установках непрерывного действия с равномерной нагрузкой определяется по формуле: \n ");
            label3text.Text = ("Расход электроэнергии для периодически работающего оборудования(мешалки в ваннах, танках):");
            label5text.Text = ("Расход электроэнергии на мойку технологического оборудования и трубопроводов:");
            label2text.Text = (" где Рн - номинальная мощность электродвигателя оборудования, кВт; " +
                "\n       Ки - коэффициент использования мощности электродвигателей;" +
                "\n       М - производительность оборудования по обрабатываемому сырью или готовому продукту, т/ч; " +
                "\n       а - расход сырья перерабатываемого на данном оборудовании, на одну тонну готовой продукции, т/т" +
                " (если производительность дана по готовому продукту, а = 1).");
            label4text.Text = (" m - масса продукта обрабатываемого за один цикл, т: " +
                "\n m = V • p , т, " +
                "\n где V - рабочий объем танка или емкости, м³; " +
                "\n       p - плотность продукта, т/м³; " +
                "\n       τ - время работы двигателя при осуществлении технологической операции;");                
            label6text.Text = (" где Mi - производительность i-го насоса, т/ч; " +
                "\n       0,6 - расход воды на мойку технологического оборудования, т.");
                

            richTextBox1.Text = (" Удельный расход электроэнергии на производство продукции на рабочих машинах," +
                "\n аппаратах, установках непрерывного действия с равномерной нагрузкой \n W = (Pн • Ки / M) • a" +
                " кВт*ч/т \nСделайте выбор в меню слева и нажмите кнопку \"Посчитать\". " );
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEquipments.Items.Clear();
            comboBoxEquipments.Text = "";            
            
            if (comboBoxProducts.SelectedIndex == 0) //если в comboBoxProducts выбрано "Молоко", тогда добавляем в comboBoxEquipments следующие значения жирности
            {                
                comboBoxEquipments.Items.Insert(0, ""+ prod[0].Fat );
                comboBoxEquipments.Items.Insert(1, ""+ prod[1].Fat);
                Helper.pathFile = @"../../Xmls/milk_equipments.xml";
                
            }
            if (comboBoxProducts.SelectedIndex == 1) //если в comboBoxProducts выбрано "Кефир", тогда добавляем в comboBoxEquipments следующие значения жирности
            {
                comboBoxEquipments.Items.Insert(0, "" + prod[2].Fat);
                comboBoxEquipments.Items.Insert(1, "" + prod[3].Fat);
                Helper.pathFile = @"../../Xmls/kefir_equipments.xml";
                
            }
            if (comboBoxProducts.SelectedIndex == 2) //если в comboBoxProducts выбрано "Сметана", тогда добавляем в comboBoxEquipments следующие значения жирности
            {
                comboBoxEquipments.Items.Insert(0, "" + prod[4].Fat);
                comboBoxEquipments.Items.Insert(1, "" + prod[5].Fat);
                Helper.pathFile = @"../../Xmls/smetana_equipments.xml";
                
            }
            if (comboBoxProducts.SelectedIndex == 3) //если в comboBoxProducts выбрано "Творог", тогда добавляем в comboBoxEquipments следующие значения жирности
            {
                comboBoxEquipments.Items.Insert(0, "" + prod[6].Fat);
                //comboBoxEquipments.Items.Insert(1, "" );
                Helper.pathFile = @"../../Xmls/tvorog_equipments.xml";
            }
            if (comboBoxProducts.SelectedIndex == 4) //если в comboBoxProducts выбрано "Йогурт", тогда добавляем в comboBoxEquipments следующие значения жирности
            {
                comboBoxEquipments.Items.Insert(0, "" + prod[7].Fat);
                comboBoxEquipments.Items.Insert(1, "" + prod[8].Fat);
                Helper.pathFile = @"../../Xmls/yogurt_equipments.xml";
            }

            comboBoxEquipments.SelectedIndex = 0;
        }
        
        
        private void btnResult_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            eq = FileReader.GetEquipments();
            if (comboBoxProducts.SelectedIndex == 0 && comboBoxEquipments.SelectedIndex == 0) //молоко
            {
                ShowDetails(0);
            }
            if (comboBoxProducts.SelectedIndex == 0 && comboBoxEquipments.SelectedIndex == 1)
            {
                ShowDetails(1);
            }

            if (comboBoxProducts.SelectedIndex == 1 && comboBoxEquipments.SelectedIndex == 0) //кефир
            {
                ShowDetails(2);
            }
            if (comboBoxProducts.SelectedIndex == 1 && comboBoxEquipments.SelectedIndex == 1)
            {
                ShowDetails(3);
            }

            if (comboBoxProducts.SelectedIndex == 2 && comboBoxEquipments.SelectedIndex == 0) //сметана
            {
                ShowDetails(4);
            }
            if (comboBoxProducts.SelectedIndex == 2 && comboBoxEquipments.SelectedIndex == 1)
            {
                ShowDetails(5);
            }

            if (comboBoxProducts.SelectedIndex == 3 && comboBoxEquipments.SelectedIndex == 0) //творог
            {
                ShowDetails(6);
            }

            if (comboBoxProducts.SelectedIndex == 4 && comboBoxEquipments.SelectedIndex == 0) //йогурт
            {
                ShowDetails(7);
            }
            if (comboBoxProducts.SelectedIndex == 4 && comboBoxEquipments.SelectedIndex == 1)
            {
                ShowDetails(8);
            }
            

        }

        public double GetUdRash(int i, int pr)
        {            
            if (eq[i].W > 0 && eq[i].a >= 0 && eq[i].W < 4 && eq[i].a < 4)
            {
                if (eq[i].Power >= 0 && eq[i].Coeff >= 0 && eq[i].Performance >= 0)
                {
                    if (prod[pr].MilkBaseValue >= 0 && prod[pr].MilkNofatValue >=0 && prod[pr].NormalizedMixture >=0) 
                    {
                        if (prod[pr].MilkBaseValue == 0)
                        {
                            prod[pr].MilkBaseValue = 1000;
                        }
                        else
                        if (prod[pr].MilkNofatValue == 0)
                        {
                            prod[pr].MilkNofatValue = 1000;
                        }
                        else
                        if (prod[pr].NormalizedMixture == 0)
                        {
                            prod[pr].NormalizedMixture = 1000;
                        }

                        if (eq[i].W == 1)
                        {
                            this.richTextBox1.Text += eq[i].Type != null ? eq[i].Type.ToString() + " " : "Hello";
                            if (eq[i].a == 0)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) , 4);
                            }                            
                            if (eq[i].a == 1)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * (prod[pr].MilkBaseValue / 1000), 4);
                            }
                            if (eq[i].a == 2)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * (prod[pr].MilkNofatValue / 1000), 4);
                            }
                            if (eq[i].a == 3)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * (prod[pr].NormalizedMixture / 1000), 4);
                            }
                        }
                        else
                    if (eq[i].W == 2)
                        {
                            this.richTextBox1.Text += eq[i].Type != null ? eq[i].Type.ToString() + " " : "Hello";
                            if (eq[i].Volume > 0)
                            {
                                if (eq[i].a == 0)
                                {
                                    W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) , 4);
                                }
                                else
                                if (eq[i].a == 1 && prod[pr].Plotn != 0)
                                {
                                    W = Math.Round(((eq[i].Power * eq[i].Coeff) / (eq[i].Volume * prod[pr].Plotn)) * (prod[pr].MilkBaseValue / 1000), 4);
                                }
                                else
                                if (eq[i].a == 2 && prod[pr].Plotn != 0)
                                {
                                    W = Math.Round(((eq[i].Power * eq[i].Coeff) / (eq[i].Volume * prod[pr].Plotn)) * (prod[pr].MilkNofatValue / 1000), 4);
                                }
                                else
                                if (eq[i].a == 3 && prod[pr].Plotn != 0)
                                {
                                    W = Math.Round(((eq[i].Power * eq[i].Coeff) / (eq[i].Volume * prod[pr].Plotn)) * (prod[pr].NormalizedMixture / 1000), 4);
                                }
                            }
                            else { MessageBox.Show("В оборудовании \"" + eq[i].Type.ToString() + "\" нет Volume для подсчета", "Ошибка"); }
                        }
                        else
                    if (eq[i].W == 3)
                        {
                            this.richTextBox1.Text += eq[i].Type != null ? eq[i].Type.ToString() + " " : "Hello";
                            if (eq[i].a == 0)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * 0.6 , 4);
                            }
                            else
                            if (eq[i].a == 1)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * 0.6 * (prod[pr].MilkBaseValue / 1000), 4);
                            }
                            else
                            if (eq[i].a == 2)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * 0.6 * (prod[pr].MilkNofatValue / 1000), 4);
                            }
                            else
                            if (eq[i].a == 3)
                            {
                                W = Math.Round(((eq[i].Power * eq[i].Coeff) / eq[i].Performance) * 0.6 * (prod[pr].NormalizedMixture / 1000), 4);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("В некотором продукте не хватает данных для подсчета", "Ошибка продукта");
                        
                    }
                    
                }
                else 
                { 
                    MessageBox.Show("В некотором оборудовании не хватает данных для подсчета", "Ошибка оборудования"); 
                    
                }

                

            }
            else
            {
                MessageBox.Show("В файле" + Helper.pathFile + "не хватает тега 'W' или тега 'a' в файле products для подсчета", "Ошибка");
                
            }

            return W;
        }


        public void ShowDetails(int pr)
        {
            double sum = 0;
            double moika = 0.67;
            for (int i = 0; i < eq.Count; i++)
            {
                GetUdRash(i, pr);
                sum = sum + W;
                this.richTextBox1.Text += W != 0 ? "= " + W.ToString() + " кВт*ч/т \n" : "Hello";                
            }
            sum += moika;
            this.richTextBox1.Text += "Мойка технологического оборудования и трубопроводов = 0,40 кВт*ч/т \n" +
                "Мойка автомолцистерн = 0,27 кВт*ч/т \n";
            this.richTextBox1.Text += sum != 0 ? "Сумма = " + sum.ToString() + " кВт*ч/т\n" : "Hello";

        }
    }
}
