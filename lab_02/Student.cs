using System;
using System.Xml.Serialization;

namespace lab_02
{
    [Serializable]
    public class Student
    {
        [XmlAttribute(AttributeName = "indexNumber")]
        public string IDStudent { get; set; }

        [XmlElement(ElementName = "fname")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lname")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "birthdate")]
        public string DoB { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }


        [XmlElement(ElementName = "mothersName")]
        public string MothersName { get; set; }


        [XmlElement(ElementName = "fathersName")]
        public string FathersName { get; set; }

        [XmlElement(ElementName ="studies")]
        public object StStudies { get; set; }


    }
}