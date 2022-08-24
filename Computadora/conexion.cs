using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computadora
{
    class conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-K1IOKQ5;Initial Catalog=Computadora;Integrated Security=True");
                cn.Open();
                MessageBox.Show("¡Conexión éxitosa!");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message, "¡Error inesperado!", MessageBoxButtons.OK);
                throw;
            }
        }

        public string insertar(string Codigo, string Tipo_de_Computadora, string Procesador, string Memoria_RAM, string Tipo_de_disco_duro, string Almacenamiento)
        {
            string salida = "SE INSERTO";
            try
            {
                cmd = new SqlCommand("Insert into Detalles_Computadora (Codigo, Tipo_de_Computadora, Procesador, Memoria_RAM, Tipo_de_disco_duro, Almacenamiento)values(" + Codigo + ",'" + Tipo_de_Computadora + "', '" + Procesador + "', '" + Memoria_RAM + "', '" + Tipo_de_disco_duro + "', '" + Almacenamiento + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "Error, no se inserto" + e.ToString();
            }
            return salida;
        }

        public int DetallesInsertados(int Codigo)
        {
            int Contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Detalles_Computadora where Codigo = " + Codigo + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo hacer la Consulta" + e.ToString());
            }
            return Contador;
        }
     
    }
}
