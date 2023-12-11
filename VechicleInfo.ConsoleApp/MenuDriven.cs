using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;


namespace VechicleInfo.ConsoleApp
{
    class MenuDriven
    {
        private IVehicleInfoRepository obj;

        public MenuDriven()
        {
            obj = new VehicleInfoRepository();
        }
        public void menu()
        {
            int option = 0;
            do

            
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Read");               
                Console.WriteLine("5.Exit");
                Console.WriteLine("Please enter your option");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        {
                            VehicleInfo VI = new VehicleInfo();
                            Console.WriteLine("Enter VehicleName");
                            VI.Name = Console.ReadLine();

                            Console.WriteLine("Enter VehicleNumber");
                            VI.VehicleNumber = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter RCNumber");
                            VI.RCNumber = Console.ReadLine();

                            Console.WriteLine("Enter OwnerPhNo");
                            VI.OwnerPhNo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter PurchaseDate ");
                            VI.PurchaseDate = DateTime.Today;
                        }

                        break;

                    case 2:
                        {
                            Console.WriteLine("Enter Id Number");
                            int V = Convert.ToInt32(Console.ReadLine());

                            VehicleInfo VI = new VehicleInfo();

                            Console.WriteLine("Enter VehicleName");
                            VI.Name = Console.ReadLine();

                            Console.WriteLine("Enter VehicleNumber");
                            VI.VehicleNumber = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter RCNumber");
                            VI.RCNumber = Console.ReadLine();

                            Console.WriteLine("Enter OwnerPhNo");
                            VI.OwnerPhNo = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("Enter PurchaseDate ");
                            VI.PurchaseDate = DateTime.Today;

                            obj.UpdateVehicleInfoSP(V, VI);
                        }

                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Id Number Which you want to delete");
                            int V = Convert.ToInt32(Console.ReadLine());

                            obj.DeleteVehicleInfoSP(V);
                            var rec = obj.GetVehicleInfoSP();
                            foreach (var O in rec)
                            {

                                Console.WriteLine($"{O.Id}   {O.Name}   {O.VehicleNumber}   {O.RCNumber}  {O.OwnerPhNo}   {O.PurchaseDate}");
                            }
                        }
                        break;
                       
                    case 4:
                        {
                            var rec = obj.GetVehicleInfoSP();
                            Console.WriteLine($"Id  Name   VehicleNumber  RCNumber OwnerPhNo  PurchaseDate");
                            foreach (var O in rec)
                            {

                                Console.WriteLine($"{O.Id}   {O.Name}   {O.VehicleNumber}   {O.RCNumber}  {O.OwnerPhNo}   {O.PurchaseDate}");
                            }
                        }
                        break;                 
                          
                    case 5:
                        {
                            break;
                        }
                        

                    default:
                        {
                            Console.WriteLine("Invalid Number");
                            break;


                        }

                }


            }while (5 != option) ;
           


        }
    }
}
    

    

