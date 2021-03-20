using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class Upload_image
    {
        private OpenFileDialog file = new OpenFileDialog();

        public void Cargar_Imagen(PictureBox picturebox)
        {
            picturebox.WaitOnLoad = true;
            file.Filter = "Imagenes|*.jpg;*.png;*.gift;*bmp;";
            file.ShowDialog();

            if (file.FileName != string.Empty)
            {
                picturebox.ImageLocation = file.FileName;
            }
        }
        public byte[] Imagen_a_Byte(Image img)
        {
            ImageConverter conversor = new ImageConverter();
            return (byte[])conversor.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArraytoImage(byte[] byteArrayIn)
        {
            return Image.FromStream(new MemoryStream(byteArrayIn));
        }
    }
}
