using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Departmetns.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }



        public Employee(string Name, int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public Employee()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }


    public class Department
    {
        public Department(string Name)
        {
            this.Name = Name;
            Employees = new List<Employee>();

        }

        public Department()
        {

        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public void WriteToXML(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
            StreamWriter streamWriter = new StreamWriter(filename);

            xmlSerializer.Serialize(streamWriter,this);

            streamWriter.Close();
        }

        static public Department LoadFromXML(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
            StreamReader streamReader = new StreamReader(filename);
            Department department = new Department();
            department=(xmlSerializer.Deserialize(streamReader) as Department);

            streamReader.Close();
            return department;

        }
    }
}
