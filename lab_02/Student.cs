using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace lab_02
{
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
        public object Studies { get; set; }


    }
}