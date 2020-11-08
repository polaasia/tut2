using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace lab_02
{
    public class Studies
    {
        [XmlElement(ElementName ="name")]
        public string StudiesName { get; set; }

        [XmlElement(ElementName ="mode")]
        public string StudiesMode { get; set; }

        public int numberOfStudents;
    }
}
