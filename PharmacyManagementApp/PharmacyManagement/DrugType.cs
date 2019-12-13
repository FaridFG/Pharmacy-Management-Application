using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagement
{
    class DrugType
    {
        private static int _id;
        public int Id;
        public string Type;

        public DrugType(string type)
        {
            _id++;
            Id = _id;
            Type = type;
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
