using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Entities
{
    public class Department
    {
        public string Name { get; set; }

        public Department() //construtor padrão da classe
        {

        }

        public Department(string name) //Construtor que recebe o nome como argumento
        {
            Name = name;
        }
    }
}
