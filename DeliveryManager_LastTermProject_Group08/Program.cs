using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Program
    {
        public static List<Store> lStore = new List<Store>();
        public static List<Electronic> lElectronic = new List<Electronic>();
        public static List<Fashion> lFashion = new List<Fashion>();
        public static List<Food> lFood = new List<Food>();
        public static List<Cosmetic> lCosmetic = new List<Cosmetic>();
        public static List<Houseware> lHouseware = new List<Houseware>();

        public static List<Order> lOrder = new List<Order>();
        public static List<OrderDetails> lOrderDetails = new List<OrderDetails>();
        public static List<WareHouseManagement> lWareHouseManagement = new List<WareHouseManagement>();
        public static List<Shipper> lShipper = new List<Shipper>();
        public static List<SortingEmployee> lSortingEmployee = new List<SortingEmployee>();
        public static List<ShippingInformationofTheOrder> lShippingInf = new List<ShippingInformationofTheOrder>();
        public static List<Receipt> lReceipt = new List<Receipt>();
        public static List<ReceiptDetails> lReceiptDetails = new List<ReceiptDetails>();

        public static List<Customer> lCustomer = new List<Customer>();


        public static void CreListStore()
        {
            lStore.Add(new Store("ST01", "StoreA", "StoreAddressA", "91111"));
            lStore.Add(new Store("ST02", "StoreB", "StoreAddressB", "91112"));
            lStore.Add(new Store("ST03", "StoreC", "StoreAddressC", "91113"));
            lStore.Add(new Store("ST04", "StoreD", "StoreAddressD", "91114"));
            lStore.Add(new Store("ST05", "StoreE", "StoreAddressE", "91115"));
            lStore.Add(new Store("ST06", "StoreF", "StoreAddressF", "91116"));
            lStore.Add(new Store("ST07", "StoreG", "StoreAddressG", "91117"));
            lStore.Add(new Store("ST08", "StoreH", "StoreAddressH", "91118"));
            lStore.Add(new Store("ST09", "StoreI", "StoreAddressI", "91119"));
            lStore.Add(new Store("ST10", "StoreK", "StoreAddressK", "91120"));
        }

        public static void CreListElectronic()
        {
            lElectronic.Add(new Electronic(0.1, "ItemColour1", "PD04", "Electronic2", "Origin4", 4000, 1.4, "ST04"));
            lElectronic.Add(new Electronic(0.2, "ItemColour2", "PD12", "Electric12", "Origin12", 12000, 2.2, "ST01"));
            lElectronic.Add(new Electronic(0.3, "ItemColour3", "PD01", "Electronic1", "Origin1", 1000, 1.1, "ST01"));
            lElectronic.Add(new Electronic(0.4, "ItemColour4", "PD13", "Electronic13", "Origin13", 13000, 2.3, "St04"));
        }
        public static void CreListFashion()
        {
            lFashion.Add(new Fashion(29, "ItemFashionColor1", "PD21", "Fashion21", "Origin21", 21000, 2.2, "ST08"));
            lFashion.Add(new Fashion(30, "ItemFashionColor2", "PD21", "Fashion08", "Origin08", 8000, 1.8, "ST08"));
            lFashion.Add(new Fashion(31, "ItemFashionColor3", "PD21", "Fashion02", "Origin02", 2000, 1.2, "ST02"));
            lFashion.Add(new Fashion(32, "ItemFashionColor4", "PD21", "Fashion10", "Origin10", 10000, 2.0, "ST10"));
        }
        public static void CreListFood()
        {
            lFood.Add(new Food("1/1/2022", "1/1/2023", "PD98", "Food98", "Origin98", 98000, 9.8, "ST06"));
            lFood.Add(new Food("2/1/2022", "2/1/2023", "PD03", "Food03", "Origin03", 3000, 0.3, "ST03"));
            lFood.Add(new Food("3/1/2022", "3/1/2023", "PD99", "Food99", "Origin99", 99000, 9.9, "ST03"));
            lFood.Add(new Food("4/1/2022", "4/1/2023", "PD06", "Food06", "Origin06", 6000, 0.6, "ST06"));
        }
        public static void CreListCosmetic()
        {
            lCosmetic.Add(new Cosmetic("1/2/2022", "1/2/2023", "PD90", "Cosmetic90", "Origin90", 90000, 9.0, "ST05"));
            lCosmetic.Add(new Cosmetic("2/2/2022", "2/2/2023", "PD05", "Cosmetic05", "Origin05", 5000, 0.5, "ST05"));
            lCosmetic.Add(new Cosmetic("3/2/2022", "3/2/2023", "PD91", "Cosmetic91", "Origin91", 91000, 9.1, "ST05"));
            lCosmetic.Add(new Cosmetic("4/2/2022", "4/2/2023", "PD92", "Cosmetic92", "Origin92", 92000, 9.2, "ST05"));
        }
        public static void CreListHouseWare()
        {
            lHouseware.Add(new Houseware("Material1", "PD07", "Houseware07", "Origin07", 7000, 0.7, "ST07"));
            lHouseware.Add(new Houseware("Material2", "PD95", "Houseware95", "Origin95", 95000, 9.5, "ST07"));
            lHouseware.Add(new Houseware("Material3", "PD09", "Houseware09", "Origin09", 9000, 0.9, "ST09"));
        }
        public static void CreListOrder()
        {
            lOrder.Add(new Order("ORD01", "DeliveryAddressA", 1, "cash", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD02", "DeliveryAddressB", 2, "cash", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD03", "DeliveryAddressC", 4, "cash", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD04", "DeliveryAddressD", 2, "bank", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD05", "DeliveryAddressE", 4, "cash", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD06", "DeliveryAddressF", 1, "bank", "COD", "12-12-2022"));
            lOrder.Add(new Order("ORD07", "DeliveryAddressG", 3, "bank", "COD", "12-12-2022"));

        }

        public static void CreListOrderDetails()
        {
            lOrderDetails.Add(new OrderDetails(lElectronic[1].Price * lOrder[2].AmountofOrder, lOrder[2], lElectronic[1], "WH01"));
            lOrderDetails.Add(new OrderDetails(lElectronic[2].Price * lOrder[5].AmountofOrder, lOrder[5], lElectronic[2], "WH01"));
            lOrderDetails.Add(new OrderDetails(lFashion[1].Price * lOrder[1].AmountofOrder, lOrder[1], lFashion[1], "WH01"));
            lOrderDetails.Add(new OrderDetails(lCosmetic[1].Price * lOrder[4].AmountofOrder, lOrder[4], lCosmetic[1], "WH01"));
            lOrderDetails.Add(new OrderDetails(lFood[1].Price * lOrder[0].AmountofOrder, lOrder[0], lFood[1], "WH01"));
            lOrderDetails.Add(new OrderDetails(lFashion[2].Price * lOrder[6].AmountofOrder, lOrder[6], lFashion[2], "WH01"));
            lOrderDetails.Add(new OrderDetails(lElectronic[0].Price * lOrder[3].AmountofOrder, lOrder[3], lElectronic[0], "WH01"));

        }

        public static void CreListWareHouseManagement()
        {
            lWareHouseManagement.Add(new WareHouseManagement("WH01", "Shopee Express", "WarehouseAddressA", 7));
            lWareHouseManagement.Add(new WareHouseManagement("WH02", "Shopee Express", "WarehouseAddressC", 7));
            lWareHouseManagement.Add(new WareHouseManagement("WH03", "Shopee Express", "WarehouseAddressE", 5));
            lWareHouseManagement.Add(new WareHouseManagement("WH04", "Ninja Van", "WarehouseAddressB", 6));
            lWareHouseManagement.Add(new WareHouseManagement("WH05", "J&T Express", "WarehouseAddressC", 6));

        }
        public static void CreListShipper()
        {
            lShipper.Add(new Shipper(0, "EM01", "Shipper A", 7000000, "09613635380"));
            lShipper.Add(new Shipper(0, "EM02", "Shipper B", 8000000, "09613635381"));
            lShipper.Add(new Shipper(0, "EM03", "Shipper C", 7000000, "09613635382"));
            lShipper.Add(new Shipper(0, "EM04", "Shipper D", 7000000, "09613635383"));
            lShipper.Add(new Shipper(0, "EM05", "Shipper E", 8000000, "09613635384"));
            lShipper.Add(new Shipper(0, "EM06", "Shipper F", 8000000, "09613635385"));
            lShipper.Add(new Shipper(0, "EM07", "Shipper G", 7000000, "09613635386"));
            lShipper.Add(new Shipper(0, "EM08", "Shipper H", 7000000, "09613635387"));

        }
        public static void CreListSortingEmployee()
        {
            lSortingEmployee.Add(new SortingEmployee(8, "EM09", "SortingEmployee A", 7000000, "0962904410"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM10", "SortingEmployee B", 7000000, "0962904411"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM11", "SortingEmployee C", 8000000, "0962904412"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM12", "SortingEmployee D", 7000000, "0962904413"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM13", "SortingEmployee E", 8000000, "0962904414"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM14", "SortingEmployee F", 7000000, "0962904415"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM15", "SortingEmployee G", 8000000, "0962904416"));
            lSortingEmployee.Add(new SortingEmployee(8, "EM16", "SortingEmployee H", 7000000, "0962904417"));

        }

        public static void CreListShippingInformationofTheOrder()
        {
            lShippingInf.Add(new ShippingInformationofTheOrder("being transported", lOrder[0], lShipper[0]));
            lShippingInf.Add(new ShippingInformationofTheOrder("being transported", lOrder[1], lShipper[1]));
            lShippingInf.Add(new ShippingInformationofTheOrder("delivered", lOrder[2], lShipper[2]));
            lShippingInf.Add(new ShippingInformationofTheOrder("being transported", lOrder[3], lShipper[0]));
            lShippingInf.Add(new ShippingInformationofTheOrder("delivered", lOrder[4], lShipper[0]));
            lShippingInf.Add(new ShippingInformationofTheOrder("being transported", lOrder[5], lShipper[2]));
            lShippingInf.Add(new ShippingInformationofTheOrder("delivered", lOrder[6], lShipper[3]));
        }
        public static void CreListReceipt()
        {
            lReceipt.Add(new Receipt("REC01", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC02", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC03", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC04", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC05", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC06", "15-12-2022", 20000));
            lReceipt.Add(new Receipt("REC07", "15-12-2022", 20000));
        }

        public static void CreListReceiptDetails()
        {
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[0], lCustomer[0], lReceipt[0]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[1], lCustomer[1], lReceipt[1]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[2], lCustomer[0], lReceipt[2]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[3], lCustomer[2], lReceipt[3]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[4], lCustomer[2], lReceipt[4]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[5], lCustomer[3], lReceipt[5]));
            lReceiptDetails.Add(new ReceiptDetails(lOrderDetails[6], lCustomer[2], lReceipt[6]));
        }

        public static void CreListCustomer()
        {
            lCustomer.Add(new Customer("CT01", "Nguyen Van A", "Quang Ngai", "0123456789"));
            lCustomer.Add(new Customer("CT02", "Nguyen Van B", "Binh Dinh", "0123456788"));
            lCustomer.Add(new Customer("CT03", "Nguyen Van C", "Phu Yen", "0123456787"));
            lCustomer.Add(new Customer("CT04", "Nguyen Van D", "Khanh Hoa", "0123456786"));
            lCustomer.Add(new Customer("CT05", "Nguyen Van A", "TP.HCM", "0123456785"));
        }


        //---------------------------------------------------------------------------------------------------------

        //Selection 1: Display information for each item of Product
        public static void Selection1()
        {
            int c;

            Console.WriteLine("Select one option below to check: ");
            Console.WriteLine("1.Electronic");
            Console.WriteLine("2.Fashion");
            Console.WriteLine("3.Food");
            Console.WriteLine("4.Cosmetic");
            Console.WriteLine("5.Houseware");
            Console.Write("Please enter your choice :");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine("Storage  ItemColour        IDProduct     ProductName      Origin           Price           Mas           IDStore");
                        Console.WriteLine();
                        var dsMH = from mh in lElectronic
                                   select mh;
                        foreach (var mh in dsMH)
                            Console.WriteLine(mh);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Size ItemFashionColour     IDProduct  ProductName     Origin            Price            Mas          IDStore");
                        Console.WriteLine();
                        var dsMH = from mh in lFashion
                                   select mh;
                        foreach (var mh in dsMH)
                            Console.WriteLine(mh);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("DateofManufacture ExpirationDate IDProduct   ProductName    Origin            Price            Mas          IDStore");
                        Console.WriteLine();
                        var dsMH = from mh in lFood
                                   select mh;
                        foreach (var mh in dsMH)
                            Console.WriteLine(mh);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("DateofManufacture ExpirationDate IDProduct   ProductName    Origin            Price            Mas          IDStore");
                        Console.WriteLine();
                        var dsMH = from mh in lCosmetic
                                   select mh;
                        foreach (var mh in dsMH)
                            Console.WriteLine(mh);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Material     IDProduct      ProductName           Origin          Price            Mas          IDStore");
                        Console.WriteLine();
                        var dsMH = from mh in lHouseware
                                   select mh;
                        foreach (var mh in dsMH)
                            Console.WriteLine(mh);
                    }
                    break;
            }
        }

        //Selection 2: Display list of stores where the product is shipped
        public static void Selection2()
        {
            Console.WriteLine("List of stores where the product is shipped: ");

            var dsCH =
                       from ch in lOrderDetails
                       from ch2 in lStore
                       where ch.pProduct.IDStore == ch2.IDStore
                       select ch2.IDStore;
            var DSCH = dsCH.Distinct();
            foreach (var ch in DSCH)
            {
                foreach (var name in lStore)
                {
                    if (ch == name.IDStore)
                        Console.WriteLine("ID STORE: " + ch + "-- Name STORE: " + name.sStoreName);
                }

            }
        }


        //Selection3: Check the characteristics of order
        public static void Selection3()
        {
            Console.WriteLine("What type of Product do you want to check the characteristic?");
            Console.WriteLine("1. Electronic");
            Console.WriteLine("2. Fashion");
            Console.WriteLine("3. Food");
            Console.WriteLine("4. Cosmetic");
            Console.WriteLine("5. Houseware");
            Console.WriteLine();
            Console.WriteLine("Please choose one option to check:");
            int select;
            select = Convert.ToInt32(Console.ReadLine());
            Product el = new Electronic();
            Product fa = new Fashion();
            Product fo = new Food();
            Product co = new Cosmetic();
            Product ho = new Houseware();
            switch (select)
            {
                case 1: el.ShowCharacteristics(); break;
                case 2: fa.ShowCharacteristics(); break;
                case 3: fo.ShowCharacteristics(); break;
                case 4: co.ShowCharacteristics(); break;
                case 5: ho.ShowCharacteristics(); break;
            }

        }

        //Selection 4: Display list of orders and look up Order through IDOrder
        public static void Selection4()
        {
            Console.WriteLine("List ID Order: ");
            foreach (var a in lOrder)
            {
                Console.Write("--" + a.IDOrder + "--");
            }
            Console.WriteLine();
            string str;
            Console.WriteLine("Please enter ID Order to check:");
            str = Console.ReadLine();
            var timkiem = from p in lOrder
                          select p;
            int dem = 0;
            foreach (var x in timkiem)
            {
                if (x.sIDOrder == str)
                {
                    Console.WriteLine(x);
                    dem++;
                    break;
                }

            }
            if (dem == 0)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                int c;
                Console.WriteLine("Do you want to check details of order?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Console.Write("Please choose one option:");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            foreach (var a in lOrderDetails)
                                if (str == a.oOrder.IDOrder)
                                {
                                    Console.WriteLine("-----------------------------");
                                    Console.WriteLine("ID Order: " + a.oOrder.IDOrder);
                                    Console.WriteLine("Product Name: " + a.Product.ProductName);
                                    Console.WriteLine("Amount of Product: " + a.oOrder.iAmountofOrder);
                                    Console.WriteLine("Price of Product: " + a.Product.Price);
                                    Console.WriteLine("Price of Order: " + a.OrderPrice);
                                    Console.WriteLine("Delivery Address: " + a.Order.sDeliveryAddress);
                                    Console.WriteLine("Payment method:" + a.Order.sPayment);
                                    Console.WriteLine("Order creation date: " + a.Order.OrderDate);
                                    Console.WriteLine("ID warehouse: " + a.IDWarehouse);
                                    Console.WriteLine("------------------------------");
                                }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Press any button to return menu!");
                        }
                        break;
                }


            }
        }

        //Selection 5: Display the names of the deliver company and the total number of employee company's
        public static void Selection5()
        {
            Console.WriteLine("List of delivery companies: ");
            var dsDVGH = from gh in lWareHouseManagement
                         select gh;
            foreach (var gh in dsDVGH)
                Console.WriteLine("Ten: " + gh.sWarehouseName + " - SLNV: " + gh.TotalEmployee);
        }

        //Operator OverLoading
        //Selection 6: Compare two delivery companies 
        public static void Selection6()
        {
            WareHouseManagement x = new WareHouseManagement();
            WareHouseManagement y = new WareHouseManagement();
            int a, b;
            Console.WriteLine("Please enter number index you want to compare name company's:");
            Console.WriteLine("List of company:");
            for (int i = 0; i < lWareHouseManagement.Count; i++)
            {
                Console.WriteLine(i + 1 + " ID: " + lWareHouseManagement[i].IDWarehouse);
            }
            Console.WriteLine("The first:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second:");
            b = Convert.ToInt32(Console.ReadLine());
            if ((a > lWareHouseManagement.Count) || (b > lWareHouseManagement.Count))
            {
                Console.WriteLine("a and b are not correct");
            }
            else
            {
                x = lWareHouseManagement[a];
                y = lWareHouseManagement[b];
                if (x == y)
                {
                    Console.WriteLine(x.sWarehouseName);
                    Console.WriteLine();
                    Console.WriteLine("-->Same delivery company!");
                }

                if (x != y)
                {
                    Console.WriteLine("First: " + x.sWarehouseName);
                    Console.WriteLine("Second: " + y.sWarehouseName);
                    Console.WriteLine();
                    Console.WriteLine("--> Diferent delivery company!");
                }
            }
        }

        //Selection 7: Displays the total number of orders delivered and the total number of orders demaining in stock
        public static void Selection7()
        {
            var ctDH = from dh in lShippingInf
                       where dh.OrderStatus == "delivered"
                       select dh;
            int soDonHang = lShippingInf.Count();
            int soDonHangDagiao = ctDH.Count();
            int soDonHangConLai = soDonHang - soDonHangDagiao;
            Console.Write("Total orders: " + soDonHang + "\n");

            Console.Write("Total orders deliveried: " + soDonHangDagiao + "\n");
            Console.Write("Total orders demaining: " + soDonHangConLai + "\n");
        }


        //Selection 8: Check information of employees (profile, salary,...)
        public static void Selection8()
        {
            Console.WriteLine("What type of employee do you want to check information?");
            Console.WriteLine("1.Shipper");
            Console.WriteLine("2.Sorting employee");
            int select;
            select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                var sp = from p in lShipper
                         select p;
                foreach (var x in sp)
                {
                    Console.WriteLine(x);
                }
            }
            if (select == 2)
            {
                var se = from p in lSortingEmployee
                         select p;
                foreach (var x in se)
                {
                    Console.WriteLine(x);
                }
            }
        }

        //Selection 9: Arrange salary of employees
        public static void Part1_9()
        {
            int c;
            Console.WriteLine();
            Console.WriteLine("Do you want to check salary is increasing or decreasing?: ");
            Console.WriteLine("1.Decreasing");
            Console.WriteLine("2.Increasing");
            Console.Write("Please choose one option:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Job information of shipper after being sorted: ");

            switch (c)
            {
                case 1:
                    {

                        var kq = from nv in lShipper
                                 orderby nv.Salary() descending
                                 select nv;
                        foreach (var nv in kq)
                            nv.PrintInformEmployee();
                    }
                    break;
                case 2:
                    {

                        var kq = from nv in lShipper
                                 orderby nv.Salary() ascending
                                 select nv;
                        foreach (var nv in kq)
                            nv.PrintInformEmployee();
                    }
                    break;
            }

            var luongMax = lShipper.Max(x => x.Salary());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("The shipper with the highest salary is : ");
            foreach (var nv in lShipper)
            {
                if (nv.Salary() == luongMax)
                {
                    Console.WriteLine("ID Shipper: " + nv.sIDEmployee + " ---- Name: " + nv.sEmployeeName);
                    Console.WriteLine("------------------------------------------------");
                }

            }
        }
        public static void Part2_9()
        {
            int c;
            Console.WriteLine();
            Console.WriteLine("Do you want to check salary is increasing or decreasing? ");
            Console.WriteLine("1.Decreasing");
            Console.WriteLine("2.Increasing");
            Console.Write("Please choose one option:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Job information of sorting employee after being sorted: ");
            Console.WriteLine();
            switch (c)
            {
                case 1:
                    {

                        var kq = from nv in lSortingEmployee
                                 orderby nv.Salary() descending
                                 select nv;
                        foreach (var nv in kq)
                            nv.PrintInformEmployee();
                    }
                    break;
                case 2:
                    {

                        var kq = from nv in lSortingEmployee
                                 orderby nv.Salary() ascending
                                 select nv;
                        foreach (var nv in kq)
                            nv.PrintInformEmployee();
                    }
                    break;
            }

            var luongMax = lSortingEmployee.Max(x => x.Salary());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("The sorting employee with the highest salary is: ");
            Console.WriteLine();
            foreach (var nv in lSortingEmployee)
            {
                if (nv.Salary() == luongMax)
                {
                    Console.WriteLine("ID Employee: " + nv.sIDEmployee + " ---- Name: " + nv.sEmployeeName);
                    Console.WriteLine("------------------------------------------------");
                }

            }
        }
        public static void duyetDonHang()
        {
            foreach (var a in lShippingInf)
                a.xuly();
        }

        public static void Selection9()
        {
            int c;
            Console.WriteLine("What type of salary employee do you want to check? ");

            Console.WriteLine("1.Shipper");
            Console.WriteLine("2.Sorting Employee");
            Console.Write("Please choose one option:");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Part1_9();
                    break;
                case 2:
                    Part2_9();
                    break;
            }

        }


        //Selection 10: Look up order information
        public static void Selection10()
        {

            var timkiem = from p in lReceipt
                          select p;
            foreach (var x in timkiem)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            int dem = 0;
            string str;
            Console.WriteLine("Please enter your IDReceipt to check:");
            str = Console.ReadLine();
            foreach (var x in timkiem)
            {
                if (x.sIDReceipt == str)
                {
                    Console.WriteLine(x);
                    dem++;
                    break;

                }

            }
            if (dem == 0)
            {
                Console.WriteLine("Not Found!");
            }

        }

        //Selection 11: Display list of customers and look up customer through IDCustomer or NumberPhone of Customer
        public static void Selection11()
        {
            var dsKH = from p in lCustomer
                       select p;
            foreach (var x in dsKH)
            {
                Console.WriteLine(x);
            }

            string str;
            Console.WriteLine("Please enter your IDCustomer or NumberPhone to look up information: ");
            str = Console.ReadLine();
            int dem = 0;
            foreach (var x in dsKH)
            {
                if (str == x.sIDCustomer || str == x.sCustomerPhoneNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine(x);
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Not Found!");
            }

        }

        //Selection12: Look up and display all inform of OrderDetails, Customer and Receipt 
        public static void Selection12()
        {
            string str;
            Console.WriteLine("Please enter your IDOrder or IDCustomer to check:");
            str = Console.ReadLine();

            var inform = from p in lReceiptDetails
                         select p;
            int dem = 0;
            foreach (var x in inform)
            {
                if (str == x.oOrderDetails.oOrder.sIDOrder || str == x.cCustomer.sIDCustomer)
                {
                    Console.WriteLine();
                    Console.WriteLine(x.cCustomer);
                    Console.WriteLine(x.oOrderDetails.pProduct);
                    Console.WriteLine(x.rReceipt);
                    Console.WriteLine(x.oOrderDetails.oOrder);
                    Console.WriteLine();
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Not found!");
            }
        }

        //Selection 13: Directly check information of employee through EmployeeName
        public static void Selection13()
        {
            string str;
            Console.WriteLine("Please enter the employee name you want to check:");
            str = Console.ReadLine();
            int dem = 0;
            foreach (var a in lShipper)
            {
                a.iSearch = 0;
                a.Search(str);
                if (a.iSearch != 0)
                    dem++;
            }
            foreach (var a in lSortingEmployee)
            {
                a.iSearch = 0;
                a.Search(str);
                if (a.iSearch != 0)
                    dem++;
            }
            if (dem == 0)
                Console.WriteLine("Not found the employee name in list!");
        }

        //Selection 14: Directly check information of customer through CustomerName
        public static void Selection14()
        {
            string str;
            Console.WriteLine("Please enter the customer name you want to check:");
            str = Console.ReadLine();
            int dem = 0;
            foreach (var a in lCustomer)
            {
                a.demten = 0;
                a.Search(str);
                if (a.demten != 0)
                    dem++;
            }
            if (dem == 0)
                Console.WriteLine("Not found the customer name in list!");
        }



        //Selection 15: User can create a receipt and add it into list receipt
        public static void Selection15()
        {
            foreach (var y in lReceipt)
            {
                Console.WriteLine(y);

            }
            Console.WriteLine();
            Console.WriteLine("Please user enter full the information below!");
            Console.WriteLine("Please enter ID receipt:");
            string id;
            id = Console.ReadLine();
            Console.WriteLine("Please enter create date:");
            string day;
            day = Console.ReadLine();
            Console.WriteLine("Please enter receipt fee:");
            double price;
            price = Convert.ToDouble(Console.ReadLine());
            Receipt rc = new Receipt(id, day, price);
            lReceipt.Add(rc);
            Console.WriteLine();
            Console.WriteLine("Full list receipt after updated:");
            foreach (var x in lReceipt)
            {
                Console.WriteLine(x);
            }
        }

        //Selection 16: User can remove a receipt from list 
        public static void Selection16()
        {
            foreach (var n in lReceipt)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Please enter index number which you want to remove from list:");
            int index;
            index = Convert.ToInt32(Console.ReadLine());
            lReceipt.RemoveAt(index);
            Console.WriteLine("List receipt after updated:");
            foreach (var x in lReceipt)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                CreListCustomer();
                CreListStore();
                CreListElectronic();
                CreListFashion();
                CreListFood();
                CreListCosmetic();
                CreListOrder();
                CreListHouseWare();
                CreListOrderDetails();
                CreListWareHouseManagement();
                CreListShipper();
                CreListSortingEmployee();
                CreListShippingInformationofTheOrder();
                CreListReceipt();
                CreListReceiptDetails();
                duyetDonHang();

                int select;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------WELCOME TO DELIVERY MANAGER MENU OF GROUP 08--------------------");
                    Console.WriteLine();
                    Console.WriteLine("Selection 1:  Display information for each item of Product.");
                    Console.WriteLine("Selection 2:  Display list of stores where the product is shipped.");
                    Console.WriteLine("Selection 3:  Check the characteristics of order.");
                    Console.WriteLine("Selection 4:  Display list of orders and look up Order through IDOrder");
                    Console.WriteLine("Selection 5:  Display the names of the delivery company and the total number of employee company's ");
                    Console.WriteLine("Selection 6:  Compare two delivery companies");
                    Console.WriteLine("Selection 7:  Display the total number of orders delivered and the total number of orders demaining in stock");
                    Console.WriteLine("Selection 8:  Check information of employees through list");
                    Console.WriteLine("Selection 9:  Arrange salary of employees");
                    Console.WriteLine("Selection 10: Look up receipt information");
                    Console.WriteLine("Selection 11: Display list of customers and look up customer through IDCustomer or NumberPhone of Customer");
                    Console.WriteLine("Selection 12: Look up and display all inform of OrderDetails, Customer and Receipt ");
                    Console.WriteLine("Selection 13: Directly check information of employee through EmployeeName");
                    Console.WriteLine("Selection 14: Directly check information of customer through CustomerName");
                    Console.WriteLine("Selection 15: User can create a receipt and add it into list receipt");
                    Console.WriteLine("Selection 16: User can remove a receipt from list ");
                    Console.WriteLine("Selection 0:  Exit program!");
                    Console.WriteLine();
                    Console.WriteLine("*****And press any button to return the menu!*****");
                    Console.WriteLine("----------------------------------------------------------------");
                    do
                    {
                        Console.WriteLine("Please select one option (from 0 to 16) from the keyboard to check:");
                        select = Convert.ToInt32(Console.ReadLine());
                    } while (select < 0 || select > 16);

                    Console.WriteLine();

                    switch (select)
                    {
                        case 1: Selection1(); break;
                        case 2: Selection2(); break;
                        case 3: Selection3(); break;
                        case 4: Selection4(); break;
                        case 5: Selection5(); break;
                        case 6: Selection6(); break;
                        case 7: Selection7(); break;
                        case 8: Selection8(); break;
                        case 9: Selection9(); break;
                        case 10: Selection10(); break;
                        case 11: Selection11(); break;
                        case 12: Selection12(); break;
                        case 13: Selection13(); break;
                        case 14: Selection14(); break;
                        case 15: Selection15(); break;
                        case 16: Selection16(); break;
                        case 0: System.Environment.Exit(0); break;
                    }
                    if (select >= 0 && select <= 16)
                    {
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (select >= 0 && select <= 16);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!" + e);
            }
            Console.ReadKey();
        }
    }
}
