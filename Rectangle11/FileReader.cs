using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rectangle11
{
    public static class FileReader
    {

        public static List<Equipments> GetEquipments() //считывание файла оборудования xml
        {
            List<Equipments> equipments = new List<Equipments>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"../../Xmls/equitments.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Equipments equipment = new Equipments();


                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if(childnode.Name == "type")
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
                    }

                    if (childnode.Name == "Volume")
                    {
                        equipment.Volume = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Plotn")
                    {
                        equipment.Plotn = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Mass")
                    {
                        equipment.Mass = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Power")
                    {
                        equipment.Power = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Coeff")
                    {
                        equipment.Coeff = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "a")
                    {
                        equipment.a = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Temperature")
                    {
                        equipment.Temperature = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Storage")
                    {
                        equipment.Storage = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Performance")
                    {
                        equipment.Performance = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Delay")
                    {
                        equipment.Delay = Double.Parse(childnode.InnerText);
                    }





                }
                equipments.Add(equipment);
            }

            return equipments;
        }


        public static Product GetProduct() //считывание файла products xml
        {
            
            Product product = new Product();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"../../Xmls/products.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {               
                XmlNode type = xnode.Attributes.GetNamedItem("type");
                if (type == null)
                    return null;

                ProductTypes types = (ProductTypes)Enum.Parse(typeof(ProductTypes), type.Value);

                switch (types)
                {
                    case ProductTypes.Milk:
                        product.ProductType = ProductTypes.Milk;
                        break;
                    case ProductTypes.Kefir:
                        product.ProductType = ProductTypes.Kefir;
                        break;
                    case ProductTypes.Curd:
                        product.ProductType = ProductTypes.Curd;
                        break;
                    case ProductTypes.Yogurt:
                        product.ProductType = ProductTypes.Yogurt;
                        break;
                    case ProductTypes.SourCream:
                        product.ProductType = ProductTypes.SourCream;
                        break;
                    default:
                        product.ProductType = ProductTypes.None;
                        break;
                }


                XmlNode name = xnode.Attributes.GetNamedItem("name");
                if (name == null)
                    return null;

                product.Name = name.Value;

                XmlNode fat = xnode.Attributes.GetNamedItem("fat");
                if (fat == null)
                    return null;               

                product.Fat = fat.Value;


                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "normalizedMixture")
                    {
                        product.normalizedMixture = Double.Parse(childnode.InnerText);

                        XmlNode mixName = childnode.Attributes.GetNamedItem("name");
                        if (mixName != null)                            
                        product.MixtureName = mixName.Value;


                        XmlNode mixFat = childnode.Attributes.GetNamedItem("fat");
                        if (mixFat != null)
                        product.MixtureFat = mixFat.Value;

                    }
                    if (childnode.Name == "milk_base")
                    {
                        product.MilkBaseValue = Double.Parse(childnode.InnerText);

                        XmlNode milkFat = childnode.Attributes.GetNamedItem("fat");
                        if (milkFat != null)
                            product.MilkBaseFat = milkFat.Value;
                    }
                    if (childnode.Name == "milk_nofat")
                    {
                        product.MilkNofatValue = Double.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "image_name")
                    {
                        product.ImageName = childnode.InnerText;
                    }
                }
            }

            return product;

        }
    }
}
