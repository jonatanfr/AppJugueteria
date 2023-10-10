using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public static class Contexto
    {
        public static void CrearProducto(ProductoData productoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" +
                " VALUES (@Descripcion,@Costo,@PrecioVenta,@Stock,@IdUsuario);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Descripciones", System.Data.SqlDbType.VarChar) { Value = productoData.Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", System.Data.SqlDbType.Decimal) { Value = productoData.Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", System.Data.SqlDbType.Decimal) { Value = productoData.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("Stock", System.Data.SqlDbType.Decimal) { Value = productoData.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = productoData.IdUsuario });

                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw;

            }

            
        }


        public static void ModificarProducto(ProductoData productoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "UPDATE Producto " +
                "SET Descripciones = @Descripcion, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario)" +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = productoData.Id });
                        command.Parameters.Add(new SqlParameter("Descripciones", System.Data.SqlDbType.VarChar) { Value = productoData.Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", System.Data.SqlDbType.Decimal) { Value = productoData.Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", System.Data.SqlDbType.Decimal) { Value = productoData.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("Stock", System.Data.SqlDbType.Decimal) { Value = productoData.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = productoData.IdUsuario });

                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            } catch (Exception ex)
            {
                throw;
            }
        }


        public static void EliminarProducto(ProductoData productoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "DELETE FROM Producto " +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = productoData.Id });
                        
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<ProductoData> ListarProductos()
        {
            List<ProductoData> lista = new List<ProductoData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";

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
                                    var producto = new ProductoData();
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(producto);
                                }
                            }
                        }
                    }

                    conexion.Close();
                }

               return lista;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
