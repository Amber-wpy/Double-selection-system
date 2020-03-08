using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_selection_systemModel
{
    public class Subject
    {
        private int _subjectNo = 0;
        private string _subjectName = string.Empty;
        private int _classHour = 0;
        private int _gradeId = 0;

        /// <summary>
        /// 科目编号
        /// </summary>
        public int SubjectNo { get => _subjectNo; set => _subjectNo = value; }

        /// <summary>
        /// 科目名称
        /// </summary>
        public string SubjectName { get => _subjectName; set => _subjectName = value; }

        /// <summary>
        /// 科目时长。
        /// </summary>
        public int ClassHour { get => _classHour; set => _classHour = value; }

        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get => _gradeId; set => _gradeId = value; }
    }
}
