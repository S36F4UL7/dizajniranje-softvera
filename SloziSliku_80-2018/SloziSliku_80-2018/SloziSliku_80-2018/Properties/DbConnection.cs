using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloziSliku_80_2018.Properties
{
    class DbConnection
    {
        private static SqlConnection instance = null;
        private static readonly object padlock = new object();

        public static SqlConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new SqlConnection(Properties.Settings.Default.dbConnection);
                }
                return instance;
            }
        }
    }
}
