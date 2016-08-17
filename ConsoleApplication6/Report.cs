using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Report : IReport
    {
        public int Difficuty { get; set; }

        public Report(int difficulty)
        {
            Difficuty = difficulty;
        }


    }
}
