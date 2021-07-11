using System;
using System.Windows.Forms;
using Acceso;

namespace Dominio
{
    public class ModeloUsuario
    {
        Datos_Usuario datos_usuario = new Datos_Usuario();
        public bool Loggin_usuario(string usuario, string contras)
        {
            return datos_usuario.Login(usuario, contras);
        }
    }
} 
