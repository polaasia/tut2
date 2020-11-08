using System;
using System.Collections.Generic;

namespace lab_02
{
    [Serializable]
    public class University
    {
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }
        public List<Student> Students { get; set; }
        public List<Studies> ActiveStudies { get; set; }
    }
}