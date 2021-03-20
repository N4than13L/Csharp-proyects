using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Paginador<T>
    {
        private List<T> _dataList;
        private static int max_reg, _reg_por_pagina, page_count, numPag = 1;
        private Label _label;

        public Paginador(List<T> dataList,  Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _label = label;
            _reg_por_pagina = reg_por_pagina;
            cargarDatos();
        }
        private void cargarDatos()
        {
            numPag = 1;
            max_reg = _dataList.Count;
            page_count = (max_reg / _reg_por_pagina);

            if ((max_reg % _reg_por_pagina) > 0)
            {
                page_count += 1;

            }

            _label.Text = $"Paginas 1 / { page_count}";
        }

        public int primero()
        {
            numPag = 1;
            _label.Text = $"Paginas {numPag}/{page_count}";
            return numPag;
        }

        public int anterior()
        {
            if (numPag > 1)
            {
                numPag -= 1;
                _label.Text = $"Paginas {numPag}/{page_count}";
            }
            return numPag;
        }

        public int siguiente()
        {
            if (numPag == page_count)
                numPag -= 1;
            
            if(numPag < page_count)
            {
                numPag += 1;
                _label.Text = $"Paginas {numPag}/{page_count}";
            }
            return numPag;
        }
        public int ultimo()
        {
            numPag = page_count;
            _label.Text = $"Paginas {numPag}/{page_count}";
            return numPag;
        }


    }
}
