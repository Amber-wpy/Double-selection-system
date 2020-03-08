using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_selection_systemModel
{
    [Serializable]
    public class Admin
    {
        private string _loginId = string.Empty;
        private string _loginPwd = string.Empty;

        /// <summary>
        /// 登录ID
        /// </summary>
        public string LoginId { get => _loginId; set => _loginId = value; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }
    }
}
