using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDevBackJr.Controladores
{
    internal class ClsConsultas
    {
        public DataSet ObtenerUsuarios()
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection connection = ClsConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT u.userId, u.Login,u.Nombre, u.Paterno,u.Materno,e.Sueldo, e.FechaIngreso FROM usuarios u INNER JOIN empleados e ON e.userId = u.userId ";
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
        }
        public DataSet ObtenerTopUsuarios()
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection connection = ClsConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT TOP(10) u.userId,u.Login,u.Nombre,u.Paterno,u.Materno,e.Sueldo,e.FechaIngreso FROM usuarios u INNER JOIN empleados e ON e.userId = u.userId";
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
        }

        public void InsertarUsuario(string Login,string Nombre, string Paterno,string Materno,float Sueldo)
        {
            try
            {
                using (SqlConnection connection = ClsConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO usuarios(Login,Nombre,Paterno,Materno) VALUES(@Login,@Nombre,@Paterno,@Materno)";
                        command.Parameters.AddWithValue("@Login", Login);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Paterno", Paterno);
                        command.Parameters.AddWithValue("@Materno", Materno);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT @@IDENTITY AS ID";
                        int userId =Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "INSERT INTO empleados(userId,Sueldo,FechaIngreso) VALUES (@userId,@Sueldo,GETDATE())";
                        command.Parameters.AddWithValue("@Sueldo", Sueldo);
                        command.Parameters.AddWithValue("@userId", userId);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public void ActualizarSueldo(float Sueldo,int userId)
        {
            try
            {
                using (SqlConnection connection = ClsConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE empleados SET Sueldo=@Sueldo WHERE userId=@userId";
                        command.Parameters.AddWithValue("@Sueldo", Sueldo);
                        command.Parameters.AddWithValue("@userId", userId);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
