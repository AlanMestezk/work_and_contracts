
using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; set;}
        public WorkerLevel Level { get; set; }
        public double BaseSalaray { get; set; }
        public Departament Departament { get; set; }
        public List<HourContratct> Contratcts { get; set; } = new List<HourContratct>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalaray, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalaray = baseSalaray;
            Departament = departament;
        }

        public void AddContract(HourContratct contratct)
        {
            Contratcts.Add(contratct);
        }

        public void RemoveContratc(HourContratct contratct)
        {
            Contratcts.Remove(contratct);
        }
        
        public double Income(int year, int month)
        {
            double sum = BaseSalaray;
            foreach(HourContratct contract in Contratcts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}

