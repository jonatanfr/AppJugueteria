using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<VentaData> lista = new List<VentaData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var venta = new VentaData();
                                    
                                        venta.Id = Convert.ToInt32(dr["Id"]);
                                        venta.Comentarios = dr["Comentarios"].ToString();
                                        venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                     
                                    
                                    lista.Add(venta);
                                    
                                   
                                  
                                }
                            }
                        }
                    }

                    conexion.Close();
                }

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
