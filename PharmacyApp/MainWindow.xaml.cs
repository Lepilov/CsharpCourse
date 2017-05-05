using PharmacyApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PharmacyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pharmacy pharmacy = new Pharmacy();

        public MainWindow()
        {
            InitializeComponent();

            pharmacy.CreateListOfMedicaments
                (
                "Анальгин", 125,
                new List<string> { "Метамизол натрия", "Солодки корни" },
                new List<string> { "Боли", "Мигрень" }
                );
            pharmacy.CreateListOfMedicaments
                (
                "Коделак", 100,
                new List<string> { "Кодеин", "Натрия гидрокарбонат", "Солодки корни", "Термопсиса ланцетного трава" },
                new List<string> { "Кашель"}
                );
            pharmacy.CreateListOfMedicaments
                (
                "Колдрекс", 85,
                new List<string> { "Кофеин", "Парацетамол", "Фенилэфрин", "Терпингидрат", "Аскорбиновая кислота" },
                new List<string> { "Кашель", "Боли" }
                );
            pharmacy.CreateListOfMedicaments
                (
                "Парацетамол", 50,
                new List<string> { "Парацетамол" },
                new List<string> { "Боли", "Мигрень" }
                );
            pharmacy.Medicaments.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgMedicine.ItemsSource = pharmacy.Medicaments;
        }

        private void tbSearchByNameOfMedicine_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchByNameOfMedicine();
        }

        private void tbSearchByIndicationForUse_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBySymptomsOfTheDisease();
        }

        private void SearchByNameOfMedicine()
        {
            dgMedicine.ItemsSource = !string.IsNullOrEmpty(tbSearchByNameOfMedicine.Text)
                ? pharmacy.Medicaments.Where(medicaments => IsStringContains(medicaments.NameOfTheMedicine, tbSearchByNameOfMedicine.Text))
                : pharmacy.Medicaments;
        }

        private void SearchBySymptomsOfTheDisease()
        {
            dgMedicine.ItemsSource = !string.IsNullOrEmpty(tbSearchBySymptomsOfTheDisease.Text)
                ? pharmacy.Medicaments.Where(medicaments => medicaments.SymptomsOfTheDisease.Contains(tbSearchBySymptomsOfTheDisease.Text, StringComparer.InvariantCultureIgnoreCase))
                : pharmacy.Medicaments;
        }

        private bool IsStringContains(string stringValue, string containedString)
        {
            return stringValue.IndexOf(containedString, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }

        private void AnalogMedicines()
        {
            Medicament medication = dgMedicine.SelectedItems as Medicament;
            if (medication == null)
                return;

            dgAnalogMedicine.ItemsSource = pharmacy.Medicaments.Where(medicaments =>
            {
                var countActiveSubstancesMedicine = Math.Round(medication.ActiveSubstances.Count / 2.0, MidpointRounding.AwayFromZero);

                var countActiveSubstancesAnalogMedicine = medication.ActiveSubstances.Count(activeSubstancesMedicine =>
                {
                    foreach (var activeSubstances in medicaments.ActiveSubstances)
                    {
                        if (activeSubstancesMedicine == activeSubstances)
                            return true;
                    }

                    return false;
                });

                return countActiveSubstancesAnalogMedicine >= countActiveSubstancesMedicine;
            });
        }
    }
}
