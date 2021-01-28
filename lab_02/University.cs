using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace lab_02
{
    [Serializable]
    public class University
    {
        [XmlElement]
        public DateTime CreatedAt { get; set; }
        
        [XmlElement]
        public string Author { get; set; }

        [XmlAttribute]
        public List<Student> Students { get; set; }
        
        [XmlAttribute]
        public List<Studies> ActiveStudies { get; set; }
    }
}