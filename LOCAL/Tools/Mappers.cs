using System;
using System.Collections.Generic;
using System.Text;
using dal = DAL.Models;
using local = LOCAL.Models;

namespace LOCAL.Tools
{
    public static class Mappers
    {
        public static local.Contact toLocal(this dal.Contact c)
        {
            return new local.Contact
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email
            };
        }

        public static dal.Contact toDal(this local.Contact c)
        {
            return new dal.Contact
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email
            };
        }
    }
}
