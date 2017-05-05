using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.BusinessLogic
{
    public class Pharmacy
    {
        public List<Medicament> Medicaments { get; private set; }

        public Pharmacy()
        {
            Medicaments = new List<Medicament>();
        }

        public Medicament CreateListOfMedicaments(string nameOfTheMedicine, decimal priceOfMedicine, List<string> activeSubstances, List<string> symptomsOfTheDisease)
        {
            Medicament listOfMedicaments = new Medicament(nameOfTheMedicine, priceOfMedicine, activeSubstances, symptomsOfTheDisease);
            Medicaments.Add(listOfMedicaments);
            return listOfMedicaments;
        }
    }
}
