using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using BusinessLayer.Models;

namespace BusinessLayer
{
    public class AuthorManager
    {
        //DbManager dbManager;

        //public AuthorManager()
        //{
        //    dbManager = new();
        //}

      public List<Author> ConvertAuthorDataTableToList(DataTable dt)
        {
            List<Author> list = new List<Author>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(ConvertDataRowToAuthor(row));
            }

            return list;
        }
     public Author ConvertDataRowToAuthor(DataRow dr)
        {
            Author author = new Author();
            author.Id =dr["au_id"].ToString()!;
            author.Phone = dr["phone"].ToString();
            author.FirstName = dr["au_fname"].ToString()!;
            author.LastName = dr["au_lname"].ToString()!;
            author.Address = dr["Address"].ToString()!;
            author.State = dr["state"].ToString();
            author.ZIP = dr["zip"].ToString();
            author.City = dr["City"].ToString()!;
            author.ActiveContract = dr.Field<bool>("ActiveContract");
            return author;
        }

        DbManager db = new DbManager();

        public List<Author> GetAllAuthors()
        {
            return db.GetAuthorList();
        }

        public int DeleteAuthor(string id)
        {
            return db.DeleteAuthor(id);
        }

        public int AddAuthor(Author author)
        {
            if (string.IsNullOrEmpty(author.FirstName))
            {
                Console.WriteLine("first name is required!");
                return -1;
            }
            return db.InsertAuthor(author);
        }
    }
}
