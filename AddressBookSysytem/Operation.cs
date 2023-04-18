using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysytem
{
    internal class Operation
    {
        public static string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook_Servive_DB";
        SqlConnection connection = new SqlConnection(connectionstring);
        public void GetAllRecords()
        {

           Contacts contact = new Contacts();
            try
            {
                using (this.connection)
                {
                    string query = @"select * from  RecordsDB";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = System.Data.CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            contact.ID = read.GetInt32(0);
                            contact.FirstName = read.GetString(1);
                            contact.LastName = read.GetString(2);
                            contact.Address = read.GetString(3);
                            contact.City = read.GetString(4);
                            contact.State = read.GetString(5);
                            contact.zip = read.GetString(6);
                            contact.PhoneNumber = read.GetString(7);
                            contact.Email = read.GetString(8);

                            Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.zip + "\n" + contact.PhoneNumber + "\n" + contact.Email );
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Records avaible");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




        }
    }
}
