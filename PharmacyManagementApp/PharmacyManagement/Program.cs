using System;

namespace PharmacyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugType headache = new DrugType("headache");
            DrugType heartache = new DrugType("heartache");
            DrugType toothache = new DrugType("toothache");

            Drug Nimesil = new Drug("Nimesil", 5, 80, toothache);
            Drug Tempalgin = new Drug("Tempalgin", 3, 140, headache);
            Drug Valerian = new Drug("Valerian", 8, 250, heartache);

            Pharmacy EuroMed = new Pharmacy("EuroMed");
            EuroMed.AddingDrug(Nimesil);
            EuroMed.AddingDrug(Valerian);
            EuroMed.AddingDrug(Tempalgin);
            EuroMed.AddingDrug(Nimesil);
            EuroMed.PrintDrugsList();
            Console.WriteLine();
            EuroMed.SellDrugs("Nimesil", 78);
            Console.WriteLine();
            EuroMed.PrintDrugsList();
            Console.WriteLine();
            EuroMed.SellDrugs("nimesil", 5);
            Nimesil.IncreaseQuantity(20);
            Console.WriteLine();
            EuroMed.PrintDrugsList();
            Console.WriteLine();
            EuroMed.SellDrugs("nimesil", -23);
            Console.WriteLine();
            EuroMed.PrintDrugsList();
            Console.WriteLine();
            EuroMed.SellDrugs("tempalgin", 83);
            Console.WriteLine();
            EuroMed.PrintDrugsList();
        }
    }
}
