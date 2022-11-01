using Data;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    //public class LPersonalGeneral : Librarys
    //{
    //    private int _reg_por_pagina = 24, _num_pagina = 1;
    //    private List<File_Personal> query;
    //    public List<File_Personal> InitialData()
    //    {
    //        query = new List<File_Personal>();
    //        int inicio = (_num_pagina - 1) * _reg_por_pagina;
    //        query = _File_Personal.Skip(inicio).Take(_reg_por_pagina).ToList();
    //        return query;
    //    }

    //    public List<File_Personal> SearchPersona(string campo)
    //    {
    //        query = new List<File_Personal>();
    //        int inicio = (_num_pagina - 1) * _reg_por_pagina;
    //        if (campo.Equals(""))
    //        {
    //            query = _File_Personal.ToList();
    //        }
    //        else
    //        {
    //            query = _File_Personal.Where(c => c.CI.StartsWith(campo) || c.Ap_Paterno.StartsWith(campo) || c.Ap_Materno.StartsWith(campo) || c.Nombres.StartsWith(campo)
    //                || c.Estado.StartsWith(campo) || c.Cargo.StartsWith(campo) || c.Administracion.StartsWith(campo)).ToList();
    //        }
    //        return query;

    //    }
    //}

    public class Paginador2<T>
    {
        private List<T> _dataList;
        private Label _label;
        private static int maxReg, _reg_por_pagina, pageCount, numPagi = 1;
        public Paginador2(List<T> dataList, Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _label = label;
            _reg_por_pagina = reg_por_pagina;
            cargarDatos();
        }
        //public Paginador2(List<File_Personal> listFile_Personal, int reg_por_pagina)
        //{
        //    this.listFile_Personal = listFile_Personal;
        //    this.reg_por_pagina = reg_por_pagina;
        //}

        private void cargarDatos()
        {
            numPagi = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg / _reg_por_pagina);
            //Ajuste el número de la página si la última página contiene una parte de la página.
            if ((maxReg % _reg_por_pagina) > 0)
            {
                pageCount += 1;
            }
            _label.Text = $"Paginas 1/ {pageCount}";
        }
        public int primero()
        {
            numPagi = 1;
            _label.Text = $"Paginas {numPagi}/{pageCount}";
            return numPagi;
        }
        public int anterior()
        {
            if (numPagi > 1)
            {
                numPagi -= 1;
                _label.Text = $"Pagina { numPagi}/{pageCount}";
            }
            return numPagi;
        }
        public int siguiente()
        {
            if (numPagi == pageCount)
                numPagi -= 1;
            if (numPagi < pageCount)
            {
                numPagi += 1;
                _label.Text = $"Paginas { numPagi}/{pageCount}";
            }
            return numPagi;
        }
        public int ultimo()
        {
            numPagi = pageCount;
            _label.Text = $"Paginas { numPagi}/{pageCount}";
            return numPagi;
        }
    }
}
