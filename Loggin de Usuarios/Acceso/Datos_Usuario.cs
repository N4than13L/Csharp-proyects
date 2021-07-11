using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Acceso
{
    public class Datos_Usuario : ConectandoMySQL
    {
        public bool Login(string usuario, string contras)
        {
            using(var coneccion = ObtenerConexion())
            {
                coneccion.Open();

                using (var commando = new MySqlCommand())
                {
                    commando.Connection = coneccion;
                    commando.CommandText = "select * from usuarios where LoginName=Natha and password=natha;";
                    commando.Parameters.AddWithValue("Natha", usuario);
                    commando.Parameters.AddWithValue("natha", contras);

                    commando.CommandType = CommandType.Text;
                    MySqlDataReader lector = commando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
    
                }
            }
        }
    }
}
