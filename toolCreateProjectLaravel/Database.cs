using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Protobuf.WellKnownTypes;

namespace toolCreateProjectLaravel
{
    public class Database
    {

        private string localhost;
        private string _databaseName;
        private string username;
        private string pass;


        public Database(string localhost, string _databaseName, string username, string pass) 
        {
            this.localhost = localhost;
            this._databaseName = _databaseName;
            this.username = username;
            this.pass = pass;
        }


        public string[] tableName()
        {
            List<string> result = new List<string>(); // Sử dụng List thay vì mảng để dễ dàng thêm phần tử
            string connectionString = "server=" + localhost + ";user id=" + username + ";password=" + pass + ";database=" + _databaseName;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn để lấy tên của các bảng
                string sql = "SHOW TABLES;";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0);
                            result.Add(tableName); // Thêm tên bảng vào danh sách kết quả
                        }
                    }
                }
            }

            return result.ToArray(); // Chuyển đổi List sang mảng và trả về
        }
        

        public string[] NameColum(string tableName)
        {
            List<string> result = new List<string>();

            string connectionString = "server=" + localhost + ";user id=" + username + ";password=" + pass + ";database=" + _databaseName;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn để lấy schema của bảng
                    string query = $"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}';";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Đọc tên các cột
                            while (reader.Read())
                            {
                                string columnName = reader.GetString("COLUMN_NAME");
                                result.Add(columnName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }


            return result.ToArray();
        }



        public string fillable(string tableName)
        {
            List<string> result = new List<string>();

            string connectionString = "server=" + localhost + ";user id=" + username + ";password=" + pass + ";database=" + _databaseName;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn để lấy schema của bảng
                    string query = $"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}';";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Đọc tên các cột
                            while (reader.Read())
                            {
                                string columnName = reader.GetString("COLUMN_NAME");
                                result.Add(columnName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }


            StringBuilder sb = new StringBuilder();
            sb.Append("[\n");

            // Duyệt qua từng phần tử trong danh sách
            foreach (string item in result)
            {
                sb.Append($"    '{item}',\n");
            }

            sb.Append("]");

            // In ra chuỗi kết quả
            Console.WriteLine(sb.ToString());


            return sb.ToString();
        }




    

        public string dataRequest(string tableName)
        {
            List<string> result = new List<string>();

            string connectionString = "server=" + localhost + ";user id=" + username + ";password=" + pass + ";database=" + _databaseName;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn để lấy schema của bảng
                    string query = $"SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}';";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Đọc tên các cột
                            while (reader.Read())
                            {
                                string columnName = reader.GetString("COLUMN_NAME");
                                result.Add(columnName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }


            StringBuilder sb = new StringBuilder();
            StringBuilder outputBuilder = new StringBuilder();

            foreach (string field in result)
            {
                outputBuilder.Append($"'{field}' => ['required', 'string'], ");
            }

            string kq = outputBuilder.ToString().TrimEnd(' ', ',');
            Console.WriteLine(result);


            return kq.ToString();
        }
    }
}




