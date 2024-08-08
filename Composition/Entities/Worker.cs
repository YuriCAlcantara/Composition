using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.Entities.Enums; //

namespace Composition.Entities
{
    class Worker
    {


        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department? Department { get; set; } //Associação entre as classes Worker e Department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Atribuição para que a lista não seja nula.

        public Worker()
        {
        }

        public Worker(string? name, WorkerLevel level, double baseSalary, Department? department) //Não foi incluido contract no construtor pois há uma relação para vários
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContratc(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double Sum = BaseSalary; // o funcionário tem um salário base

            foreach (HourContract contract in Contracts) // percorrer a lista HourContract
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    Sum += contract.TotalValue();
                }
            }

            return Sum;
        }

        
    }
}
