using System;
using System.Xml.Serialization;

namespace lab_02
{
    [Serializable]
    public class Studies
    {
        [XmlElement(ElementName ="name")]
        public string StudiesName { get; set; }

        [XmlElement(ElementName ="mode")]
        public string StudiesMode { get; set; }

        [XmlElement(ElementName ="number of students")]
        public int numberOfStudents = 0;
    }
}
