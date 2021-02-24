using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Configuration;
using System.Data.SqlClient;

namespace DAOLayerr
{
    public class CustomerDAO
    {
        private SqlConnection dbConnection;

        public CustomerDAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["UILayer.Properties.Settings.APP"].ConnectionString;
            dbConnection = new SqlConnection(connstring);
        }
        public List<Customer> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers ", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer temp = ReadCustomer(reader);
                customers.Add(temp);
            }
            reader.Close();
            dbConnection.Close();
            return customers;
        }
        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string email = (string)reader["EmailAddress"];
            Customer temp = new Customer(id, firstName, lastName, email);
            return temp;
        }

        public Customer GetByID(int customerId)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE Id = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", customerId); /*ask to teacher about this line */

            SqlDataReader reader = cmd.ExecuteReader();
            Customer temp = null;
            if (reader.Read())
            {
                temp = ReadCustomer(reader);
            }
            reader.Close();
            dbConnection.Close();
            return temp;

        }
    }
}
