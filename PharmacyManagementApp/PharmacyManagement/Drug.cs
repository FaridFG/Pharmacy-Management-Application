using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagement
{
    class Drug
    {
        private static int _id;
        public int Id;
        public string Name;
        public DrugType Type;
        public int Price;
        private int Quantity;
        public int dQuantity
        {
            get
            {
                return Quantity;
            }
        }

        public Drug(string name, int price, int quantity, DrugType type)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }

        public override string ToString()
        {
            return $"Drug's name: {Name}, Drug's price: {Price}, Drug's quantity: {Quantity}, Drug's type: {Type}.";
        }

        public void IncreaseQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void DecreaseQuantity(int quantity)
        {
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
            }
            else
            {
                Console.WriteLine($"Sorry, but we have only {Quantity} packs of {this.Name}");
            }
        }
    }
}
