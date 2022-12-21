using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class WareHouseManagement
    {
        //fields
        private string sIDWarehouse;
        public string sWarehouseName;
        private string sWarehouseAddress;
        public int iTotalEmployee;

        //properties
        public string IDWarehouse
        {
            get { return this.sIDWarehouse; }
            set { this.sIDWarehouse = value; }
        }
        public string WarehouseName
        {
            get { return this.sWarehouseName; }
            set { this.sWarehouseName = value; }
        }
        public string WarehouseAddress
        {
            get { return this.sWarehouseAddress; }
            set { this.sWarehouseAddress = value; }
        }
        public int TotalEmployee
        {
            get { return this.iTotalEmployee; }
            set { this.iTotalEmployee = value; }
        }

        //constructors
        public WareHouseManagement()
        {

        }
        public WareHouseManagement(string idWarehouse, string warehouseName, string warehouseAddress, int totalEmployee)
        {
            this.sIDWarehouse = idWarehouse;
            this.sWarehouseName = warehouseName;
            this.sWarehouseAddress = warehouseAddress;
            this.iTotalEmployee = totalEmployee;
        }

        //destructors
        ~WareHouseManagement()
        {

        }

        public void PrintInformWarehouse()
        {
            Console.WriteLine("The information of Warehouse: ");
            Console.WriteLine("ID of Warehouse: " + this.sIDWarehouse);
            Console.WriteLine("Name of Warehouse: " + this.sWarehouseName);
            Console.WriteLine("Warehouse Address: " + this.sWarehouseAddress);
            Console.WriteLine("Total Employee: " + this.iTotalEmployee);
        }

        //operator overloading
        public static bool operator ==(WareHouseManagement a, WareHouseManagement b)
        {
            if (a.sWarehouseName == b.sWarehouseName)
                return true;
            return false;
        }

        public static bool operator !=(WareHouseManagement a, WareHouseManagement b)
        {
            if (a.sWarehouseName != b.sWarehouseName)
                return true;
            return false;
        }

        //edit form
        public override string ToString()
        => $"{string.Join(",", sIDWarehouse)}{string.Join(",", sWarehouseName),20}{string.Join(",", sWarehouseAddress),20}{iTotalEmployee,20}";
    }
}
