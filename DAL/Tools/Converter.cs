using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Tools
{
    public static class Converter
    {
        public static Contact Convert(IDataReader reader)
        {
            return new Contact
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Email = reader["Email"].ToString()
            };
        }
    }
}
