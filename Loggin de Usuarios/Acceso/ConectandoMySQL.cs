using System;
using MySql.Data.MySqlClient;

namespace Acceso
{
    public class ConectandoMySQL
    {
       private readonly string conctingString;
       
        public ConectandoMySQL()
        {
            //MySqlConnection conectar = new MySqlConnection("server= Local instance wampmpymysqld; database=mi_tienda; Uid=root; pwd=;");
            conctingString = "server= Local instance wampmpymysqld; database=mi_tienda; Uid=root; pwd=;";
        }

        protected MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(conctingString);
        }

    }
}
