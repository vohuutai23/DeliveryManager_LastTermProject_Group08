using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Receipt
    {
        public string sIDReceipt;
        public string sDateCreated;
        public double dDeliveryFree;

        public string IDReceipt
        {
            get { return this.sIDReceipt; }
            set { this.sIDReceipt = value; }
        }
        public string DateCreated
        {
            get { return this.sDateCreated; }
            set { this.sDateCreated = value; }
        }
        public double DeliveryFree
        {
            get { return this.dDeliveryFree; }
            set { this.dDeliveryFree = value; }
        }

        public Receipt()
        {

        }
        public Receipt(string idReceipt, string dateCreated, double deliveryFree)
        {
            this.sIDReceipt = idReceipt;
            this.sDateCreated = dateCreated;
            this.dDeliveryFree = deliveryFree;
        }
        ~Receipt()
        {

        }

        //edit form
        public override string ToString()
       => $"{string.Join(",", sIDReceipt)}{string.Join(",", sDateCreated),20}{dDeliveryFree,20}";
    }
}
