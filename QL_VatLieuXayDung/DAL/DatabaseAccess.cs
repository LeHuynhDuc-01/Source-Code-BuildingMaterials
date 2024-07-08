using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        private string connectconstring = @"Data Source=LAPTOP-H0BOFLN9\SQLEXPRESS;Initial Catalog=QL_VLXD;Integrated Security=True";
        private SqlConnection connect;

        public SqlConnectionData()
        {
            connect = new SqlConnection(connectconstring);
        }

        public SqlConnectionData(string connectconstring)
        {
            connect = new SqlConnection(connectconstring);
        }

        public void Open()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
        }

        public void Close()
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
        }

        public int GetNonQuery(string SQLQueryString)
        {
            int result = 0;
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(SQLQueryString, connect))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing non-query: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
            finally
            {
                Close();
            }
            return result;
        }
        public int GetNonQuery(string SQLProc, SqlParameter[] para)
        {
            int result = 0;
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = SQLProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connect;
                    if (para != null)
                    {
                        cmd.Parameters.AddRange(para);
                    }
                    result = cmd.ExecuteNonQuery();
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing non-query: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
            finally
            {
                Close();
            }
            return result;
        }

        public int GetExecuteScalar(string SQLQueryString)
        {
            int result = 0;
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(SQLQueryString, connect))
                {
                    result = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing scalar: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
            finally
            {
                Close();
            }
            return result;
        }

        public DataTable GetDataTable(string SQLQueryString)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                using (SqlDataAdapter da = new SqlDataAdapter(SQLQueryString, connect))
                {
                    da.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting data table: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
            finally
            {
                Close();
            }
            return dataTable;
        }
        public DataTable GetDataTable(string SQLProc, SqlParameter[]para)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = SQLProc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connect;
                    if(para != null)
                    {
                        cmd.Parameters.AddRange(para);
                    }
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting data table: " + ex.Message);
                // Có thể xử lý hoặc ném exception tùy thuộc vào yêu cầu cụ thể của bạn.
            }
            finally
            {
                Close();
            }
            return dataTable;
        }

        public string CheckLogin(TaiKhoanDTO taikhoan)
        {
            string user = null;
            SqlConnectionData conn = new SqlConnectionData();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_login", conn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", taikhoan.USERNAME);
                cmd.Parameters.AddWithValue("@password", taikhoan.PASSWORD);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = reader.GetString(0);
                        return user;
                    }
                }
                else
                {
                    return "Tài khoản hoặc mật khẩu không chính xác";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return user;
        }


        public int CheckQuyen(TaiKhoanDTO taikhoan)
        {
            int loaiNguoiDung = 0;
            SqlConnectionData conn = new SqlConnectionData();

            using (conn.connect)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_login", conn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", taikhoan.USERNAME);
                cmd.Parameters.AddWithValue("@password", taikhoan.PASSWORD);

                // Thêm tham số đầu ra
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@loai";
                outputParameter.SqlDbType = SqlDbType.Int;
                outputParameter.Direction = ParameterDirection.ReturnValue; // Direction của tham số đầu ra là ReturnValue
                cmd.Parameters.Add(outputParameter);

                // Thực hiện lời gọi stored procedure
                cmd.ExecuteScalar();

                // Lấy giá trị trả về từ tham số đầu ra
                loaiNguoiDung = Convert.ToInt32(outputParameter.Value);
            }

            return loaiNguoiDung;
        }
    }
}
