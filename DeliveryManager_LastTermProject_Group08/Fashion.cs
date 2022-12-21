using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Fashion : Product
    {
        protected double dSize;
        protected string sItemFashionColour;


        //constructors
        public Fashion() : base()
        {

        }

        public Fashion(double size, string itemFashionColour, string idProduct, string productName, string origin, double price, double mass, string idStore) : base(idProduct, productName, origin, price, mass, idStore)
        {
            this.dSize = size;
            this.sItemFashionColour = itemFashionColour;
        }

        //method
        public override void ShowCharacteristics()
        {
            base.ShowCharacteristics();
            Console.WriteLine("Don hang thoi trang an toan!");
        }

        //edit form
        public override string ToString()
        => $"{dSize}{string.Join(",", sItemFashionColour),20}{string.Join(",", sIDProduct),10}{string.Join(",", sProductName),15}{string.Join(",", sOrigin),15}{dPrice,15}{dMass,15}{string.Join(",", sIDStore),15}";
    }
}
