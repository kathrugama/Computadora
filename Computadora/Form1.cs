using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computadora
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        conexion c = new conexion();
       

        public Form1()
        {
            InitializeComponent();
            cargar_datos();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void cargar_datos()
        {
           

                cmbTipo_de_Computadora.Text = "Selecciona un tipo";
                cmbTipo_de_Computadora.Items.Add("Pórtatil");
                cmbTipo_de_Computadora.Items.Add("Escritorio");
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            if (c.DetallesInsertados(Convert.ToInt32(txtCodigo.Text)) == 0)
            {
                MessageBox.Show(c.insertar(txtCodigo.Text, cmbTipo_de_Computadora.Text, txtProcesador.Text, txtMemoria_RAM.Text, txtTipo_de_disco_duro.Text, txtAlmacenamiento.Text));
            }
            else
            {
                MessageBox.Show("¡Imposible registrar, ya existe!");
            }
        }

        private void cmbTipo_de_Computadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_datos();
        }

       
    }
}
