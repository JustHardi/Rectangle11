using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rectangle11
{
    public class FileReader
    {

        public Product GetProduct()
        {
            Product product = new Product();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("/xml/products.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                
                XmlNode attr = xnode.Attributes.GetNamedItem("name");
                if (attr != null)
                    product.Name = attr.Value;

                //foreach (XmlNode childnode in xnode.ChildNodes)
                //{
                //    if (childnode.Name == "semifinished")
                //        user.semifinished = Int32.Parse(childnode.InnerText);
                //    if (childnode.Name == "milk_fat_3_6")
                //        user.milk_fat_3_6 = Convert.ToDouble(childnode.InnerText);
                //    if (childnode.Name == "milk_nofat")
                //        user.semifinished = Int32.Parse(childnode.InnerText);
                //}
                //products.Add(user);
            }

            return product;

        }
    }
}
