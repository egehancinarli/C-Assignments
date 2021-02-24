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
   public  class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["UILayer.Properties.Settings.APP"].ConnectionString;
            dbConnection = new SqlConnection(connstring);
        }
        public List<Book> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books ", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book temp = ReadBook(reader);
                books.Add(temp);
            }
            reader.Close();
            dbConnection.Close();
            return books;
        }
        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];
            return new Book(id,title,author);
          
        }

        public Book GetByID(int BookId)
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Id = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", BookId); /*ask to teacher about this line */

            SqlDataReader reader = cmd.ExecuteReader();
            Book temp = null;
            if (reader.Read())
            {
                temp = ReadBook(reader);
            }
            reader.Close();
            dbConnection.Close();
            return temp;

        }
    }
}

