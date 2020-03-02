using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle11
{
    public class Product
    {
        public ProductTypes ProductType { get; set; }
        public string Name { get; set; }
        public string Fat { get; set; }
        public double Semifinished { get; set; }
        public double MilkBaseValue { get; set; }
        public double MilkNofatValue { get; set; }
        public string MilkBaseFat { get; set; }
        public string ImageName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
            {
                sb.AppendLine("Наименование:" + Name);
            }

            if (!String.IsNullOrEmpty(Fat))
            {
                sb.AppendLine("Фат:" + Fat + "%");
            }

            return sb.ToString();
        }
    }

    public enum ProductTypes
    {
        None,
        Milk,
        Kefir,
        SourCream, //сметана
        Curd, //творог
        Yogurt
    }
}
