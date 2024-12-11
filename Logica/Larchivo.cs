using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Larchivo : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Bitmap _imagBitmap;
        private List<CheckBox> listCheckBox;
        private List<DateTimePicker> listDateTimePicker;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        private Paginador<Prestamo_File> _paginador;
        private string _accion = "insert";
        public Larchivo(List<TextBox> listTextBox, List<Label> listLabel, List<CheckBox> listCheckBox, List<DateTimePicker> listDateTimePicker, object[] objectos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            this.listCheckBox = listCheckBox;
            this.listDateTimePicker = listDateTimePicker;
            _dataGridView = (DataGridView)objectos[0];
            _numericUpDown = (NumericUpDown)objectos[1];
            Restablecer();
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                MessageBox.Show("El campo Código de Archivo es requerido");
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    MessageBox.Show("El campo Fecha de Préstamo es requerido");
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        MessageBox.Show("El campo Responsable es requerido");
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            MessageBox.Show("El campo Area Responsable es requerido");
                        }
                        else
                        {
                            if (listTextBox[5].Text.Equals(""))
                            {
                                MessageBox.Show("El campo Observaciones es requerido");
                            }
                            else
                            {
                                Save();
                            }
                        }
                    }
                }
            }
        }
        private void Save()
        {
            BeginTransactionAsync();
            try
            {
                switch (_accion)
                {
                    case "insert":
                        _Prestamo_File.Value(e => e.Codigo_File , listTextBox[0].Text)
                                      .Value(e => e.Fecha_Prestamo, listDateTimePicker[0].Value)
                                      .Value(e => e.Responsable, listTextBox[1].Text)
                                      .Value(e => e.Area_Resp, listTextBox[2].Text)
                                      .Value(e => e.Fecha_Dev, listDateTimePicker[1].Value)
                                      .Value(e => e.Observaciones, listTextBox[3].Text)
                                      .Insert();
                        break;
                    case "update":
                        _Prestamo_File.Where(u => u.Codigo_File.Equals(_idPrestamo_File))  //_File_Personal
                            .Set(e => e.Codigo_File, listTextBox[0].Text)
                            .Set(e => e.Fecha_Prestamo, listDateTimePicker[0].Value)
                            .Set(e => e.Responsable, listTextBox[1].Text)
                            .Set(e => e.Area_Resp, listTextBox[2].Text)
                            .Set(e => e.Fecha_Dev, listDateTimePicker[1].Value)
                            .Set(e => e.Observaciones, listTextBox[3].Text)
                            .Update();
                        break;
                }
                CommitTransaction();
                Restablecer();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }
        private int _reg_por_pagina = 4, _num_pagina = 1;
        public void SearchPersona(string campo)
        {
            List<Prestamo_File> query = new List<Prestamo_File>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (campo.Equals(""))
            {
                query = _Prestamo_File.ToList();
            }
            else
            {
                query = _Prestamo_File.Where(c => c.Codigo_File.StartsWith(campo) /*|| c.Fecha_Prestamo.StartsWith(campo)*/ || c.Responsable.StartsWith(campo) || c.Area_Resp.StartsWith(campo)
                    /*|| c.Fecha_Dev.StartsWith(campo)*/ || c.Observaciones.StartsWith(campo)).ToList();
            }
            if (0 < query.Count)
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.Codigo_File,
                    c.Fecha_Prestamo,
                    c.Responsable,
                    c.Area_Resp,
                    c.Fecha_Dev,
                    c.Observaciones
                }).Skip(inicio).Take(_reg_por_pagina).ToList();
                _dataGridView.Columns[1].Visible = false;
                _dataGridView.Columns[2].Visible = false;
                _dataGridView.Columns[8].Visible = false;
                _dataGridView.Columns[9].Visible = false;
                _dataGridView.Columns[10].Visible = false;
                _dataGridView.Columns[12].Visible = false;
                _dataGridView.Columns[13].Visible = false;
                _dataGridView.Columns[15].Visible = false;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.Columns[5].DefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.Columns[7].DefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.Columns[14].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.Codigo_File,
                    c.Fecha_Prestamo,
                    c.Responsable,
                    c.Area_Resp,
                    c.Fecha_Dev,
                    c.Observaciones
                }).ToList();
            }
        }
        private int _idPrestamo_File = 0;
        //private object image; //Cambio sugerido
        //private object _imagBitmap; //Cambio sugerido
        private List<File_Personal> listFile_Personal; //Cambio sugerido

        public void GetPersona()
        {
            _accion = "update";
            _idPrestamo_File = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[4].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);
            listTextBox[5].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[5].Value);
            listTextBox[6].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[6].Value);
            listTextBox[7].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[7].Value);
            listDateTimePicker[0].Value = (DateTime)_dataGridView.CurrentRow.Cells[8].Value;
            listDateTimePicker[1].Value = (DateTime)_dataGridView.CurrentRow.Cells[9].Value;
            listTextBox[10].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[10].Value);
            listTextBox[11].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[11].Value);
            listTextBox[12].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[12].Value);
            try
            {
                byte[] arrayImage = (byte[])_dataGridView.CurrentRow.Cells[15].Value;
                image.Image = uploadimage.byteArrayToImage(arrayImage);
            }
            catch (Exception)
            {
                image.Image = _imagBitmap;
            }
        }
        public void Restablecer()
        {
            _accion = "insert";
            _num_pagina = 1;
            //_idPrestamo_File = 0;
            listLabel[0].Text = "Código de Archivo:";
            listLabel[1].Text = "Fecha de Préstamo:";
            listLabel[2].Text = "Responsable:";
            listLabel[3].Text = "Area Responsable:";
            listLabel[4].Text = "Fecha de Devolución:";
            listLabel[5].Text = "Observaciones:";
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listTextBox[4].Text = "";
            listTextBox[5].Text = "";
            listTextBox[6].Text = "";
            listTextBox[7].Text = "";
            listTextBox[8].Text = "";
            listTextBox[9].Text = "";
            listTextBox[10].Text = "";
            listTextBox[11].Text = "";
            listTextBox[12].Text = "";
            //listTextBox[13].Text = "";
            //listTextBox[14].Text = "";
            listFile_Personal = _File_Personal.ToList();
            if (0 < listFile_Personal.Count)
            {
                _paginador = new Paginador<File_Personal>(listFile_Personal, listLabel[15], _reg_por_pagina);
            }
            SearchPersona("");
        }
        //private int _idPrestamo_File = 0;
    }
}
