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
        public virtual double Mass { get; set; } = 0; //m - масса продукта обрабатываемого за один цикл, т
        public virtual double Power { get; set; } = 0; //Рн - Номинальная мощность электродвигателя кВт 
        public virtual double Coeff { get; set; } = 0; //Ки - коэффициент использования мощности электродвигателей 
        public virtual double a { get; set; } = 0; //а - расход сырья перерабатываемого на данном оборудовании, на одну тонну готовой продукции, т/т(если производительность дана по готовому продукту, а=1).
        public string Temperature { get; set; } //Температура
        public string Rotation { get; set; } //Частота вращения об/мин
        public string Storage { get; set; } //хранение
        public string Pressure { get; set; } //Давление МПа/бар
        public virtual double Performance { get; set; } = 0; //М - производительность оборудования по обрабатываемому сырью или готовому продукту, т/ч
        //W - Удельный расход электроэнергии на производство продукции на рабочих машинах,аппаратах,установках непрерывного действия
        public virtual double W { get; set; } = 0;
        public XmlDocument Xml { get; set; }
        public int XmlIndex { get; set; }

        public string ImageName { get; set; } = "notfound";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            

            if (!string.IsNullOrEmpty(Type))
            {
                sb.AppendLine("Тип: " + Type );
            }
            if (!string.IsNullOrEmpty(Name))
            {
                sb.AppendLine("Марка: " + Name );
            }            
            if (Volume != 0)
            {
                sb.AppendLine("Объём: " + Volume + " м³");
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
            if (!string.IsNullOrEmpty(Pressure))
            {
                sb.AppendLine("Давление: " + Pressure + " МПа/бар");
            }
            if (!string.IsNullOrEmpty(Temperature))
            {
                sb.AppendLine("Температура: " + Temperature + " °C");
            }
            if (!string.IsNullOrEmpty(Rotation))
            {
                sb.AppendLine("Частота вращения: " + Rotation + " об/мин");
            }
            if (!string.IsNullOrEmpty(Storage)) //хранение
            {
                sb.AppendLine("Хранение: " + Storage);
            }
            if (Performance != 0)
            {
                sb.AppendLine("Производительность оборудования по обрабатываемому сырью или готовому продукту: " + Performance + " тонн/час");
            }

            return sb.ToString();
        }

    }    
}
