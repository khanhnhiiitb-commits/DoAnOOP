using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLySieuThi.Data
{
    public class DatabaseHelper
    {
        private static string connectionString = @"Server=.;Database=QuanLySieuThi;Trusted_Connection=True;TrustServerCertificate=True;";

        // Hàm để lấy kết nối
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm chạy lệnh SELECT (Trả về DataTable)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Hàm chạy lệnh INSERT, UPDATE, DELETE (Trả về số dòng bị ảnh hưởng)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                
                return cmd.ExecuteNonQuery();
            }
        }
    }
}