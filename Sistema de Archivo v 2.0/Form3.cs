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
//        private LPersonalGeneral persona2;
//        private List<File_Personal> query;
//        public Form3()
//        {
//            InitializeComponent();
//            persona2 = new LPersonalGeneral();
//            query = persona2.InitialData();
//        }
//        private void textBoxBuscar2_TextChanged(object sender, EventArgs e)
//        {
//            persona2.SearchPersona(textBoxBuscar2.Text);
//        }
//        private void buttonPrimero2_Click(object sender, EventArgs e)
//        {
//            //persona2.Paginador2("Primero");
//        }
//        private void buttonAnterior2_Click(object sender, EventArgs e)
//        {
//            //persona2.Paginador2("Anterior");
//        }
//        private void buttonSiguiente2_Click(object sender, EventArgs e)
//        {
//            //persona2.Paginador2("Siguiente");
//        }
//        private void buttonUltimo2_Click(object sender, EventArgs e)
//        {
//            //persona2.Paginador2("Ultimo");
//        }
//        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
//        {
//            //persona2.Registro_Paginas();
//        }
//        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            //if (dataGridView2.Rows.Count != 0)
//                //persona2.GetPersona();
//        }
//        private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
//        {
//            //if (dataGridView2.Rows.Count != 0)
//                //persona2.GetPersona();
//        }
//        private void Form3_Load(object sender, EventArgs e)
//        {
//            if (0 < query.Count)
//            {
//                dataGridView2.DataSource = query.Select(c => new
//                {
//                    c.CI,
//                    c.Codigo_Archivo,
//                    c.Codigo_Antiguo,
//                    c.Ap_Paterno,
//                    c.Ap_Materno,
//                    c.Nombres,
//                    c.Numero_item,
//                    c.Estado,
//                    c.Fecha_Nac,
//                    c.Fecha_Inc,
//                    c.Cargo,
//                    c.Administracion,
//                    c.File_Url,
//                    c.File_Contenido,
//                    c.Ubicacion,
//                    c.Image
//                }).ToList();
//                dataGridView2.Columns[1].Visible = false;
//                dataGridView2.Columns[2].Visible = false;
//                dataGridView2.Columns[8].Visible = false;
//                dataGridView2.Columns[9].Visible = false;
//                dataGridView2.Columns[10].Visible = false;
//                dataGridView2.Columns[12].Visible = false;
//                dataGridView2.Columns[13].Visible = false;
//                dataGridView2.Columns[15].Visible = false;
//                dataGridView2.Columns[3].DefaultCellStyle.BackColor = Color.AliceBlue;
//                dataGridView2.Columns[5].DefaultCellStyle.BackColor = Color.AliceBlue;
//                dataGridView2.Columns[7].DefaultCellStyle.BackColor = Color.AliceBlue;
//                dataGridView2.Columns[14].DefaultCellStyle.BackColor = Color.AliceBlue;
//            }
//            else
//            {
//                dataGridView2.DataSource = query.Select(c => new
//                {
//                    c.CI,
//                    c.Codigo_Archivo,
//                    c.Codigo_Antiguo,
//                    c.Ap_Paterno,
//                    c.Ap_Materno,
//                    c.Nombres,
//                    c.Numero_item,
//                    c.Estado,
//                    c.Fecha_Nac,
//                    c.Fecha_Inc,
//                    c.Cargo,
//                    c.Administracion,
//                    c.File_Url,
//                    c.File_Contenido,
//                    c.Ubicacion,
//                    c.Image
//                }).ToList();
//            }
//        }

//        private DataGridView dataGridView2;
//        private TextBox textBoxBuscar2;
//        private Label label16;
//        private Label label17;
//        private Button buttonRegresar;
//        private Button buttonUltimo2;
//        private Button buttonSiguiente2;
//        private Button buttonAnterior2;
//        private Button buttonPrimero2;
//        private NumericUpDown numericUpDown1;
//        private Label labelPaginas;

//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.dataGridView2 = new System.Windows.Forms.DataGridView();
//            this.textBoxBuscar2 = new System.Windows.Forms.TextBox();
//            this.label16 = new System.Windows.Forms.Label();
//            this.label17 = new System.Windows.Forms.Label();
//            this.buttonRegresar = new System.Windows.Forms.Button();
//            this.buttonUltimo2 = new System.Windows.Forms.Button();
//            this.buttonSiguiente2 = new System.Windows.Forms.Button();
//            this.buttonAnterior2 = new System.Windows.Forms.Button();
//            this.buttonPrimero2 = new System.Windows.Forms.Button();
//            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
//            this.labelPaginas = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGridView2
//            // 
//            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView2.Location = new System.Drawing.Point(14, 61);
//            this.dataGridView2.Name = "dataGridView2";
//            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGridView2.Size = new System.Drawing.Size(1064, 567);
//            this.dataGridView2.TabIndex = 0;
//            // 
//            // textBoxBuscar2
//            // 
//            this.textBoxBuscar2.Location = new System.Drawing.Point(86, 38);
//            this.textBoxBuscar2.Multiline = true;
//            this.textBoxBuscar2.Name = "textBoxBuscar2";
//            this.textBoxBuscar2.Size = new System.Drawing.Size(211, 20);
//            this.textBoxBuscar2.TabIndex = 26;
//            // 
//            // label16
//            // 
//            this.label16.AutoSize = true;
//            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
//            this.label16.Location = new System.Drawing.Point(23, 38);
//            this.label16.Name = "label16";
//            this.label16.Size = new System.Drawing.Size(59, 20);
//            this.label16.TabIndex = 25;
//            this.label16.Text = "Buscar";
//            // 
//            // label17
//            // 
//            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.label17.AutoSize = true;
//            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label17.Location = new System.Drawing.Point(477, 9);
//            this.label17.Name = "label17";
//            this.label17.Size = new System.Drawing.Size(152, 20);
//            this.label17.TabIndex = 27;
//            this.label17.Text = "Lista del Personal";
//            // 
//            // buttonRegresar
//            // 
//            this.buttonRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.buttonRegresar.BackColor = System.Drawing.Color.DeepSkyBlue;
//            this.buttonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.buttonRegresar.FlatAppearance.BorderSize = 0;
//            this.buttonRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
//            this.buttonRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
//            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.buttonRegresar.ForeColor = System.Drawing.Color.White;
//            this.buttonRegresar.Image = global::Sistema_de_Archivo_v_2._0.Properties.Resources.Regresar_atrás;
//            this.buttonRegresar.Location = new System.Drawing.Point(736, 671);
//            this.buttonRegresar.Name = "buttonRegresar";
//            this.buttonRegresar.Size = new System.Drawing.Size(122, 47);
//            this.buttonRegresar.TabIndex = 32;
//            this.buttonRegresar.UseVisualStyleBackColor = false;
//            // 
//            // buttonUltimo2
//            // 
//            this.buttonUltimo2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.buttonUltimo2.BackColor = System.Drawing.Color.DeepSkyBlue;
//            this.buttonUltimo2.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.buttonUltimo2.FlatAppearance.BorderSize = 0;
//            this.buttonUltimo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
//            this.buttonUltimo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
//            this.buttonUltimo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.buttonUltimo2.ForeColor = System.Drawing.Color.White;
//            this.buttonUltimo2.Image = global::Sistema_de_Archivo_v_2._0.Properties.Resources.baseline_fast_forward_black_18dp;
//            this.buttonUltimo2.Location = new System.Drawing.Point(590, 671);
//            this.buttonUltimo2.Name = "buttonUltimo2";
//            this.buttonUltimo2.Size = new System.Drawing.Size(122, 47);
//            this.buttonUltimo2.TabIndex = 31;
//            this.buttonUltimo2.UseVisualStyleBackColor = false;
//            // 
//            // buttonSiguiente2
//            // 
//            this.buttonSiguiente2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.buttonSiguiente2.BackColor = System.Drawing.Color.DeepSkyBlue;
//            this.buttonSiguiente2.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.buttonSiguiente2.FlatAppearance.BorderSize = 0;
//            this.buttonSiguiente2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
//            this.buttonSiguiente2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
//            this.buttonSiguiente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.buttonSiguiente2.ForeColor = System.Drawing.Color.White;
//            this.buttonSiguiente2.Image = global::Sistema_de_Archivo_v_2._0.Properties.Resources.baseline_arrow_right_black_18dp;
//            this.buttonSiguiente2.Location = new System.Drawing.Point(462, 671);
//            this.buttonSiguiente2.Name = "buttonSiguiente2";
//            this.buttonSiguiente2.Size = new System.Drawing.Size(122, 47);
//            this.buttonSiguiente2.TabIndex = 30;
//            this.buttonSiguiente2.UseVisualStyleBackColor = false;
//            // 
//            // buttonAnterior2
//            // 
//            this.buttonAnterior2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.buttonAnterior2.BackColor = System.Drawing.Color.DeepSkyBlue;
//            this.buttonAnterior2.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.buttonAnterior2.FlatAppearance.BorderSize = 0;
//            this.buttonAnterior2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
//            this.buttonAnterior2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
//            this.buttonAnterior2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.buttonAnterior2.ForeColor = System.Drawing.Color.White;
//            this.buttonAnterior2.Image = global::Sistema_de_Archivo_v_2._0.Properties.Resources.baseline_arrow_left_black_18dp;
//            this.buttonAnterior2.Location = new System.Drawing.Point(334, 671);
//            this.buttonAnterior2.Name = "buttonAnterior2";
//            this.buttonAnterior2.Size = new System.Drawing.Size(122, 47);
//            this.buttonAnterior2.TabIndex = 29;
//            this.buttonAnterior2.UseVisualStyleBackColor = false;
//            // 
//            // buttonPrimero2
//            // 
//            this.buttonPrimero2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.buttonPrimero2.BackColor = System.Drawing.Color.DeepSkyBlue;
//            this.buttonPrimero2.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.buttonPrimero2.FlatAppearance.BorderSize = 0;
//            this.buttonPrimero2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
//            this.buttonPrimero2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
//            this.buttonPrimero2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.buttonPrimero2.ForeColor = System.Drawing.Color.White;
//            this.buttonPrimero2.Image = global::Sistema_de_Archivo_v_2._0.Properties.Resources.baseline_fast_rewind_black_18dp;
//            this.buttonPrimero2.Location = new System.Drawing.Point(206, 671);
//            this.buttonPrimero2.Name = "buttonPrimero2";
//            this.buttonPrimero2.Size = new System.Drawing.Size(122, 47);
//            this.buttonPrimero2.TabIndex = 28;
//            this.buttonPrimero2.UseVisualStyleBackColor = false;
//            this.buttonPrimero2.Click += new System.EventHandler(this.buttonPrimero2_Click_1);
//            // 
//            // numericUpDown1
//            // 
//            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.numericUpDown1.Location = new System.Drawing.Point(27, 660);
//            this.numericUpDown1.Minimum = new decimal(new int[] {
//            1,
//            0,
//            0,
//            0});
//            this.numericUpDown1.Name = "numericUpDown1";
//            this.numericUpDown1.Size = new System.Drawing.Size(70, 21);
//            this.numericUpDown1.TabIndex = 35;
//            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
//            this.numericUpDown1.Value = new decimal(new int[] {
//            1,
//            0,
//            0,
//            0});
//            // 
//            // labelPaginas
//            // 
//            this.labelPaginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
//            this.labelPaginas.AutoSize = true;
//            this.labelPaginas.BackColor = System.Drawing.Color.White;
//            this.labelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.labelPaginas.ForeColor = System.Drawing.Color.SteelBlue;
//            this.labelPaginas.Location = new System.Drawing.Point(431, 641);
//            this.labelPaginas.Name = "labelPaginas";
//            this.labelPaginas.Size = new System.Drawing.Size(56, 16);
//            this.labelPaginas.TabIndex = 36;
//            this.labelPaginas.Text = "Página";
//            // 
//            // Form3
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1089, 730);
//            this.Controls.Add(this.labelPaginas);
//            this.Controls.Add(this.buttonRegresar);
//            this.Controls.Add(this.numericUpDown1);
//            this.Controls.Add(this.buttonSiguiente2);
//            this.Controls.Add(this.buttonUltimo2);
//            this.Controls.Add(this.buttonPrimero2);
//            this.Controls.Add(this.buttonAnterior2);
//            this.Controls.Add(this.label17);
//            this.Controls.Add(this.textBoxBuscar2);
//            this.Controls.Add(this.label16);
//            this.Controls.Add(this.dataGridView2);
//            this.Name = "Form3";
//            this.Text = "Reporte de Personal";
//            this.Load += new System.EventHandler(this.Form3_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        private void buttonPrimero2_Click_1(object sender, EventArgs e)
//        {

//        }
//        //private void textBoxBuscar2_TextChanged(object sender, EventArgs e)
//        //{
//        //    persona2.SearchPersona(textBoxBuscar2.Text);
//        //}
//    }
//}