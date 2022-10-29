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
using System.Globalization;

namespace Logica
{
    public class LPersonal : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private List<CheckBox> listCheckBox;
        private List<DateTimePicker> listDateTimePicker;
        private PictureBox image;
        private Bitmap _imagBitmap;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        private Paginador<File_Personal> _paginador;
        private string _accion = "insert";
        public LPersonal(List<TextBox> listTextBox, List<Label> listLabel, List<CheckBox> listCheckBox, List<DateTimePicker> listDateTimePicker,  object[] objectos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            this.listCheckBox = listCheckBox;
            this.listDateTimePicker = listDateTimePicker;
            image = (PictureBox)objectos[0];
            _imagBitmap = (Bitmap)objectos[1];
            _dataGridView = (DataGridView)objectos[2];
            _numericUpDown = (NumericUpDown)objectos[3];
            Restablecer();
        }
        public void Registrar()
        {
            if(listTextBox[0].Text.Equals(""))
            {
                MessageBox.Show("El campo Cédula de Identidad es requerido");
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    MessageBox.Show("El campo Código de Archivo es requerido");
                }
                else
                {
                    if (listTextBox[3].Text.Equals(""))
                    {
                        MessageBox.Show("El campo Apellido Paterno es requerido");
                    }
                    else
                    {
                        if (listTextBox[5].Text.Equals(""))
                        {
                            MessageBox.Show("El campo Nombres es requerido");
                        }
                        else
                        {
                            if (listTextBox[7].Text.Equals(""))
                            {
                                MessageBox.Show("El campo Fecha de Nacimiento es requerido");
                            }
                            else
                            {
                                if (listTextBox[8].Text.Equals(""))
                                {
                                    MessageBox.Show("El campo Fecha de Ingreso es requerido");
                                }
                                else
                                {
                                    if (listTextBox[9].Text.Equals(""))
                                    {
                                        MessageBox.Show("El campo Cargo es requerido");
                                    }
                                    else
                                    {
                                        if (listTextBox[10].Text.Equals(""))
                                        {
                                            MessageBox.Show("El campo Administración es requerido");
                                        }
                                        else
                                        {
                                            if (listTextBox[11].Text.Equals(""))
                                            {
                                                MessageBox.Show("El campo File URL es requerido");
                                            }
                                            else
                                            {
                                                if (listTextBox[12].Text.Equals(""))
                                                {
                                                    MessageBox.Show("El campo Contenido es requerido");
                                                }
                                                else
                                                {
                                                    if (listTextBox[14].Text.Equals(""))
                                                    {
                                                        MessageBox.Show("El campo Ubicación en el Archivo es requerido");
                                                    }
                                                    else
                                                    {
                                                        string _estado = "";
                                                        if (listCheckBox[0].Checked == true)
                                                        {
                                                            _estado = "Activo";
                                                            listTextBox[7].Text = _estado;
                                                        }
                                                        else
                                                        {
                                                            if (listCheckBox[1].Checked == true)
                                                            {
                                                                _estado = "Pasivo";
                                                                listTextBox[7].Text = _estado;
                                                            }
                                                            else
                                                            {
                                                                if (listCheckBox[2].Checked == true)
                                                                {
                                                                    _estado = "Eventual";
                                                                    listTextBox[7].Text = _estado;
                                                                }
                                                                else
                                                                {
                                                                    if (listCheckBox[3].Checked == true)
                                                                    {
                                                                        _estado = "Consultor";
                                                                        listTextBox[7].Text = _estado;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (listCheckBox[4].Checked == true)
                                                                        {
                                                                            _estado = "Personal Militar";
                                                                            listTextBox[7].Text = _estado;
                                                                        }
                                                                        if (listTextBox[7].Text.Equals(""))
                                                                        {
                                                                            MessageBox.Show("El campo Estado es requerido");
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
                                                }
                                            }
                                        }
                                    }
                                }
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
                var imageArray = uploadimage.ImageToByte(image.Image);
                switch (_accion)
                {
                    case "insert":
                        _File_Personal.Value(e => e.CI, listTextBox[0].Text)
                                      .Value(e => e.Codigo_Archivo, listTextBox[1].Text)
                                      .Value(e => e.Codigo_Antiguo, listTextBox[2].Text)
                                      .Value(e => e.Ap_Paterno, listTextBox[3].Text)
                                      .Value(e => e.Ap_Materno, listTextBox[4].Text)
                                      .Value(e => e.Nombres, listTextBox[5].Text)
                                      .Value(e => e.Numero_item, listTextBox[6].Text)
                                      .Value(e => e.Estado, listTextBox[7].Text)
                                      .Value(e => e.Fecha_Nac, listDateTimePicker[0].Value)
                                    //.Value(e => e.Fecha_Nac, listTextBox[8].Text)
                                      .Value(e => e.Fecha_Inc, listDateTimePicker[1].Value)
                                    //.Value(e => e.Fecha_Inc, listTextBox[9].Text)
                                      .Value(e => e.Cargo, listTextBox[10].Text)
                                      .Value(e => e.Administracion, listTextBox[11].Text)
                                      .Value(e => e.File_Url, listTextBox[12].Text)
                                      .Value(e => e.File_Contenido, listTextBox[13].Text)
                                      .Value(e => e.Ubicacion, listTextBox[14].Text)
                                      .Value(e => e.Image, imageArray)
                                      .Insert();
                        break;
                    case "update":
                        _File_Personal.Where(u => u.CI.Equals(_idFile_Personal))  //_File_Personal
                            .Set(e => e.CI, listTextBox[0].Text)
                            .Set(e => e.Codigo_Archivo, listTextBox[1].Text)
                            .Set(e => e.Codigo_Antiguo, listTextBox[2].Text)
                            .Set(e => e.Ap_Paterno, listTextBox[3].Text)
                            .Set(e => e.Ap_Materno, listTextBox[4].Text)
                            .Set(e => e.Nombres, listTextBox[5].Text)
                            .Set(e => e.Numero_item, listTextBox[6].Text)
                            .Set(e => e.Estado, listTextBox[7].Text)
                            .Set(e => e.Fecha_Nac, listDateTimePicker[0].Value)
                          //.Set(e => e.Fecha_Nac, listTextBox[8].Text)
                            .Set(e => e.Fecha_Inc, listDateTimePicker[1].Value)
                          //.Set(e => e.Fecha_Inc, listTextBox[9].Text)
                            .Set(e => e.Cargo, listTextBox[10].Text)
                            .Set(e => e.Administracion, listTextBox[11].Text)
                            .Set(e => e.File_Url, listTextBox[12].Text)
                            .Set(e => e.File_Contenido, listTextBox[13].Text)
                            .Set(e => e.Ubicacion, listTextBox[14].Text)
                            .Set(e => e.Image, imageArray)
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
            List<File_Personal> query = new List<File_Personal>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (campo.Equals(""))
            {
                query = _File_Personal.ToList();
            }
            else
            {
                query = _File_Personal.Where(c => c.CI.StartsWith(campo) || c.Ap_Paterno.StartsWith(campo) || c.Ap_Materno.StartsWith(campo) || c.Nombres.StartsWith(campo)
                    || c.Estado.StartsWith(campo) || c.Cargo.StartsWith(campo) || c.Administracion.StartsWith(campo)).ToList();
            }
            if (0 < query.Count)
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.CI,
                    c.Codigo_Archivo,
                    c.Codigo_Antiguo,
                    c.Ap_Paterno,
                    c.Ap_Materno,
                    c.Nombres,
                    c.Numero_item,
                    c.Estado,
                    c.Fecha_Nac,
                    c.Fecha_Inc,
                    c.Cargo,
                    c.Administracion,
                    c.File_Url,
                    c.File_Contenido,
                    c.Ubicacion,
                    c.Image
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
                    c.CI,
                    c.Codigo_Archivo,
                    c.Codigo_Antiguo,
                    c.Ap_Paterno,
                    c.Ap_Materno,
                    c.Nombres,
                    c.Numero_item,
                    c.Estado,
                    c.Fecha_Nac,
                    c.Fecha_Inc,
                    c.Cargo,
                    c.Administracion,
                    c.File_Url,
                    c.File_Contenido,
                    c.Ubicacion,
                    c.Image
                }).ToList();
            }
        }
        private int _idFile_Personal = 0;
        public void GetPersona()
        {
            _accion = "update";
            _idFile_Personal = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[4].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);
            listTextBox[5].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[5].Value);
            listTextBox[6].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[6].Value);
            listTextBox[7].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[7].Value);
            listTextBox[8].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[8].Value);
            listDateTimePicker[0].Value = (DateTime)_dataGridView.CurrentRow.Cells[8].Value;
            listTextBox[9].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[9].Value);
            listDateTimePicker[1].Value = (DateTime)_dataGridView.CurrentRow.Cells[9].Value;
            listTextBox[10].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[10].Value);
            listTextBox[11].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[11].Value);
            listTextBox[12].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[12].Value);
            listTextBox[13].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[13].Value);
            listTextBox[14].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[14].Value);
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
        private List<File_Personal> listFile_Personal;
        public void Paginador(string metodo)
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _paginador.primero();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.anterior();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.siguiente();
                    break;
                case "Ultimo":
                    _num_pagina = _paginador.ultimo();
                    break;
            }
            SearchPersona("");
        }
        public void Registro_Paginas()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)_numericUpDown.Value;
            var list = _File_Personal.ToList();
            if (0 < list.Count)
            {
                _paginador = new Paginador<File_Personal>(listFile_Personal, listLabel[14], _reg_por_pagina);
                SearchPersona("");
            }
        }
        public void Eliminar()
        {
            if (_idFile_Personal.Equals(0))
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar el registro?", "Eliminar registro",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _File_Personal.Where(c => c.Id.Equals(_idFile_Personal)).Delete();
                    Restablecer();
                }
            }
        }
        public void Restablecer()
        {
            _accion = "insert";
            _num_pagina = 1;
            _idFile_Personal = 0;
            image.Image = _imagBitmap;
            listLabel[0].Text = "Cédula de Identidad:";
            listLabel[1].Text = "Código de Archivo:";
            listLabel[2].Text = "Código Antiguo:";
            listLabel[3].Text = "Apellido Paterno:";
            listLabel[4].Text = "Apellido Materno:";
            listLabel[5].Text = "Nombres:";
            listLabel[6].Text = "Número de Item:";
            listLabel[7].Text = "Estado:";
            listLabel[8].Text = "Fecha de Nacimiento:";
            listLabel[9].Text = "Fecha de Ingreso:";
            listLabel[10].Text = "Cargo:";
            listLabel[11].Text = "Administración:";
            listLabel[12].Text = "File URL:";
            listLabel[13].Text = "Contenido:";
            listLabel[14].Text = "Ubicación:";
            listCheckBox[0].Checked = false;
            listCheckBox[1].Checked = false;
            listCheckBox[2].Checked = false;
            listCheckBox[3].Checked = false;
            listCheckBox[4].Checked = false;
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
            listTextBox[13].Text = "";
            listTextBox[14].Text = "";
            listFile_Personal = _File_Personal.ToList();
            if (0 < listFile_Personal.Count)
            {
                _paginador = new Paginador<File_Personal>(listFile_Personal, listLabel[15], _reg_por_pagina);
            }
            SearchPersona("");
        }
    }
}
