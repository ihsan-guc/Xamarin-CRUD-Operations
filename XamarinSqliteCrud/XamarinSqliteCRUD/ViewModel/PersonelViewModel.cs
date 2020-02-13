using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.ViewModel
{
    public class PersonelViewModel : INotifyPropertyChanged
    {
        public string Personelname;
        public PersonelViewModel(IUnitOfWork unitOfWork)
        {
            personelRepository = unitOfWork.PersonelRepository;
            DepartmentList = personelRepository.GetDepartmentsListAsync();
        }
        public readonly IPersonelRepository personelRepository;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnModelChanged([CallerMemberName] string property = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }
        Department selectedPersonel;
        public Department Selectedpersonel
        {
            get { return selectedPersonel; }
            set
            {
                if (selectedPersonel != value)
                {
                    selectedPersonel = value;
                    OnModelChanged();
                }
            }
        }
        // TODO ADD Kısmı button çalışmıyor 
        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var personel = new Personel()
                    {
                        PersonelName = Personelname,
                        DepartmentId = Selectedpersonel.Id
                    };
                    await personelRepository.AddPersonelAsync(personel);
                });
            }
        }
        public IList<Department> departmentList;
        public IList<Department> DepartmentList
        {
            get
            {
                return departmentList;
            }
            set
            {
                departmentList = value;
                OnModelChanged();
            }
        }
    }
}
