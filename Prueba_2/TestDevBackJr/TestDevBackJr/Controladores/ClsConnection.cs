using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDevBackJr.Controladores
{
    class ClsConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=192.168.101.3\\PRMD_SOCIOS; DataBase=TestDevBackJr; User ID=sa; Password=P@SsW0rD03223");
        }
    }
}
