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
        public virtual int Mass { get; set; } = 0;

        public virtual int Power { get; set; } = 0;

        public virtual int Temperature { get; set; } = 0;

        public virtual int Storage { get; set; } = 0; //хранение

        public virtual int Pressure { get; set; } = 0; //давление

        public virtual int Delay { get; set; } = 0; //выдержка

        public string ImageName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Mass != 0)
            {
                sb.AppendLine("Mass:" + Mass + "тонн");
            }

            if (Power != 0)
            {
                sb.AppendLine("Power:" + Power + "В");
            }

            if (!string.IsNullOrEmpty(Type))
            {
                sb.AppendLine("Тип:" + Type + "отсос");
            }

            return sb.ToString();
        }

    }    
}
