using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Houseware : Product
    {
        protected string sMaterial;

        //ctor
        public Houseware() : base()
        {

        }

        public Houseware(string material, string idProduct, string productName, string origin, double price, double mass, string idStore) : base(idProduct, productName, origin, price, mass, idStore)
        {
            this.sMaterial = material;
        }


        //method

        public override void ShowCharacteristics()
        {
            base.ShowCharacteristics();
            Console.WriteLine("Don hang co vat dung de vo!");
        }
        //edit form
        public override string ToString()
        => $"{string.Join(",", sMaterial)}{string.Join(",", sIDProduct),10}{string.Join(",", sProductName),20}{string.Join(",", sOrigin),19}{dPrice,13}{dMass,15}{string.Join(",", sIDStore),15}";
    }
}
