using LOCAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOCAL.Interface
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAll();
        Contact GetOne(int Id);
        int Insert(Contact c);
        void Update(Contact c);
        bool Delete(int Id);
    }
}
