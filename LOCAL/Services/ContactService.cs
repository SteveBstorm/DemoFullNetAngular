using DAL.Interface;
using LOCAL.Interface;
using LOCAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LOCAL.Tools;

namespace LOCAL.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepo;

        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public bool Delete(int Id)
        {
            return _contactRepo.Delete(Id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _contactRepo.GetAll().Select(x => x.toLocal());
        }

        public Contact GetOne(int Id)
        {
            return _contactRepo.GetOne(Id).toLocal();
        }

        public int Insert(Contact c)
        {
            return _contactRepo.Insert(c.toDal());
        }

        public void Update(Contact c)
        {
            _contactRepo.Update(c.toDal());
        }
    }
}
