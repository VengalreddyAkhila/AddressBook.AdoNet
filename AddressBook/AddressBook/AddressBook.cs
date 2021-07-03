using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        readonly string connectionstring = "Data Source=.;Initial Catalog=AdressBook;Integrated Security=True";
        public void GetData()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                AddressDetails address = new AddressDetails();
                using (connection)
                {
                    string query = @"SELECT FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email
                                       FROM Addressbook";
                    //define the sqlcommand object
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //checking if there are records present
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            address.FirstName = dr[0] != null ? dr.GetString(1) : "Akhila";
                            address.LastName = dr[1] != null ? dr.GetString(1) : "Akhila";
                            address.Address = dr[2] != null ? dr.GetString(1) : "Akhila";
                            address.City = dr[3] != null ? dr.GetString(1) : "Akhila";
                            address.State = dr[4] != null ? dr.GetString(1) : "Akhila";
                            address.ZipCode = dr[5] != null ? dr.GetString(1) : "Akhila";
                            address.PhoneNumber = dr[6] != null ? dr.GetString(1) : "Akhila";
                            address.Email = dr[7] != null ? dr.GetString(1) : "Akhila";
                            //address.type = dr.GetString(8);
                            //address.name = dr.GetString(9);
                            Console.WriteLine("{0},{1},{2},{3}",address.FirstName,address.LastName,address.Address,address.City);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("no data found");
                    }
                    //close data reader
                    dr.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }    
    }
}
