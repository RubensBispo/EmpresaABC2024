﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    class Conexao
    {
        private static string connectionString= "Server=localhost;Port=3306;Database=dbLoja;Pwd=123456;Uid=etecia";

        private static MySqlConnection con = null;

        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                con = null;
            }
            return con;
        }

        public static void fecharConexao()
        {
            if (con!=null)
            {
                con.Close();
            }
        }
    }
}
