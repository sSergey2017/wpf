using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Model;

namespace Persons.ViewModel
{
    class MainWindowViewModel
    {
 
        public MainWindowViewModel()
        {
                Person = new ObservableCollection<Person>();
                Person.Add(new Person()
                {
                    Id = "12",
                    FName = "Петр",
                    SName = "Викторович",
                    LName = "Матющенко",
                    Age = "41"
                });
                Person.Add(new Person()
                {
                    Id = "11",
                    FName = "Иван",
                    SName = "Ивнов",
                    LName = "Иванович",
                    Age = "11"
                });
        }

        public ObservableCollection<Person> Person { get; set; }
      
    }
}
