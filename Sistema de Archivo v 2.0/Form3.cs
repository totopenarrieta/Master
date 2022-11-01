//using Data;
//using Logica;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Sistema_de_Archivo_v_2._0
//{
//    public partial class Form3 : Form
//    {
        //private LPersonalGeneral persona2;
        //private List<File_Personal> query;
        //public Form3()
        //{
        //    InitializeComponent();
        //    persona2 = new LPersonalGeneral();
        //    query = persona2.InitialData();
        //}
        //private void textBoxBuscar2_TextChanged(object sender, EventArgs e)
        //{
        //    persona2.SearchPersona(textBoxBuscar2.Text);
        //}
        //private void buttonPrimero2_Click(object sender, EventArgs e)
        //{
        //    persona2.Paginador2("Primero");
        //}
        //private void buttonAnterior2_Click(object sender, EventArgs e)
        //{
        //    persona2.Paginador2("Anterior");
        //}
        //private void buttonSiguiente2_Click(object sender, EventArgs e)
        //{
        //    persona2.Paginador2("Siguiente");
        //}
        //private void buttonUltimo2_Click(object sender, EventArgs e)
        //{
        //    persona2.Paginador2("Ultimo");
        //}
        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    persona2.Registro_Paginas();
        //}
        //private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView2.Rows.Count != 0)
        //        persona2.GetPersona();
        //}
        //private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (dataGridView2.Rows.Count != 0)
        //        persona2.GetPersona();
        //}
        //private void Form3_Load(object sender, EventArgs e)
        //{
        //    if (0 < query.Count)
        //    {
        //        dataGridView2.DataSource = query.Select(c => new
        //        {
        //            c.CI,
        //            c.Codigo_Archivo,
        //            c.Codigo_Antiguo,
        //            c.Ap_Paterno,
        //            c.Ap_Materno,
        //            c.Nombres,
        //            c.Numero_item,
        //            c.Estado,
        //            c.Fecha_Nac,
        //            c.Fecha_Inc,
        //            c.Cargo,
        //            c.Administracion,
        //            c.File_Url,
        //            c.File_Contenido,
        //            c.Ubicacion,
        //            c.Image
        //        }).ToList();
        //        dataGridView2.Columns[1].Visible = false;
        //        dataGridView2.Columns[2].Visible = false;
        //        dataGridView2.Columns[8].Visible = false;
        //        dataGridView2.Columns[9].Visible = false;
        //        dataGridView2.Columns[10].Visible = false;
        //        dataGridView2.Columns[12].Visible = false;
        //        dataGridView2.Columns[13].Visible = false;
        //        dataGridView2.Columns[15].Visible = false;
        //        dataGridView2.Columns[3].DefaultCellStyle.BackColor = Color.AliceBlue;
        //        dataGridView2.Columns[5].DefaultCellStyle.BackColor = Color.AliceBlue;
        //        dataGridView2.Columns[7].DefaultCellStyle.BackColor = Color.AliceBlue;
        //        dataGridView2.Columns[14].DefaultCellStyle.BackColor = Color.AliceBlue;
        //    }
        //    else
        //    {
        //        dataGridView2.DataSource = query.Select(c => new
        //        {
        //            c.CI,
        //            c.Codigo_Archivo,
        //            c.Codigo_Antiguo,
        //            c.Ap_Paterno,
        //            c.Ap_Materno,
        //            c.Nombres,
        //            c.Numero_item,
        //            c.Estado,
        //            c.Fecha_Nac,
        //            c.Fecha_Inc,
        //            c.Cargo,
        //            c.Administracion,
        //            c.File_Url,
        //            c.File_Contenido,
        //            c.Ubicacion,
        //            c.Image
        //        }).ToList();
        //    }
        //}
        //private void textBoxBuscar2_TextChanged(object sender, EventArgs e)
        //{
        //    persona2.SearchPersona(textBoxBuscar2.Text);
        //}
//    }
//}