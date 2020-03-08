using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_selection_systemModel
{
    public class Login
    {
        private int _userID = 0;
        private string _userNum = string.Empty;
        private string _userPwd = string.Empty;

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get => _userID; set => _userID = value; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserNum { get => _userNum; set => _userNum = value; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get => _userPwd; set => _userPwd = value; }
    }
}
