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
                Console.WriteLine("Select an Option \n 1.Get Records \n 2.Add Data \n 3.Delete Data \n 4.Update Data Data \n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //UC16
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
                       operation.UpdateData(1, "Sanjana@gmail.com");
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }


        }
    }
}
