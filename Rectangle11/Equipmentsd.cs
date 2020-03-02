using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rectangle11
{
    public class Equipments
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public virtual double Volume { get; set; } = 0; //V - рабочий объем танка или емкости, м3
        public virtual double Plotn { get; set; } = 0; //Ro - плотность продукта, т/м3        
        public virtual double Mass { get; set; } = 0; //m - масса продукта обрабатываемого за один цикл, т
        public virtual double Power { get; set; } = 0; //Рн - Номинальная мощность электродвигателя кВт 
        public virtual double Coeff { get; set; } = 0; //Ки - коэффициент использования мощности электродвигателей 
        public virtual double a { get; set; } = 0; //raw material consumption а - расход сырья перерабатываемого на данном оборудовании, на одну тонну готовой продукции, т/т(если производительность дана по готовому продукту, а=1).
        public virtual double Temperature { get; set; } = 0; //Температура
        public virtual double Storage { get; set; } = 0; //хранение
        public virtual double Performance { get; set; } = 0; //М - производительность оборудования по обрабатываемому сырью или готовому продукту, т/ч        
        public virtual double Delay { get; set; } = 0; //выдержка
        public string ImageName { get; set; }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Mass = Volume + Plotn;
            if (!string.IsNullOrEmpty(Type))
            {
                sb.AppendLine("Тип: " + Type );
            }
            if (!string.IsNullOrEmpty(Name))
            {
                sb.AppendLine("Марка: " + Name );
            }
            if (Mass != 0)
            {
                sb.AppendLine("Масса продукта обрабатываемого за 1 цикл: " + Mass + " тонн");
            }
            if (Volume != 0)
            {
                sb.AppendLine("Объём: " + Volume + " м³");
            }
            if (Plotn != 0)
            {
                sb.AppendLine("Плотность: " + Plotn + " тонн/м³");
            }
            if (Power != 0)
            {
                sb.AppendLine("Мощность электродвигателя: " + Power + " кВт");
            }
            if (Coeff != 0)
            {
                sb.AppendLine("Коэффициент использования мощности электродвигателей: " + Coeff );
            }
            if (a != 0)
            {
                sb.AppendLine("Расход сырья на данном оборудовании: " + a + " т/т");
            }
            if (Temperature != 0)
            {
                sb.AppendLine("Температура: " + Temperature + " °C");
            }
            if (Storage != 0) //хранение
            {
                sb.AppendLine("Хранение: не более " + Storage + " часа(ов)");
            }
            if (Performance != 0)
            {
                sb.AppendLine("Производительность оборудования по обрабатываемому сырью или готовому продукту: " + Performance + " тонн/час");
            }
            if (Delay != 0)
            {
                sb.AppendLine("Выдержка: " + Delay + " сек");
            }


            return sb.ToString();
        }

    }    
}
