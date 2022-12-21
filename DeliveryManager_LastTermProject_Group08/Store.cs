using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Store
    {
        //fields
        public string sIDStore;
        public string sStoreName;
        public string sStoreAddress;
        public string sPhoneNumberofStore;

        //properties
        public string IDStore
        {
            get { return this.sIDStore; }
            set { this.sIDStore = value; }
        }

        public string StoreName
        {
            get { return this.sStoreName; }
            set { this.sStoreName = value; }
        }

        public string StoreAddress
        {
            get { return this.sStoreAddress; }
            set { this.sStoreAddress = value; }
        }

        public string PhoneNumberofStore
        {
            get { return this.sPhoneNumberofStore; }
            set { this.sPhoneNumberofStore = value; }
        }


        //constructors
        public Store()
        {

        }

        public Store(string idStore, string storeName, string storeAddress, string phoneNumberofStore)
        {
            this.IDStore = idStore;
            this.StoreName = storeName;
            this.StoreAddress = storeAddress;
            this.PhoneNumberofStore = phoneNumberofStore;

        }

        //destructors
        ~Store()
        {

        }

        //method
        public void PrintInformStore()
        {
            Console.WriteLine("The information of Store:");
            Console.WriteLine("ID of Store:            " + this.sIDStore);
            Console.WriteLine("Name of Store:          " + this.sStoreName);
            Console.WriteLine("Phone Number of Store:  " + this.sPhoneNumberofStore);

        }


        //edit form
        public override string ToString()
        => $"{string.Join(",", sIDStore)}{string.Join(",", sStoreName),20}{string.Join(",", sStoreAddress),20}{string.Join(",", sPhoneNumberofStore),20}";
    }
}
