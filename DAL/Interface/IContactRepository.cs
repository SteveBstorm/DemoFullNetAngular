using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact GetOne(int Id);
        int Insert(Contact c);
        void Update(Contact c);
        bool Delete(int Id);
    }
}
