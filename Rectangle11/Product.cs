using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rectangle11
{
    public class Product
    {
        public string Name { get; set; } //Наименование производимой продукции
        public string Type { get; set; } //Тип продукции(не показывается в программе, но считывается из файла)
        public string Fat { get; set; } //Жирность производимой продукции
        public double NormalizedMixture { get; set; } //Нормализованная смесь
        public string MixtureName { get; set; } //Наименование нормализованной смеси
        public string MixtureFat { get; set; } //Жирность нормализованной смеси
        public double MilkBaseValue { get; set; } //Молоко базисной жирности
        public string MilkBaseFat { get; set; } //Жирность базисного молока
        public double MilkNofatValue { get; set; } //Обезжиренное молоко
        public double Performance { get; set; } //Производительность продукции в сутки
        public virtual double Plotn { get; set; } = 0; //Ro - плотность продукта, т/м3 
        public XmlDocument Xml { get; set; }
        public int XmlIndex { get; set; }
        public string ImageName { get; set; } = ("notfound");

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Name))
            {
                sb.Append("Наименование продукции: " + Name);
            }

            if (!String.IsNullOrEmpty(Fat))
            {
                sb.AppendLine(", жирностью: " + Fat + "%");
            }

            if ((NormalizedMixture) >= 0)
            {
                sb.Append("Нормализованная смесь: " + NormalizedMixture + " кг.");
            }

            if (!String.IsNullOrEmpty(MixtureName))
            {
                sb.Append(", вид смеси: " + MixtureName);
            }

            if (!String.IsNullOrEmpty(MixtureFat))
            {
                sb.AppendLine(", жирностью: " + MixtureFat + "%");
            }

            if ((MilkBaseValue) >= 0)
            {
                sb.Append("Молоко базисной жирности: " + MilkBaseValue + " кг.");
            }

            if (!String.IsNullOrEmpty(MilkBaseFat))
            {
                sb.AppendLine(", жирностью: " + MilkBaseFat + "%");
            }

            if ((MilkNofatValue) >= 0)
            {
                sb.AppendLine("Молоко обезжиренное: " + MilkNofatValue + " кг.");
                sb.AppendLine();
            }

            if ((Performance) >= 0)
            {
                sb.AppendLine("Суточная производительность продукта: " + Performance + " тонн.");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

}
