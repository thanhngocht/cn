
using THE_COOKY_APP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Microsoft.Identity.Client;

namespace THE_COOKY_APP.DAO
{
    internal class AccountDAO
    {
        private string connectionString = "Data Source=DESKTOP-BT5EHQR\\SQLEXPRESS;Initial Catalog=CookingClass;Integrated Security=True;";

        public List<AccountDTO> GetAllAccounts()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccountDTO account = new AccountDTO
                    {
                        IdAccount = (string)reader["ID_ACCOUNT"],
                        Gmail = reader["GMAIL"]?.ToString() ?? string.Empty,
                        PhoneNumber = reader["PHONE_NUMBER"]?.ToString() ?? string.Empty,
                        FullName = reader["FULL_NAME"]?.ToString() ?? string.Empty,
                        Username = reader["USERNAME"]?.ToString() ?? string.Empty,
                        Password = reader["PASSWORD"]?.ToString() ?? string.Empty
                    };
                    accounts.Add(account);
                }
            }
            return accounts;
        }





        public string GetIdByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID_ACCOUNT FROM ACCOUNT WHERE GMAIL = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();

                    // Kiểm tra nếu kết quả không null và trả về ID hoặc null
                    return result?.ToString();
                }
            }
        }

        public void LockAccount(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE ACCOUNT SET IsLocked = 1 WHERE USERNAME = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }








        public int LoadFailedAttempts(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FailedAttempts FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public string Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                string checkLockQuery = "SELECT IsLocked FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";
                using (SqlCommand checkLockCommand = new SqlCommand(checkLockQuery, connection))
                {
                    checkLockCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });

                    using (SqlDataReader reader = checkLockCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            bool isLocked = reader.GetBoolean(0);

                            if (isLocked)
                            {
                                return "locked"; // Tài khoản bị khóa
                            }
                        }
                        else
                        {
                            return "not found"; // Tài khoản không tồn tại
                        }
                    }
                }


                // Thực hiện đăng nhập
                string loginQuery = "SELECT ID_ACCOUNT FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN AND password = @password COLLATE Latin1_General_BIN";
                using (SqlCommand loginCommand = new SqlCommand(loginQuery, connection))
                {
                    loginCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                    loginCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = password });

                    object result = loginCommand.ExecuteScalar();

                    if (result == null)
                    {
                        // Tăng số lần đăng nhập sai nếu đăng nhập không thành công
                        string incrementFailedAttemptsQuery = "UPDATE ACCOUNT SET FailedAttempts = FailedAttempts + 1 WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand incrementCommand = new SqlCommand(incrementFailedAttemptsQuery, connection))
                        {
                            incrementCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                            incrementCommand.ExecuteNonQuery();
                        }

                        // Kiểm tra xem tài khoản có bị khóa sau 5 lần đăng nhập sai hay không
                        string checkAttemptsQuery = "SELECT FailedAttempts FROM ACCOUNT WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand checkAttemptsCommand = new SqlCommand(checkAttemptsQuery, connection))
                        {
                            checkAttemptsCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });

                            object attemptsResult = checkAttemptsCommand.ExecuteScalar();
                            int failedAttempts = (int)attemptsResult; // Kiểm tra NULL trước khi chuyển đổi

                            if (failedAttempts >= 5)
                            {
                                string lockAccountQuery = "UPDATE ACCOUNT SET IsLocked = 1 WHERE username = @username COLLATE Latin1_General_BIN";
                                using (SqlCommand lockCommand = new SqlCommand(lockAccountQuery, connection))
                                {
                                    lockCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                                    lockCommand.ExecuteNonQuery();
                                }

                                return "locked"; // Tài khoản bị khóa sau 5 lần nhập sai
                            }
                        }

                        return null; // Đăng nhập thất bại, tên đăng nhập hoặc mật khẩu không đúng
                    }
                    else
                    {
                        // Đặt lại số lần đăng nhập sai khi đăng nhập thành công
                        string resetAttemptsQuery = "UPDATE ACCOUNT SET FailedAttempts = 0 WHERE username = @username COLLATE Latin1_General_BIN";
                        using (SqlCommand resetCommand = new SqlCommand(resetAttemptsQuery, connection))
                        {
                            resetCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                            resetCommand.ExecuteNonQuery();
                        }

                        return result.ToString(); // Trả về ID tài khoản
                    }
                }


            }
        }


        public AccountDTO GetAccountById(string accountId)
        {
            string query = "SELECT ID_ACCOUNT, username, GMAIL FROM ACCOUNT WHERE ID_ACCOUNT = @AccountId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@AccountId", accountId));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AccountDTO
                            {
                                IdAccount = reader["ID_ACCOUNT"].ToString(),
                                Username = reader["username"].ToString(),
                                Gmail = reader["GMAIL"].ToString()

                            };
                        }
                    }
                }
            }

            return null; // Trả về null nếu không tìm thấy tài khoản
        }


        public AccountDTO GetAccountByEmail(string email)
        {
            string query = "SELECT ID_ACCOUNT, username, GMAIL,PHONE_NUMBER ,FULL_NAME, PASSWORD FROM ACCOUNT WHERE GMAIL = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@email", email));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AccountDTO
                            {
                                IdAccount = reader["ID_ACCOUNT"].ToString(),
                                Gmail = reader["GMAIL"].ToString(),
                                PhoneNumber = reader["PHONE_NUMBER"].ToString(),
                                FullName = reader["FULL_NAME"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["PASSWORD"].ToString()


                                // Gán thêm các thuộc tính khác nếu cần
                            };
                        }
                    }
                }
            }

            return null; // Trả về null nếu không tìm thấy tài khoản
        }





        public void AddAccount(AccountDTO account)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ACCOUNT (GMAIL, PHONE_NUMBER, FULL_NAME, USERNAME, PASSWORD) VALUES (@Gmail, @PhoneNumber, @FullName, @Username, @Password)", conn);
                cmd.Parameters.AddWithValue("@Gmail", account.Gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", account.PhoneNumber);
                cmd.Parameters.AddWithValue("@FullName", account.FullName);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(AccountDTO account)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ACCOUNT SET GMAIL = @Gmail, PHONE_NUMBER = @PhoneNumber, FULL_NAME = @FullName, USERNAME = @Username, PASSWORD = @Password WHERE ID_ACCOUNT = @IdAccount", conn);
                cmd.Parameters.AddWithValue("@Gmail", account.Gmail);
                cmd.Parameters.AddWithValue("@PhoneNumber", account.PhoneNumber);
                cmd.Parameters.AddWithValue("@FullName", account.FullName);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@IdAccount", account.IdAccount);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAccount(int idAccount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ACCOUNT WHERE ID_ACCOUNT = @IdAccount", conn);
                cmd.Parameters.AddWithValue("@IdAccount", idAccount);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
