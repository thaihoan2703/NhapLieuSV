using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapLieuSV
{
    public class Student
    {
        private int stt;
        private string stdID;
        private string stdName;
        private string stdFaculty;
        private double stdAvgScore;

        public int Stt { get => stt; set => stt = value; }
        public string StdID { get => stdID; set => stdID = value; }
        public string StdName { get => stdName; set => stdName = value; }

        public double StdAvgScore { get => stdAvgScore; set => stdAvgScore = value; }
        public string StdFaculty { get => stdFaculty; set => stdFaculty = value; }
    }
}
