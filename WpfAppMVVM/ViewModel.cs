using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppMVVM
{
    public class PersonViewModel
    {
        private IList<Person> _personList;
        public PersonViewModel()
        {
            _personList = new List<Person>()
        {
            new Person(){Name="Prabhat", Address="Bangalore"},
            new Person(){Name="John",Address="Delhi"}
        };
        }
        public IList<Person> Persons
        {
            get { return _personList; }
            set { _personList = value; }
        }
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
    }

}
