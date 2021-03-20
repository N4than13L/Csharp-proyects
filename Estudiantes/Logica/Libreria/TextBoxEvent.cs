using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Logica.Libreria
{
    public class TextBoxEvent
    {
        public void text_Box_Event(KeyPressEventArgs e)
        {
            //condicion que nos permite realizar una condicion del campo de texto.
            if(char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numeric_key_press(KeyPressEventArgs e)
        {
            //condicion que nos permite realizar una condicion del campo de texto.
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        public bool Validar_email(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
