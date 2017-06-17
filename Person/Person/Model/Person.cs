using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Model
{
    class Person
    {
        private string _Id;
        public string Id { get { return _Id; } set { _Id = value; } }
        private string _FName;
        public string FName { get { return _FName; } set { _FName = value; } }
        private string _SName;
        public string SName { get { return _SName; } set { _SName = value; } }
        private string _LName;
        public string LName { get { return _LName; } set { _LName = value; } }
        private string _Age;
        public string Age { get { return _Age; } set { _Age = value; } }


        public static ObservableCollection<Person> DownLoadPerson()
        {
            Stream stream = File.OpenRead("") as Stream;
            var deserializer = new BinaryFormatter();
            var returnValue = deserializer.Deserialize(stream) as ObservableCollection<Person>;
            stream.Close();
            return returnValue;
        }
    }
}
