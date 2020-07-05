using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace Rectangle11
{

    public static class FileReader
    {
        
        public static List<Equipments> GetEquipments() //считывание файла оборудования xml
        {
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            System.Globalization.NumberStyles style;
            System.Globalization.CultureInfo culture;
            style = System.Globalization.NumberStyles.Number |
            System.Globalization.NumberStyles.AllowCurrencySymbol;
            culture = System.Globalization.CultureInfo.CurrentUICulture;

            //string pathFile = @"../../Xmls/equipments.xml";
            if (!File.Exists(Helper.pathFile)) //если файл не найден
            {
                MessageBox.Show("File equipments " + Helper.pathFile + " not found");
                return null;
            }
            else
            {
                try
                {
                    List<Equipments> equipments = new List<Equipments>();

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(Helper.pathFile);
                    XmlElement xRoot = xDoc.DocumentElement;
                    foreach (XmlElement xnode in xRoot)
                    {
                        Equipments equipment = new Equipments();
                        equipment.Xml = xDoc;
                        equipment.XmlIndex = xnode.GetHashCode();

                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "type")
                            {
                                equipment.Type = childnode.InnerText;
                            }
                            if (childnode.Name == "name")
                            {
                                equipment.Name = childnode.InnerText;
                            }
                            if (childnode.Name == "ImageName")
                            {
                                equipment.ImageName = childnode.InnerText;

                                if (string.IsNullOrEmpty(equipment.ImageName))
                                {
                                    equipment.ImageName = "notfound";
                                }
                            }
                            if (childnode.Name == "Volume")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.Volume = result;
                                }
                                else { MessageBox.Show("Значение тега Volume неверно ", "Ошибка"); equipment.Volume = 0; }
                            }
                            if (childnode.Name == "Mass")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.Mass = result;
                                }
                                else { MessageBox.Show("Значение тега Mass неверно ", "Ошибка"); equipment.Mass = 0; }
                            }
                            if (childnode.Name == "Power")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.Power = result;
                                }
                                else { MessageBox.Show("Значение тега Power неверно ", "Ошибка"); equipment.Power = 0; }
                            }
                            if (childnode.Name == "Coeff")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.Coeff = result;
                                }
                                else { MessageBox.Show("Значение тега Coeff неверно ", "Ошибка"); equipment.Coeff = 0; }
                            }
                            if (childnode.Name == "W")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.W = result;
                                }
                                else { MessageBox.Show("Значение тега a неверно ", "Ошибка"); equipment.W = 0; }
                            }
                            if (childnode.Name == "a")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.a = result;
                                }
                                else { MessageBox.Show("Значение тега a неверно ", "Ошибка"); equipment.a = 0; }
                            }
                            if (childnode.Name == "Pressure")
                            {
                                equipment.Pressure = childnode.InnerText;
                            }
                            if (childnode.Name == "Temperature")
                            {
                                equipment.Temperature = childnode.InnerText;
                            }
                            if (childnode.Name == "Rotation")
                            {
                                equipment.Rotation = childnode.InnerText;
                            }
                            if (childnode.Name == "Storage")
                            {
                                equipment.Storage = childnode.InnerText;
                            }
                            if (childnode.Name == "Performance")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    equipment.Performance = result;
                                }
                                else { MessageBox.Show("Значение тега Performance неверно ", "Ошибка"); equipment.Performance = 0; }
                            }



                        }
                        equipments.Add(equipment);
                    }

                    return equipments;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла. \n " + exc.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public static List<Product> GetProduct() //считывание файла products xml
        {
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            System.Globalization.NumberStyles style;
            System.Globalization.CultureInfo culture;
            style = System.Globalization.NumberStyles.Number |
            System.Globalization.NumberStyles.AllowCurrencySymbol;
            culture = System.Globalization.CultureInfo.CurrentUICulture;

            string pathFile = @"../../Xmls/products.xml";
            if (!File.Exists(pathFile)) //если файл не найден
            {
                MessageBox.Show("File products not found");
                return null;
            }
            else
            {
                try
                {
                    List<Product> products = new List<Product>();
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(pathFile);
                    XmlElement xRoot = xDoc.DocumentElement;
                    foreach (XmlElement xnode in xRoot)
                    {
                        Product product = new Product();

                        product.Xml = xDoc;
                        product.XmlIndex = xnode.GetHashCode();

                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            XmlNode type = xnode.Attributes.GetNamedItem("type");
                            if (type == null)
                                return null;

                            product.Type = type.Value;

                            XmlNode name = xnode.Attributes.GetNamedItem("name");
                            if (name == null)
                                return null;

                            product.Name = name.Value;

                            XmlNode fat = xnode.Attributes.GetNamedItem("fat");
                            if (fat == null)
                                return null;

                            product.Fat = fat.Value;

                            if (childnode.Name == "NormalizedMixture")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    product.NormalizedMixture = result;
                                }
                                else { MessageBox.Show("Значение тега NormalizedMixture неверно ", "Ошибка"); product.NormalizedMixture = 0; }

                                XmlNode mixName = childnode.Attributes.GetNamedItem("name");
                                if (mixName != null)
                                    product.MixtureName = mixName.Value;

                                XmlNode mixFat = childnode.Attributes.GetNamedItem("fat");
                                if (mixFat != null)
                                    product.MixtureFat = mixFat.Value;
                            }
                            if (childnode.Name == "milk_base")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    product.MilkBaseValue = result;
                                }
                                else { MessageBox.Show("Значение тега milk_base неверно ", "Ошибка"); product.MilkBaseValue = 0; }

                                XmlNode milkFat = childnode.Attributes.GetNamedItem("fat");
                                if (milkFat != null)
                                    product.MilkBaseFat = milkFat.Value;
                            }
                            if (childnode.Name == "milk_nofat")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    product.MilkNofatValue = result;
                                }
                                else { MessageBox.Show("Значение тега milk_nofat неверно ", "Ошибка"); product.MilkNofatValue = 0; }
                            }
                            if (childnode.Name == "Performance")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    product.Performance = result;
                                }
                                else { MessageBox.Show("Значение тега Performance неверно ", "Ошибка"); product.Performance = 0; }
                            }
                            if (childnode.Name == "Plotn")
                            {
                                if (Double.TryParse(childnode.InnerText.Replace('.', separator), style, culture, out double result))
                                {
                                    product.Plotn = result;
                                }
                                else { MessageBox.Show("Значение тега Plotn неверно ", "Ошибка"); product.Plotn = 0; }
                            }
                            if (childnode.Name == "image_name")
                            {
                                product.ImageName = childnode.InnerText;
                            }
                            else { product.ImageName = ("notfound"); }
                        }
                        products.Add(product);
                    }

                    return products;
                }

                catch(Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла. \n " + exc.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }

        public static void SaveProduct(Product pr)
        {
            if (pr == null)
                return;

            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Программа ",
                MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                XmlElement xRoot = pr.Xml.DocumentElement;

                foreach (XmlElement xnode in xRoot)
                {
                    if (xnode.GetHashCode() == pr.XmlIndex)
                    {
                        XmlNode type = xnode.Attributes.GetNamedItem("type");

                        type.Value = pr.Type;

                        XmlNode name = xnode.Attributes.GetNamedItem("name");

                        name.Value = pr.Name;

                        XmlNode fat = xnode.Attributes.GetNamedItem("fat");

                        fat.Value = pr.Fat;

                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "NormalizedMixture")
                            {
                                double.Parse(childnode.InnerText = pr.NormalizedMixture.ToString());

                                XmlNode mixName = childnode.Attributes.GetNamedItem("name");
                                if (mixName != null)
                                    mixName.Value = pr.MixtureName;

                                XmlNode mixFat = childnode.Attributes.GetNamedItem("fat");
                                if (mixFat != null)
                                    mixFat.Value = pr.MixtureFat;
                            }
                            if (childnode.Name == "milk_base")
                            {
                                double.Parse(childnode.InnerText = pr.MilkBaseValue.ToString());

                                XmlNode milkFat = childnode.Attributes.GetNamedItem("fat");
                                if (milkFat != null)
                                    milkFat.Value = pr.MilkBaseFat;
                            }
                            if (childnode.Name == "milk_nofat")
                            {
                                double.Parse(childnode.InnerText = pr.MilkNofatValue.ToString());
                            }
                            if (childnode.Name == "Plotn")
                            {
                                Double.Parse(childnode.InnerText = pr.Plotn.ToString());
                            }
                            if (childnode.Name == "image_name")
                            {
                                pr.ImageName = childnode.InnerText;
                            }
                            else { pr.ImageName = ("notfound"); }
                        }

                    }

                }
                try
                {
                    pr.Xml.Save(@"../../Xmls/products.xml");
                    //MessageBox.Show("Данные успешно сохранены.", "Сообщение.");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
                }
            }
            if (res == DialogResult.No)
            {
                
                return;
            }
        }


        public static void SaveEquipments(Equipments eq)
        {
            if (eq == null)
                return;
            
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

            DialogResult res = MessageBox.Show("Сохранить изменения?", "Программа ",
                MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                XmlElement xRoot = eq.Xml.DocumentElement;

                foreach (XmlElement xnode in xRoot)
                {
                    if (xnode.GetHashCode() == eq.XmlIndex)
                    {
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "type")
                            {
                                childnode.InnerText = eq.Type;
                            }
                            if (childnode.Name == "name")
                            {
                                childnode.InnerText = eq.Name;
                            }
                            if (childnode.Name == "ImageName")
                            {
                                childnode.InnerText = eq.ImageName;

                                if (string.IsNullOrEmpty(eq.ImageName))
                                {
                                    eq.ImageName = "notfound";
                                }
                            }
                            if (childnode.Name == "Volume")
                            {
                                Double.Parse(childnode.InnerText = eq.Volume.ToString());
                            }
                            if (childnode.Name == "Mass")
                            {
                                Double.Parse(childnode.InnerText = eq.Mass.ToString());
                            }
                            if (childnode.Name == "Power")
                            {
                                Double.Parse(childnode.InnerText = eq.Power.ToString());
                            }
                            if (childnode.Name == "Coeff")
                            {
                                Double.Parse(childnode.InnerText = eq.Coeff.ToString());
                            }
                            if (childnode.Name == "W")
                            {
                                Double.Parse(childnode.InnerText = eq.W.ToString());
                            }
                            if (childnode.Name == "Pressure")
                            {
                                childnode.InnerText = eq.Pressure;
                            }
                            if (childnode.Name == "Temperature")
                            {
                                childnode.InnerText = eq.Temperature;
                            }
                            if (childnode.Name == "Rotation")
                            {
                                childnode.InnerText = eq.Rotation;
                            }
                            if (childnode.Name == "Storage")
                            {
                                childnode.InnerText = eq.Storage;
                            }
                            if (childnode.Name == "Performance")
                            {
                                Double.Parse(childnode.InnerText = eq.Performance.ToString());
                            }
                        }
                    }
                }
                try
                {
                    eq.Xml.Save(Helper.pathFile);
                    eq.Xml.Save(@"../../Xmls/temp.xml");
                    //MessageBox.Show("Данные успешно сохранены.", "Сообщение.");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
                }
            }
            if (res == DialogResult.No)
            {
                
            }



        }
    }
}

