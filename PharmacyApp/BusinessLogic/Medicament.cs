using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.BusinessLogic
{
    public class Medicament
    {
        public string NameOfTheMedicine { get; private set; }
        public decimal PriceOfMedicine { get; private set; }
        public List<string> ActiveSubstances { get; private set; }
        public List<string> SymptomsOfTheDisease { get; private set; }

        public Medicament(string nameOfTheMedicine, decimal priceOfMedicine, List<string> activeSubstances, List<string> symptomsOfTheDisease)
        {
            NameOfTheMedicine = nameOfTheMedicine;
            PriceOfMedicine = priceOfMedicine;
            ActiveSubstances = activeSubstances;
            SymptomsOfTheDisease = symptomsOfTheDisease;
        }
    }
}
