using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using THE_COOKY_APP.DTO;
using THE_COOKY_APP.DAO;
namespace THE_COOKY_APP.BLL
{
    internal class AccountBLL
    {
       
            private AccountDAO accountDAO = new AccountDAO();

            // Lấy tất cả tài khoản
            public List<AccountDTO> GetAllAccounts()
            {
                return accountDAO.GetAllAccounts();
            }

            // Thêm tài khoản mới
            public void AddAccount(AccountDTO account)
            {
                // Kiểm tra logic trước khi thêm
                if (string.IsNullOrEmpty(account.Username) || string.IsNullOrEmpty(account.Password))
                {
                    throw new ArgumentException("Username và Password không được để trống.");
                }

                if (accountDAO.GetAllAccounts().Any(a => a.Username == account.Username))
                {
                    throw new ArgumentException("Username đã tồn tại.");
                }

                accountDAO.AddAccount(account);
            }

            // Cập nhật tài khoản
            public void UpdateAccount(AccountDTO account)
            {
                // Kiểm tra nếu tài khoản không tồn tại
                //var existingAccount = accountDAO.GetAllAccounts().FirstOrDefault(a => a.IdAccount == account.IdAccount);
                //if (existingAccount == null)
                //{
                //    throw new ArgumentException("Không tìm thấy tài khoản để cập nhật.");
                //}

                accountDAO.UpdateAccount(account);
            }

            // Xóa tài khoản theo ID
            public void DeleteAccount(int idAccount)
            {
                // Kiểm tra nếu tài khoản không tồn tại
                var existingAccount = accountDAO.GetAllAccounts().FirstOrDefault(a => a.IdAccount == idAccount.ToString());
                if (existingAccount == null)
                {
                    throw new ArgumentException("Không tìm thấy tài khoản để xóa.");
                }

                accountDAO.DeleteAccount(idAccount);
            }

            public void LockAccount(string username)
            {
                accountDAO.LockAccount(username);
            }


            public string Login(string username, string password)
            {
                string accountId = accountDAO.Login(username, password);

                return accountId;


            }
            public int LoadFailedAttempts(string username)
            {
                int attempts = accountDAO.LoadFailedAttempts(username);
                return attempts;
            }



            public string GetIdByEmail(string email)
            {
                return accountDAO.GetIdByEmail(email);

            }
            public AccountDTO GetAccountByEmail(string email)
            {

                return accountDAO.GetAccountByEmail(email);

            }
            public AccountDTO GetAccountById(string id)
            {
                return accountDAO.GetAccountById(id);

            }

            // Lấy tài khoản theo username
            public AccountDTO GetAccountByUsername(string username)
            {
                return accountDAO.GetAllAccounts().FirstOrDefault(a => a.Username == username);
            }
     }
    
}
