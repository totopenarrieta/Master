using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Archivo_v_2._0
{
    public partial class Form2 : Form
    {
        private LPersonal persona;
        public Form2()
        {
            InitializeComponent();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxCI);
            listTextBox.Add(textBoxCodigoArchivo);
            listTextBox.Add(textBoxCodigoAntiguo);
            listTextBox.Add(textBoxApPaterno);
            listTextBox.Add(textBoxApMaterno);
            listTextBox.Add(textBoxNombres);
            listTextBox.Add(textBoxNumeroItem);
            listTextBox.Add(textBoxEstado);
            listTextBox.Add(textBoxCargo);
            listTextBox.Add(textBoxAdministracion);
            listTextBox.Add(textBoxFileUrl);
            listTextBox.Add(textBoxContenido);
            listTextBox.Add(textBoxUbicacionArchivo);
            var listLabel = new List<Label>();
            listLabel.Add(labelCI);
            listLabel.Add(labelCodigoArchivo);
            listLabel.Add(labelCodigoAntiguo);
            listLabel.Add(labelApPaterno);
            listLabel.Add(labelApMaterno);
            listLabel.Add(labelNombres);
            listLabel.Add(labelNumeroItem);
            listLabel.Add(labelEstado);
            listLabel.Add(labelFecNacimiento);
            listLabel.Add(labelFecIngreso);
            listLabel.Add(labelCargo);
            listLabel.Add(labelAdministracion);
            listLabel.Add(labelFileUrl);
            listLabel.Add(labelContenido);
            listLabel.Add(labelUbicacionArchivo);
            listLabel.Add(labelPaginas);
            var listCheckBox = new List<CheckBox>();
            listCheckBox.Add(checkBoxActivo);
            listCheckBox.Add(checkBoxPasivo);
            listCheckBox.Add(checkBoxEventual);
            listCheckBox.Add(checkBoxConsultor);
            listCheckBox.Add(checkBoxPerMilitar);
            var listDateTimePicker = new List<DateTimePicker>();
            listDateTimePicker.Add(dateTimePickerFechaNac);
            listDateTimePicker.Add(dateTimePickerFechaIng);
            Object[] objectos = {
                pictureBoxImage,
                Properties.Resources.COSSMIL,
                dataGridView1,
                numericUpDown1
            };
            persona = new LPersonal(listTextBox, listLabel, listCheckBox, listDateTimePicker, objectos);
        }
        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            persona.uploadimage.CargarImagen(pictureBoxImage);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void textBoxCI_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCI.Text.Equals(""))
            {
                labelCI.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCI.ForeColor = Color.DarkBlue;
                labelCI.Text = "Cédula de Identidad:";
            }
        }
        private void textBoxCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxCodigoArchivo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigoArchivo.Text.Equals(""))
            {
                labelCodigoArchivo.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCodigoArchivo.ForeColor = Color.DarkBlue;
                labelCodigoArchivo.Text = "Código de Archivo:";
            }
        }
        private void textBoxCodigoArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxCodigoAntiguo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigoAntiguo.Text.Equals(""))
            {
                labelCodigoAntiguo.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCodigoAntiguo.ForeColor = Color.DarkBlue;
                labelCodigoAntiguo.Text = "Código Antiguo:";
            }
        }
        private void textBoxCodigoAntiguo_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxApPaterno_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApPaterno.Text.Equals(""))
            {
                labelApPaterno.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApPaterno.ForeColor = Color.DarkBlue;
                labelApPaterno.Text = "Apellido Paterno:";
            }
        }
        private void textBoxApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxApMaterno_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApMaterno.Text.Equals(""))
            {
                labelApMaterno.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApMaterno.ForeColor = Color.DarkBlue;
                labelApMaterno.Text = "Apellido Materno:";
            }
        }
        private void textBoxApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxNombres_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombres.Text.Equals(""))
            {
                labelNombres.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombres.ForeColor = Color.DarkBlue;
                labelNombres.Text = "Nombres:";
            }
        }
        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxNumeroItem_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumeroItem.Text.Equals(""))
            {
                labelNumeroItem.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNumeroItem.ForeColor = Color.DarkBlue;
                labelNumeroItem.Text = "Número de Item:";
            }
        }
        private void textBoxNumeroItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.numberKeyPress(e);
        }
        private void textBoxFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void dateTimePickerFechaNac_TextChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFechaNac.Text.Equals(""))
            {
                labelFecNacimiento.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelFecNacimiento.ForeColor = Color.DarkBlue;
                labelFecNacimiento.Text = "Fecha de Nacimiento:";
            }
        }
        private void textBoxFechaIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxCargo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCargo.Text.Equals(""))
            {
                labelCargo.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCargo.ForeColor = Color.DarkBlue;
                labelCargo.Text = "Cargo:";
            }
        }
        private void textBoxCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxAdministracion_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdministracion.Text.Equals(""))
            {
                labelAdministracion.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelAdministracion.ForeColor = Color.DarkBlue;
                labelAdministracion.Text = "Administración:";
            }
        }
        private void textBoxAdministracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxFileUrl_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFileUrl.Text.Equals(""))
            {
                labelFileUrl.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelFileUrl.ForeColor = Color.DarkBlue;
                labelFileUrl.Text = "File URL:";
            }
        }
        private void textBoxFileUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxContenido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContenido.Text.Equals(""))
            {
                labelContenido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelContenido.ForeColor = Color.DarkBlue;
                labelContenido.Text = "Contenido:";
            }
        }
        private void textBoxContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }
        private void textBoxUbicacionArchivo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUbicacionArchivo.Text.Equals(""))
            {
                labelUbicacionArchivo.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelUbicacionArchivo.ForeColor = Color.DarkBlue;
                labelUbicacionArchivo.Text = "Ubicación en el Archivo:";
            }
        }
        private void textBoxUbicacionArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            persona.textBoxEvent.textKeyPress(e);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            persona.Registrar();
        }
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            persona.SearchPersona(textBoxBuscar.Text);
        }
        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            persona.Paginador("Primero");
        }
        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            persona.Paginador("Anterior");
        }
        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            persona.Paginador("Siguiente");
        }
        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            persona.Paginador("Ultimo");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            persona.Registro_Paginas();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                persona.GetPersona();
        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                persona.GetPersona();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            persona.Restablecer();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            persona.Eliminar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
