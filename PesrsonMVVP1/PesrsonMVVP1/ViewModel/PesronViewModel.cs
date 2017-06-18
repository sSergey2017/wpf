using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesrsonMVVP1.Model;
using PesrsonMVVP1.Utils;

namespace PesrsonMVVP1.ViewModel
{
    class PesronViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<Person> _person;
        #endregion

        #region Constructor
        public PesronViewModel()
        {
            _person = new ObservableCollection<Person>();
            _person.Add(new Person()
            {
                Id = "12",
                FName = "Петр",
                SName = "Викторович",
                LName = "Матющенко",
                Age = "41"
            });
            _person.Add(new Person()
            {
                Id = "11",
                FName = "Иван",
                SName = "Ивнов",
                LName = "Иванович",
                Age = "11"
            });
            _person.Add(new Person()
            {
                Id = "10",
                FName = "Семен",
                SName = "Викторович",
                LName = "Матющенко",
                Age = "33"
            });
            _person.Add(new Person()
            {
                Id = "9",
                FName = "КурлыМурлы",
                SName = "Ивнов",
                LName = "Иванович",
                Age = "101"
            });

        }
        #endregion

        #region Public Properties
        public ObservableCollection<Person> Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged("Person");
            }
        }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
                RemovePersonCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


 
        #region Command
        private DelegateCommand _editPersonCommand;
        public DelegateCommand EditPersonCommand
        {
            get
            {
                return _editPersonCommand ?? (_editPersonCommand = new DelegateCommand(EditPerson));
            }
        }
        
        private void EditPerson(object arg)
        {
            var pp = this.SelectedPerson;
            //_person.Add(new Person() { });
        }

        private DelegateCommand _addPersonCommand;
        public DelegateCommand AddPersonCommand
        {
            get
            {
                return _addPersonCommand ?? (_addPersonCommand = new DelegateCommand(AddNewPerson));
            }
        }

        private void AddNewPerson(object arg)
        {
            var pp = this.SelectedPerson;
            _person.Add(new Person() { });
        }

        private DelegateCommand _removePersonCommand;
        public DelegateCommand RemovePersonCommand
        {
            get
            {
                return _removePersonCommand ?? (_removePersonCommand = new DelegateCommand(RemovePerson, CanRemovePerson));
            }
        }

        private void RemovePerson(object args)
        {
            _person.Remove(SelectedPerson);
        }

        private bool CanRemovePerson(object args)
        {
            if (SelectedPerson == null)
                return false;
            var person = FindPerson(SelectedPerson);
            if (person == null)
                return false;

            return true;
        }
        #endregion

        #region Private Methods
        private Person FindPerson(Person findPerson)
        {
            if (findPerson == null)
                return null;

            return _person.FirstOrDefault(person => person.Id == findPerson.Id
                                                 && person.FName == findPerson.FName
                                                 && person.SName == findPerson.SName
                                                 && person.LName == findPerson.LName
                                                 && person.Age == findPerson.Age);
        }

        private void OnPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
        }
        #endregion
    }
}
