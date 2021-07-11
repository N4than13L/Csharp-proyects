using System;
using MySql.Data.MySqlClient;


namespace Acceso_de_datos
{
    public class ConnectionMySQL
    {
        MySqlConnection conectar = new MySqlConnection("server = Local instance wampmpymysqld; database=mi_compañia; Uid=root; pwd=;");
        conectar.Open();

        return co
    }
}
