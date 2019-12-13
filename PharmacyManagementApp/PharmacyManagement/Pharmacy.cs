using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagement
{
    class Pharmacy
    {
        private static int _id;
        public int Id;
        public string Name;
        private Drug[] DrugList = { };
        StringBuilder Drugs = new StringBuilder();

        public Pharmacy(string name)
        {
            _id++;
            Id = _id;
            Name = name;
        }

        public void PrintDrugsList()
        {
            foreach (Drug drug in DrugList)
            {
                Console.WriteLine(drug);
            }
        }

        public void AddingDrug(Drug drug)
        {
            foreach (Drug d in DrugList)
            {
                Drugs.Append(d.Name);
            }
            if (Drugs.ToString().ToLower().Contains(drug.Name.ToLower()))
            {
                Console.WriteLine("This drug is already exists in our Pharmacy");
            }
            else
            {
                Array.Resize(ref DrugList, DrugList.Length + 1);
                DrugList[DrugList.Length - 1] = drug;
            }
        }

        public void SellDrugs(string name, int number)
        {
            foreach (Drug drug in DrugList)
            {
                Drugs.Append(drug.Name);
            }

            if (number == 0)
            {
                Console.WriteLine("To buy something you must enter a number bigger than zero");
            }
            else if (number < 0)
            {
                number = Math.Abs(number);
            }

            if (!Drugs.ToString().ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine("Sorry, but we don't have this drug");
            }
            else
            {
                foreach (Drug drug in DrugList)
                {
                    if (drug.Name.ToLower() == name.ToLower() && drug.dQuantity >= number && number != 0)
                    {
                        drug.DecreaseQuantity(number);
                        Console.WriteLine($"You ordered {number} packs of {drug.Name} and you must pay {drug.Price * number} AZN ({number} packs * {drug.Price} AZN)");
                    }
                    else if (drug.Name.ToLower() == name.ToLower() && drug.dQuantity == 0)
                    {
                        Console.WriteLine("Unfortunately, this drug has finished");
                    }
                    else if (drug.Name.ToLower() == name.ToLower() && drug.dQuantity < number)
                    {
                        Console.WriteLine($"Sorry, but we only have {drug.dQuantity} packs of {drug.Name}.");
                    }
                }
            }
        }
    }
}
