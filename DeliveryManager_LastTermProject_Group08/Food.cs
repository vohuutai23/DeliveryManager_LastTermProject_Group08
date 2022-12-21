using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Food : Product
    {
        protected string sDateofManufactureF;
        protected string sExpirationF;


        //ctor
        public Food() : base()
        {

        }

        public Food(string dateofManufactureF, string expirationF, string idProduct, string productName, string origin, double price, double mass, string idStore) : base(idProduct, productName, origin, price, mass, idStore)
        {
            this.sDateofManufactureF = dateofManufactureF;
            this.sExpirationF = expirationF;
        }

        //method 

        public override void ShowCharacteristics()
        {
            base.ShowCharacteristics();
            Console.WriteLine("Don hang chua thuc pham de bi hu hong!");
        }


        //edit form
        public override string ToString()
        => $"{string.Join(",", sDateofManufactureF)}{string.Join(",", sExpirationF),20}{string.Join(",", sIDProduct),10}{string.Join(",", sProductName),15}{string.Join(",", sOrigin),15}{dPrice,15}{dMass,15}{string.Join(",", sIDStore),15}";
    }
}
