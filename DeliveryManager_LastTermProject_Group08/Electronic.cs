using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Electronic : Product
    {
        protected double dStorage;
        protected string sItemColour;



        //constructors
        public Electronic() : base()
        {

        }

        public Electronic(double storage, string itemColour, string idProduct, string productName, string origin, double price, double mass, string idStore) : base(idProduct, productName, origin, price, mass, idStore)
        {
            this.dStorage = storage;
            this.sItemColour = itemColour;
        }

        //method

        public override void ShowCharacteristics()
        {
            base.ShowCharacteristics();
            Console.WriteLine("Don hang co do dien tu de vo!");
        }
        //edit form
        public override string ToString()
        => $"{dStorage}{string.Join(",", sItemColour),17}{string.Join(",", sIDProduct),12}{string.Join(",", sProductName),19}{string.Join(",", sOrigin),14}{dPrice,14}{dMass,15}{string.Join(",", sIDStore),16}";
    }
}
