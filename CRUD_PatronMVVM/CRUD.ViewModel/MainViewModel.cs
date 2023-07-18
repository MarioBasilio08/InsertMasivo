using CRUD.Model;
using CRUD.Model.EmployeeService;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CRUD.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private int id;
        private int age;
        private string name;
        private string email;
        private ObservableCollection<Employee> lista;

        ServiceAdapter serv;

        private bool isButtonEnabled;

        private bool isTextBoxEnabled;

        private ICommand saveCommand;
        private ICommand saveCommandSQL;
        private ICommand newCommand;

        public bool IsButtonEnabled
        {
            get { return isButtonEnabled; }
            set
            {
                isButtonEnabled = value;
                OnPropertyChanged(); 
            }
        }

        public bool IsTextBoxEnabled
        {
            get { return isTextBoxEnabled; }
            set
            {
                isTextBoxEnabled = value;
                OnPropertyChanged();
            }
        }


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Name
        {
            get { return name; }
            set { 
                name = value; 
                OnPropertyChanged("Name");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public ObservableCollection<Employee> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged(nameof(lista));
            }
        }

        public ICommand SaveCommandSQL
        {
            get
            {
                if (saveCommandSQL == null)
                {
                    saveCommandSQL = new RelayCommand(p => this.saveSQL());
                }
                return saveCommandSQL;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                {
                    saveCommand = new RelayCommand(p => this.Save());
                }
                return saveCommand;
            }
        }

        public ICommand NewCommand
        {
            get
            {
                if (newCommand == null)
                {
                    newCommand = new RelayCommand(p => this.New());
                }
                return newCommand;
            }
        }

        public MainViewModel()
        {
            
            IsButtonEnabled = true;
            isTextBoxEnabled = false;

            serv = new ServiceAdapter();
            Lista = new ObservableCollection<Employee>();
       
        }


        public void Save()
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || age <= 0)
            {
                MessageBox.Show("Hay campos erroneos o incompletos, por favor revise todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Employee persona = new Employee();
                persona.EmployeeName = name;
                persona.Email = email;
                persona.Age = age;

                Lista.Add(persona);

                Limpiar();


            }

        }

        public void New()
        {
            IsButtonEnabled = true;
            Limpiar();
        }

        public void Limpiar()
        {
            id = 0;
            OnPropertyChanged("Id");

            age = 0;
            OnPropertyChanged("Age");

            name = null;
            OnPropertyChanged("Name");

            email = null;
            OnPropertyChanged("Email");
        }

        public void saveSQL()
        {
            if(Lista.Count > 0)
            {
                if (serv.insertEmployeeMasiveService(Lista))
                {
                    MessageBox.Show("Registros guardados en DB.", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                    Lista.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos masivamente.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                MessageBox.Show("La lista se esta vacía, rellene datos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
