using ADOToolbox;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Repository
{
    public class BaseRepository
    {
        internal Connection _connection;

        IConfiguration _config;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
            _connection = new Connection(_config.GetConnectionString("toto"));
        }


    }
}
