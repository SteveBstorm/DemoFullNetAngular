using ADOToolbox;
using DAL.Interface;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Tools;
using System.Linq;

namespace DAL.Repository
{
    public class ContactRepository : BaseRepository, IContactRepository
    {
        public ContactRepository(IConfiguration config) : base(config) 
        { 
        }

        public bool Delete(int Id)
        {
            Command cmd = new Command("DELETE FROM Contact WHERE Id = @Id");
            cmd.AddParameter("Id", Id);
            return _connection.ExecuteNonQuery(cmd) == 1;
        }

        public IEnumerable<Contact> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Contact");
            return _connection.ExecuteReader(cmd, Converter.Convert);
        }

        public Contact GetOne(int Id)
        {
            Command cmd = new Command("SELECT * FROM Contact WHERE Id = @Id");
            cmd.AddParameter("Id", Id);
            return _connection.ExecuteReader(cmd, Converter.Convert).FirstOrDefault();
        }

        public int Insert(Contact c)
        {
            Command cmd = new Command("INSERT INTO Contact (LastName, FirstName, Email) OUTPUT inserted.Id VALUES (@ln, @fn, @mail)");
            cmd.AddParameter("fn", c.FirstName);
            cmd.AddParameter("ln", c.LastName);
            cmd.AddParameter("mail", c.Email);

            return (int)_connection.ExecuteScalar(cmd);
        }

        public void Update(Contact c)
        {
            Command cmd = new Command("UPDATE Contact SET Email = @mail, LastName = @ln, FirstName=@fn WHERE Id = @id");
            cmd.AddParameter("fn", c.FirstName);
            cmd.AddParameter("ln", c.LastName);
            cmd.AddParameter("mail", c.Email);
            cmd.AddParameter("id", c.Id);

            _connection.ExecuteNonQuery(cmd);
        }
    }
}
