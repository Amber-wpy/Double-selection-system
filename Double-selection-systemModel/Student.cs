using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_selection_systemModel
{
    public class Student
    {
        private int _studentNo = 0;
        private string _loginPwd = string.Empty;
        private string _studentName = string.Empty;
        private string _gender = string.Empty;
        private int _gradeId = 0;
        private string _phone = string.Empty;
        private string _address = string.Empty;
        private DateTime _bornDate;
        private string _email = string.Empty;
        private string _identityCard = string.Empty;

        /// <summary>
        /// 学生学号
        /// </summary>
        public int StudentNo { get => _studentNo; set => _studentNo = value; }

        /// <summary>
        /// 学生密码
        /// </summary>
        public string LoginPwd { get => _loginPwd; set => _loginPwd = value; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get => _studentName; set => _studentName = value; }

        /// <summary>
        /// 学生性别
        /// </summary>
        public string Gender { get => _gender; set => _gender = value; }

        /// <summary>
        /// 学生年级ID
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }

        /// <summary>
        /// 学生手机号
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }

        /// <summary>
        /// 学生地址
        /// </summary>
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// 学生出生日期
        /// </summary>
        public DateTime BornDate { get => _bornDate; set => _bornDate = value; }

        /// <summary>
        /// 学生邮箱
        /// </summary>
        public string Email { get => _email; set => _email = value; }

        /// <summary>
        /// 学生身份证号码
        /// </summary>
        public string IdentityCard { get => _identityCard; set => _identityCard = value; }
    }
}
