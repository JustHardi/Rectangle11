using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle11
{
    public class Results
    {
        public double UdRash { get; set; } = Double.NaN;

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            if (!Double.IsNaN(UdRash))
            {
                sb.AppendLine("Удельный расход электроэнергии:" + UdRash);
            }

            return sb.ToString();

        }
    }
}