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
        public double normalizedMixture { get; set; }
        public string MixtureName { get; set; }
        public string MixtureFat { get; set; }
        public double MilkBaseValue { get; set; }
        public double MilkNofatValue { get; set; }
        public string MilkBaseFat { get; set; }
        public string ImageName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
            {
                sb.Append("Наименование: " + Name);
            }

            if (!String.IsNullOrEmpty(Fat))
            {
                sb.AppendLine(", Жирность: " + Fat + "%");
            }

            if ((normalizedMixture)!=0)
            {
                sb.AppendLine("Нормализованная смесь: " + normalizedMixture + "кг");
            }

            if (!String.IsNullOrEmpty(MixtureName))
            {
                sb.AppendLine("Наименование: " + MixtureName);
            }

            if (!String.IsNullOrEmpty(MixtureFat))
            {
                sb.AppendLine("Жирность: " + MixtureFat + "%");
            }

            if ((MilkBaseValue) != 0)
            {
                sb.AppendLine("Молоко базисной жирности: " + MilkBaseValue + "кг");
            }

            if (!String.IsNullOrEmpty(MilkBaseFat))
            {
                sb.AppendLine("Жирность: " + MilkBaseFat + "%");
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
