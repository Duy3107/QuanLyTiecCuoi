﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTC
{
    class Conection
    {
        private static string stringConection = @"Data Source=LUAN-LENOVO\LUANNGUYEN;Initial Catalog=QLTC;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConection);
        }
    }
}
