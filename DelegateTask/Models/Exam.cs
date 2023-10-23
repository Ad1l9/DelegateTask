using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(string subject, int examDuration)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = DateTime.Now;
            EndDate = StartDate.AddHours(ExamDuration);
        }

        public override string ToString()
        {
            return $"{Subject} | {ExamDuration}";
        }
    }
}
