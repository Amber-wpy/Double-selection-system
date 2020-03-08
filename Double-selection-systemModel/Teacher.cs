using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_selection_systemModel
{
    public class Teacher
    {
        private string _name = string.Empty;
        private int _age = 0;
        private int _teachYear = 0;
        private int _id = 0;
        private int _gradeId = 0;
        private string _pwd = string.Empty;
        private string _title = string.Empty;
        private string _introduction = string.Empty;

        /// <summary>
        /// 教师姓名
        /// </summary>
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 教师年龄
        /// </summary>
        public int Age { get => _age; set => _age = value; }

        /// <summary>
        /// 教龄
        /// </summary>
        public int TeachYear { get => _teachYear; set => _teachYear = value; }

        /// <summary>
        /// 教师用户ID
        /// </summary>
        public int Id { get => _id; set => _id = value; }

        /// <summary>
        /// 年级ID
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }

        /// <summary>
        /// 教师用户密码
        /// </summary>
        public string Pwd { get => _pwd; set => _pwd = value; }

        /// <summary>
        /// 教师职称
        /// </summary>
        public string Title { get => _title; set => _title = value; }

        /// <summary>
        /// 教师简介
        /// </summary>
        public string Introduction { get => _introduction; set => _introduction = value; }
    }
}
