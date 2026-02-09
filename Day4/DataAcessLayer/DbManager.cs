using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class DbManager
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public DbManager()
        {
            string connectionStr = "Server = NDA; Database = pubs; Integrated Security = true; Encrypt = false;";

            sqlConnection = new SqlConnection(connectionStr);
            sqlCommand = new SqlCommand("", sqlConnection);

        }


        public int ExecuteNonQuery(string sqlStatement) //related to insert update delete
        {
            sqlCommand.CommandText = sqlStatement;
            if(sqlConnection.State is not ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            sqlCommand.CommandType = CommandType.Text;

            int RowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return RowEffected;

        }


        public DataTable GetAll() //get and fetch using select
        {
            string sqlQuery = "select * from authors";
             sqlCommand.CommandText = sqlQuery;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();

            sqlDataAdapter.Fill(table);
            return table;

        }

        public int InsertAuthor(Author author)
        {

            string sqlStatement = "insert into authors (au_id,au_fname,au_lname,address,city,state,zip,phone,contract) values (@au_id,@au_fname,@au_lname,@address,@city,@state,@zip,@phone,@contract)";
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();

            sqlCommand.CommandType= CommandType.Text;
            sqlCommand.CommandText= sqlStatement;
            sqlCommand.Parameters.AddWithValue("@au_id", author.Id);
            sqlCommand.Parameters.AddWithValue("@au_fname", author.FirstName);
            sqlCommand.Parameters.AddWithValue("@au_lname", author.LastName);
            sqlCommand.Parameters.AddWithValue("@address", author.Address);
            sqlCommand.Parameters.AddWithValue("@city", author.City);
            sqlCommand.Parameters.AddWithValue("@state", author.State);
            sqlCommand.Parameters.AddWithValue("@zip", author.ZIP);
            sqlCommand.Parameters.AddWithValue("@phone", author.Phone);
            sqlCommand.Parameters.AddWithValue("@contract", author.ActiveContract);
            int rows = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return rows;


        }
        public int DeleteAuthor(string au_id)
        {
            int rowsAffected = ExecuteNonQuery($"delete from authors where au_id = '{au_id}'");

            return rowsAffected;
        }


        public List<Author> GetAuthorList()
        {
            DataTable dt = GetAll();

            List<Author> list = new List<Author>();

            foreach (DataRow dr in dt.Rows)
            {
                Author author = new Author();

                author.Id = dr["au_id"].ToString()!;
                author.FirstName = dr["au_fname"].ToString()!;
                author.LastName = dr["au_lname"].ToString()!;
                author.Address = dr["address"].ToString();
                author.City = dr["city"].ToString();
                author.State = dr["state"].ToString();
                author.ZIP = dr["zip"].ToString();
                author.Phone = dr["phone"].ToString();
                author.ActiveContract = dr.Field<bool>("contract");
                list.Add(author);
            }

            return list;
        }
    }
}
