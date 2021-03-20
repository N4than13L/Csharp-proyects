using Data;
using LinqToDB;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class L_Estudiantes : Librerias
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox imagen;
        private Librerias librerias;

        private Bitmap _img_Bitmap;
        private DataGridView _dataGridView1;
        private NumericUpDown _numericUpDown1;

        private Paginador<Estudiantes> _paginador;
        private String _accion = "insertar";

        public L_Estudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            librerias = new Librerias();
            imagen = (PictureBox)objetos[0];
            _img_Bitmap = (Bitmap)objetos[1];
            _dataGridView1 = (DataGridView)objetos[2];
            _numericUpDown1 = (NumericUpDown)objetos[3];
            
             Restablecer();

        }

        private int _id_Estudiante = 0;
        public void GetEstudiates()
        {
            _accion = "update";
            _id_Estudiante = Convert.ToInt16(_dataGridView1.CurrentRow.Cells[0].Value);

            listTextBox[0].Text = Convert.ToString(_dataGridView1.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView1.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView1.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView1.CurrentRow.Cells[4].Value);
         
            try
            {
                byte[] arrayImage = (byte[])_dataGridView1.CurrentRow.Cells[5].Value;
                imagen.Image = upload_Image.byteArraytoImage(arrayImage);
            }
            catch (Exception)
            {
                imagen.Image = _img_Bitmap;
            }
        }

        public void Paginador(string metodo)
        {
            switch (metodo)
            {
                case "primero":
                    _num_pagina = _paginador.primero();
                    break;
                case "anterior":
                    _num_pagina = _paginador.anterior();
                    break;
                case "siguiente":
                    _num_pagina = _paginador.siguiente();
                    break;
                case "ultimo":
                    _num_pagina = _paginador.ultimo();
                    break;
            }
            Search_Estudiante("");
        }

        public void Registro_por_Pagina()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)_numericUpDown1.Value;

            var list = _Estudiantes.ToList();

            if(0 < list.Count)
            {
                _paginador = new Paginador<Estudiantes>(listEstudiantes, listLabel[4], _reg_por_pagina);
                Search_Estudiante("");
            }
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El campo matricula es requerido";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El campo es requerido completarlo";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El campo es requerido completarlo";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El campo es requerido completarlo";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                        else
                        {
                            if (librerias.textBoxEvent.Validar_email(listTextBox[3].Text))
                            {
                                var usuarios = _Estudiantes.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();

                                if (usuarios.Count.Equals(0))
                                {
                                    save();

                                }
                                else
                                {
                                    if (usuarios[0].id.Equals(_id_Estudiante))
                                    {
                                        save();
                                    }
                                    else
                                    {
                                        listLabel[3].Text = "El Email ya está regisrado";
                                        listLabel[3].ForeColor = Color.Red;
                                        listTextBox[3].Focus();
                                    }

                                    
                                }
                            }

                            else
                            {
                                listLabel[3].Text = "El Email no es valido";
                                listLabel[3].ForeColor = Color.Red;
                                listTextBox[3].Focus();

                            }

                        }

                    }
                }
            }
        }

        private void save()
        {
            BeginTransactionAsync();
            try
            {
                var imagen_array = librerias.upload_Image.Imagen_a_Byte(imagen.Image);

                switch (_accion)
                {
                    case "insert":
                        _Estudiantes.Value(e => e.nid, listTextBox[0].Text)
                    .Value(e => e.nombre, listTextBox[1].Text)
                    .Value(e => e.apellido, listTextBox[2].Text)
                    .Value(e => e.email, listTextBox[3].Text)
                    .Value(e => e.imagen, imagen_array)
                    .Insert();
                        break;

                    case "update":
                            _Estudiantes.Where(u => u.id.Equals(_id_Estudiante))
                    .Set(e => e.nombre, listTextBox[1].Text)
                    .Set(e => e.apellido, listTextBox[2].Text)
                    .Set(e => e.email, listTextBox[3].Text)
                    .Set(e => e.imagen, imagen_array)
                    .Update();
                        break;


                    default:
                        break;
                }

                //int data = Convert.ToInt16("k");

                CommitTransaction();
                Restablecer();

            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }
        public int _num_pagina = 2, _reg_por_pagina = 1;
        private List<Estudiantes> listEstudiantes;

        public void Search_Estudiante(string campo)
        {
            List<Estudiantes> query = new List<Estudiantes>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;

            if (campo.Equals(""))
            {
                query = _Estudiantes.ToList();
            }
            else
            {
                query = _Estudiantes.Where(c => c.nid.StartsWith(campo) || c.nombre.StartsWith(campo)
                || c.apellido.StartsWith(campo)).ToList();
            }

            if (0 < query.Count)
            {
                _dataGridView1.DataSource = query.Select(c => new
                {
                    c.id,
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.email

                }).Skip(inicio).Take(_reg_por_pagina).ToList();
                _dataGridView1.Columns[0].Visible = false;

                //_dataGridView1.Columns[5].Visible = false;

                _dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                _dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            else
            {
                _dataGridView1.DataSource = query.Select(c => new
                {
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.email,
                    c.imagen
                }).ToList();
            }

        }

        public void eliminar()
        {
            if (_id_Estudiante.Equals(0))
            {
                MessageBox.Show("seleccione un estudiante");
            }
            else
            {
                if(MessageBox.Show("El estudiante se va a eliminar un estudiante", "Eliminar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Estudiantes.Where(c => c.id.Equals(_id_Estudiante)).Delete();
                    Restablecer();
                }
                
            }
        }

        public void Restablecer()
        {
            _accion = "insert";
            _num_pagina = 1;
            _id_Estudiante = 0;
            imagen.Image = _img_Bitmap;
            listLabel[0].Text = "Nid";
            listLabel[1].Text = "Nombre";
            listLabel[2].Text = "Apellido";
            listLabel[3].Text = "Email";

            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].ForeColor = Color.LightSlateGray;

            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";

            listEstudiantes = _Estudiantes.ToList();
            if(0 < listEstudiantes.Count)
            {
                _paginador = new Paginador<Estudiantes>(listEstudiantes, listLabel[4], _reg_por_pagina);
            }

            Search_Estudiante("");
        }
    }

}
