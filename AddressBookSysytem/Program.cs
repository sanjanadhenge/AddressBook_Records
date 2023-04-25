using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysytem
{
    internal class Program
    {
      public static void Main(string[] args)
        {
            Operation operation = new Operation();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select an Option \n 1.Get Records \n 2.Add Data \n 3.Delete Data \n 4.Update Data Data \n 5.Data Within given time \n 6.Retrive data by city or state \n 7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    
                    case 1:
                        operation.GetAllRecords();
                        break;
                    case 2:
                        Contacts contact = new Contacts();
                        {
                            contact.FirstName = "Sambhav";
                            contact.LastName = "Dhenge";
                            contact.Address = "1461 A ward";
                            contact.City = "Kolhapur";
                            contact.State = "MH";
                            contact.zip = "416012";
                            contact.PhoneNumber = "99754865";
                            contact.Email = "abc@gmail.com";

                        }
                        operation.AddEmployee(contact);
                        break;
                    case 3:
                        operation.DeleteData(11);
                        break;
                    case 4:
                        //UC17
                        operation.UpdateData(1, "Sanjana@gmail.com");
                        break;
                    case 5:
                        Console.WriteLine("Enter start date");
                        DateTime fromDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter End date");
                        DateTime ToDate = DateTime.Parse(Console.ReadLine());
                        operation.GetDataWithinTimePeriod(fromDate, ToDate);
                        break;
                    case 6:
                        bool f = true;
                        while (f)
                        {
                            Console.WriteLine("Select option \n 1.Search by city \n 2.Search by state \n 3.exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {

                                case 1:
                                    Console.WriteLine("Enter City");
                                    string city = Console.ReadLine();
                                    operation.RetriveDataByCity(city);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter State");
                                    string State = Console.ReadLine();
                                    operation.RetriveDataByCity(State);
                                    break;
                                case 3:
                                    f = false;
                                    break;
                            }
                            
                        }
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }


        }
    }
}
