using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Cosmetic : Product
    {
        protected string sDateofManufactureC;
        protected string sExpirationDateC;


        //ctor
        public Cosmetic() : base()
        {

        }

        public Cosmetic(string dateofManufactureC, string expirationDateC, string idProduct, string productName, string origin, double price, double mass, string idStore) : base(idProduct, productName, origin, price, mass, idStore)
        {
            this.sDateofManufactureC = dateofManufactureC;
            this.sExpirationDateC = expirationDateC;
        }

        //method
        //class con Cosmetic
        public override void ShowCharacteristics()
        {
            base.ShowCharacteristics();
            Console.WriteLine("Don hang my pham de vo!");
        }
        //edit form
        public override string ToString()
        => $"{string.Join(",", sDateofManufactureC)}{string.Join(",", sExpirationDateC),20}{string.Join(",", sIDProduct),10}{string.Join(",", sProductName),15}{string.Join(",", sOrigin),15}{dPrice,15}{dMass,15}{string.Join(",", sIDStore),15}";
    }
}
