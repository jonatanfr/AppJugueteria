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

        //Producto

        public static List<ProductoData> ObtenerProducto(int IdProducto)
        {
            List<ProductoData> lista = new List<ProductoData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id, Descripcion, Costo, PrecioVenta,Stock, IdUsuario FROM Producto " +
                "Where Id = @IdProducto;";

            using (SqlConnection conexion = new SqlConnection(connectionString)) 
            { 
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = IdProducto;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows) 
                        {
                            if (dr.Read())
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
            }
            
            return lista;
        }
        public static void CrearProducto(ProductoData productoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto Where Id=@IdProducto;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Descripcion", System.Data.SqlDbType.VarChar) { Value = productoData.Descripciones });
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
                "SET Descripciones = @Descripcion, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario" +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = productoData.Id });
                        command.Parameters.Add(new SqlParameter("Descripcion", System.Data.SqlDbType.VarChar) { Value = productoData.Descripciones });
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



        //Usuario

        public static List<UsuarioData> ObtenerUsuario(int IdUsuario)
        {
            List<UsuarioData> lista = new List<UsuarioData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario " +
                "Where Id = @IdUsuario;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = IdUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var usuario = new UsuarioData();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["Apellido"].ToString();
                                usuario.Password = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);

                            }

                        }

                    }
                }
            }

            return lista;
        }

        public static void CrearUsuario(UsuarioData usuarioData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                " VALUES (@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = usuarioData.Id });
                        command.Parameters.Add(new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = usuarioData.Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", System.Data.SqlDbType.VarChar) { Value = usuarioData.Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", System.Data.SqlDbType.VarChar) { Value = usuarioData.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", System.Data.SqlDbType.VarChar) { Value = usuarioData.Password });
                        command.Parameters.Add(new SqlParameter("Mail", System.Data.SqlDbType.VarChar) { Value = usuarioData.Mail });

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
        public static void ModificarUsuario(UsuarioData usuarioData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "UPDATE Usuario " +
                "SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail" +
                " WHERE Id = @Id";

            
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.BigInt) { Value = usuarioData.Id });
                        command.Parameters.Add(new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) { Value = usuarioData.Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", System.Data.SqlDbType.VarChar) { Value = usuarioData.Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", System.Data.SqlDbType.VarChar) { Value = usuarioData.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", System.Data.SqlDbType.VarChar) { Value = usuarioData.Password });
                        command.Parameters.Add(new SqlParameter("Mail", System.Data.SqlDbType.VarChar) { Value = usuarioData.Mail });
                        
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



        public static void EliminarUsuario(UsuarioData usuarioData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "DELETE FROM Usuario " +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = usuarioData.Id });

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


        public static List<UsuarioData> ListarUsuarios()
        {
            List<UsuarioData> lista = new List<UsuarioData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

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
                                    var usuario = new UsuarioData();
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["Apellido"].ToString();
                                    usuario.Password = dr["Contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                    lista.Add(usuario);
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


        //ProductoVendido


        public static List<ProductoVendidoData> ObtenerProductoVendido(int IdProducto)
        {
            List<ProductoVendidoData> lista = new List<ProductoVendidoData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Stock,IdProducto,IdVenta FROM ProductoVendido " +
                "Where Id = @IdProducto;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = IdProducto;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var productoVendido = new ProductoVendidoData();
                                productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                lista.Add(productoVendido);
                            }

                        }

                    }
                }
            }

            return lista;
        }

        public static void CrearProductoVendido(ProductoVendidoData productoVendidoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "INSERT INTO ProductoVendido (Stock,IdProducto,IdVenta)" +
                " VALUES (@Stock,@IdProducto,@IdVenta);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Stock", System.Data.SqlDbType.Decimal) { Value = productoVendidoData.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", System.Data.SqlDbType.BigInt) { Value = productoVendidoData.IdProducto });
                        command.Parameters.Add(new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = productoVendidoData.IdVenta });

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


        public static void ModificarProductoVendido(ProductoVendidoData productoVendidoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "UPDATE ProductoVendido " +
                "SET Stock = @Stock, IdProducto = @IdProducto, IdVenta = @IdVenta" +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Stock", System.Data.SqlDbType.Decimal) { Value = productoVendidoData.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", System.Data.SqlDbType.BigInt) { Value = productoVendidoData.IdProducto });
                        command.Parameters.Add(new SqlParameter("IdVenta", System.Data.SqlDbType.BigInt) { Value = productoVendidoData.IdVenta });
                        

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

        public static void EliminarProductoVendido(ProductoVendidoData productoVendidoData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "DELETE FROM ProductoVendido " +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = productoVendidoData.Id });

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

        public static List<ProductoVendidoData> ListarProductosVendidos()
        {
            List<ProductoVendidoData> lista = new List<ProductoVendidoData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Stock,IdProducto,IdVenta FROM ProductoVendido";

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
                                    var productoVendido = new ProductoVendidoData();
                                    productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                    lista.Add(productoVendido);
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
        //VentaData


        public static List<VentaData> ObtenerVenta(int IdUsuario)
        {
            List<VentaData> lista = new List<VentaData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta " +
                "Where Id = @Id;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = IdUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var ventaData = new VentaData();
                                ventaData.Id = Convert.ToInt32(dr["Id"]);
                                ventaData.Comentarios = dr["Comentarios"].ToString();
                                ventaData.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                lista.Add(ventaData);
                            }

                        }

                    }
                }
            }

            return lista;
        }

        public static List<VentaData> ObtenerVentaData(int IdUsuario)
        {
            List<VentaData> lista = new List<VentaData>();

            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta " +
                "Where Id = @Id;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = IdUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var ventaData = new VentaData();
                                ventaData.Id = Convert.ToInt32(dr["Id"]);
                                ventaData.Comentarios = dr["Comentarios"].ToString();
                                ventaData.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                lista.Add(ventaData);

                            }

                        }

                    }
                }
            }

            return lista;
        }


        public static void CrearVenta(VentaData ventaData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "INSERT INTO Venta (Comentarios,IdUsuario)" +
                " VALUES (@Comentarios,@IdUsuario);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Descripcion", System.Data.SqlDbType.VarChar) { Value = ventaData.Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = ventaData.IdUsuario });
                       
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


        public static void ModificarVenta(VentaData ventaData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "UPDATE Venta " +
                "SET Comentarios = @Comentarios,  IdUsuario = @IdUsuario" +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = ventaData.Id });
                        command.Parameters.Add(new SqlParameter("Comentarios", System.Data.SqlDbType.VarChar) { Value = ventaData.Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", System.Data.SqlDbType.BigInt) { Value = ventaData.IdUsuario });
                        
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


        public static void EliminarVenta(VentaData ventaData)
        {
            string connectionString = @"Server=JONATAN;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

            string query = "DELETE FROM Venta " +
                " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.VarChar) { Value = ventaData.Id });

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

        public static List<VentaData> ListarVentas()
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
                                    var ventaData = new VentaData();
                                    ventaData.Id = Convert.ToInt32(dr["Id"]);
                                    ventaData.Comentarios = dr["Comentarios"].ToString();
                                    ventaData.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(ventaData);
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
