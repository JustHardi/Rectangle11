using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rectangle11
{
    public partial class Form2 : Form
    {
        Product pr = null; //  new Product();
        Equipments eq = null;

        public bool CellChanged { get; set; } = false;

        public Form2()
        {
            InitializeComponent();

            pictureBox1.ErrorImage = Image.FromFile(@"../../Images/notfound.png");
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;   //FromArgb(138, 198, 230);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;

        }

        public void ShowEquipmentDetails(Equipments scheme)
        {
            dataGridView1.Refresh();
            dataGridView1.RefreshEdit();

            eq = scheme;
            if(scheme.ImageName != null) this.pictureBox1.Image = Image.FromFile(@"../../Images/" + scheme.ImageName + ".png");

            dataGridView1.Rows.Add();
            if (scheme.Type != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Тип:", scheme.Type);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Type";
            }
            if (scheme.Name != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Марка:", scheme.Name);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Name";
            }
            if (scheme.Performance != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Производительность т/ч:", scheme.Performance);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Performance";
            }
            if (scheme.Pressure != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Давление МПа/бар:", scheme.Pressure);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Pressure";
            }
            if (scheme.Power != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Мощность кВт:", scheme.Power);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Power";
            }
            if (scheme.Coeff != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Коэфф. использования оборудования:", scheme.Coeff);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Coeff";
            }
            if (scheme.Temperature != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Температура °C:", scheme.Temperature);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Temperature";
            }
            if (scheme.Volume != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Объём м³:", scheme.Volume);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Volume";
            }
            if (scheme.Storage != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Хранение:", scheme.Storage);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Storage";
            }
            if (scheme.Rotation != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Частота вращения об/мин:", scheme.Rotation);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Rotation";
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

            this.Show();
        }

        public void ShowPoductDetails(Product products) //запись данных о продукте в ячейки datagridview1
        {
            dataGridView1.Refresh();
            dataGridView1.RefreshEdit();

            pr = products;
            if (products.ImageName != null) this.pictureBox1.Image = Image.FromFile(@"../../Images/" + products.ImageName + ".png");

            dataGridView1.Rows.Add();
            if (products.Name != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Наименование:", products.Name);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Name";
            }
            if (products.Fat != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Жирность (%):", products.Fat);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Fat";
            }
            if (products.NormalizedMixture != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Нормализованная смесь (кг):", products.NormalizedMixture);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "NormalizedMixture";
            }
            if (products.MixtureName != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Наименование смеси:", products.MixtureName);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "MixtureName";
            }
            if (products.MixtureFat != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Жирность (%):", products.MixtureFat);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "MixtureFat";
            }
            if (products.MilkBaseValue != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Молоко базисной жирности (кг):", products.MilkBaseValue);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "MilkBaseValue";
            }
            if (products.MilkBaseFat != null)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Жирность (%):", products.MilkBaseFat);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "MilkBaseFat";
            }
            if (products.MilkNofatValue != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Молоко обезжиренное (кг):", products.MilkNofatValue);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "MilkNofatValue";
            }
            if (products.Performance != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Суточная производительность (тонн):", products.Performance);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Performance";
            }
            if (products.Plotn != 0)
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count - 1, "Плотность продукта (т/м3):", products.Plotn);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Tag = "Plotn";
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);            

            this.Show();
        }

        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CellChanged)
            {
                FileReader.SaveProduct(pr);
                FileReader.SaveEquipments(eq);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) //возникает при изменении значения ячейки
        {
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            if (e.ColumnIndex == 1 && pr != null)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Name")
                {
                    pr.Name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Fat")
                {
                    pr.Fat = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "NormalizedMixture")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        pr.NormalizedMixture = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pr.NormalizedMixture;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "MixtureName")
                {
                    pr.MixtureName = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "MixtureFat")
                {
                    pr.MixtureFat = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "MilkBaseValue")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        pr.MilkBaseValue = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pr.MilkBaseValue;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "MilkBaseFat")
                {
                    pr.MilkBaseFat = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "MilkNofatValue")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        pr.MilkNofatValue = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pr.MilkNofatValue;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Performance")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        pr.Performance = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pr.Performance;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Plotn")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        pr.Plotn = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = pr.Plotn;
                    }
                }

                CellChanged = true;
            }

            if (e.ColumnIndex == 1 && eq != null)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Type")
                {
                    eq.Type = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Name")
                {
                    eq.Name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Performance")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        eq.Performance = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = eq.Performance;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Pressure")
                {
                    eq.Pressure = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Power")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        eq.Power = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = eq.Power;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Coeff")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        eq.Coeff = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = eq.Coeff;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Temperature")
                {
                    eq.Temperature = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Volume")
                {
                    if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', separator), out double result))
                    {
                        eq.Volume = result;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение поля", "Ошибка");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = eq.Volume;
                    }
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Storage")
                {
                    eq.Storage = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString() == "Rotation")
                {
                    eq.Rotation = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                CellChanged = true;
            }
        } 

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) //возникает при проверке допустимости ячейки
        {
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Column2")) return;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText =
                    "Ячейка не может быть пустой";
                MessageBox.Show("Ячейка не может быть пустой", "Ошибка");
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) //возникает при остановке режима правки для выбранной ячейки
        {
            // Clear the row error in case the user presses ESC.
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(
                dataGridView1_CellValueChanged);
            CellChanged = false;            
        }

        //возникает при отображении элемента управления для редактирования ячейки
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) 
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (!Char.IsLetter(e.KeyChar)) &&
                (e.KeyChar != '-') && (e.KeyChar != '+') && (e.KeyChar != '±') &&
                (e.KeyChar != '=') && e.KeyChar != ',' && e.KeyChar != (char)Keys.Space)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

