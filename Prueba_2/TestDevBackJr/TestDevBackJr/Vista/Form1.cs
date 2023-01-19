using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDevBackJr.Controladores;

namespace TestDevBackJr
{
    public partial class Form1 : Form
    {
        private ClsConsultas consultas = new ClsConsultas();
        private bool banderaEditar = false;
        public Form1()
        {
            InitializeComponent();
        }
        #region Acciones Formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }
        private void DGVlistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGVlistado.Rows.Count != 0)
            {
                if (MessageBox.Show("¿Desea actualizar el sueldo de " + DGVlistado.CurrentRow.Cells[2].Value + "?", "Actualizar sueldo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LBLuseId.Text = DGVlistado.CurrentRow.Cells[0].Value.ToString();
                    TXTlogin.Text = DGVlistado.CurrentRow.Cells[1].Value.ToString();
                    TXTnombre.Text = DGVlistado.CurrentRow.Cells[2].Value.ToString();
                    TXTpaterno.Text = DGVlistado.CurrentRow.Cells[3].Value.ToString();
                    TXTmaterno.Text = DGVlistado.CurrentRow.Cells[4].Value.ToString();
                    TXTsueldo.Text = DGVlistado.CurrentRow.Cells[5].Value.ToString();
                    banderaEditar = true;
                    BTNagregar.Text = "Actualizar";
                }
                    
            }
        }
        private void BTNagregar_Click(object sender, EventArgs e)
        {
            AgregarActualizarRegistro();
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void BTNtop10_Click(object sender, EventArgs e)
        {
            LlenarDataGridTop();
        }

        private void BTNgenerarCSV_Click(object sender, EventArgs e)
        {
            new ClsExportar().Export(DGVlistado);
        }
        #endregion
        #region Metodos
        private void LlenarDataGrid()
        {
            DataSet ds = new DataSet();
            ds = consultas.ObtenerUsuarios();
            DGVlistado.DataSource = ds.Tables[0];
            //DisenoTabla();
            ds.Dispose();
        }
        private void LlenarDataGridTop()
        {
            DataSet ds = new DataSet();
            ds = consultas.ObtenerTopUsuarios();
            DGVlistado.DataSource = ds.Tables[0];
            //DisenoTabla();
            ds.Dispose();
        }
        private void LimpiarDatos()
        {
            TXTlogin.Clear();
            TXTnombre.Clear();
            TXTpaterno.Clear();
            TXTmaterno.Clear();
            TXTsueldo.Clear();
            LBLuseId.Text = "";         
        }
        private void AgregarActualizarRegistro()
        {
            if (banderaEditar == false)
            {
                /*Guardar Registro*/
                if (MessageBox.Show("¿La información es correcta?", "Agregar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TXTlogin.Text.Trim() == "")
                    {
                        MessageBox.Show("ingrese el login");
                    }
                    else if (TXTnombre.Text.Trim()=="") {
                        MessageBox.Show("ingrese el nombre");
                    }
                    else if (TXTpaterno.Text.Trim() == "")
                    {
                        MessageBox.Show("ingrese el aprellido paterno");
                    }
                    else if (TXTmaterno.Text.Trim() == "")
                    {
                        MessageBox.Show("ingrese el apellido materno");
                    }
                    else if (TXTsueldo.Text.Trim() == "")
                    {
                        MessageBox.Show("ingrese el sueldo");
                    }
                    else
                    {
                        consultas.InsertarUsuario(TXTlogin.Text, TXTnombre.Text, TXTpaterno.Text, TXTmaterno.Text, float.Parse(TXTsueldo.Text));
                        MessageBox.Show("Usuario registrado");
                        LimpiarDatos();
                        LlenarDataGrid();
                    }
                    
                }
            }
            else
            {
                /*Actualizar sueldo*/
                if (MessageBox.Show("¿El sueldo es correcto?", "Actualizar sueldo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (TXTsueldo.Text.Trim() == "")
                    {
                        MessageBox.Show("ingrese el sueldo");
                    }
                    else
                    {
                        consultas.ActualizarSueldo(float.Parse(TXTsueldo.Text), Convert.ToInt32(LBLuseId.Text));
                        MessageBox.Show("Sueldo actualizado");
                        LimpiarDatos();
                        LlenarDataGrid();
                        banderaEditar = false;
                        BTNagregar.Text = "Agregar";
                    }
                    
                }
            }
        }

        #endregion
        #region Validaciones
        private void TXTsueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
