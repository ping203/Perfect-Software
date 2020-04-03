using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_ProductManagement.BUS
{
    class UserBUS
    {
        UserDAO userDAO = new UserDAO();
        public int Login(string name, string pass)
        {
            return userDAO.getUserLogin(name, pass);
        }

        public List<UserDTO> GetUserFromGroup(string groupID)
        {
            return userDAO.GetUserFromGroup(groupID);
        }

        public List<UserGroupDTO> GetUserGroup(string groupID, string vaiTro)
        {
            return userDAO.GetUserGroup(groupID, vaiTro);
        }

        internal bool checkPasswordCorrect(object usernameGlobal)
        {
            throw new NotImplementedException();
        }


        public string GetPassword(string username)
        {
            return userDAO.GetPassword(username);
        }
        public int CapNhatMatKhau(string username, string newPass)
        {
            return userDAO.CapNhatMatKhau(username, newPass);
        }

        //Kiểm tra sự chính xác của mật khẩu tương ứng tài khoản
        public int checkPasswordCorrect(string username, string password)
        {
            return userDAO.checkPasswordCorrect(username, password);
        }
        
        //Đổi mật khẩu (Update)
        public int updatePassword(string username, string password)
        {
            return userDAO.updatePassword(username, password);
        }

        //kiểm tra đăng nhập
        public int checkLogin(string username, string password)
        {
            return userDAO.checkLogin(username, password);
        }

    }
}
