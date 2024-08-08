using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract() //Construtor padrão
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hour) // Construtor que vai receber argumentos
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
