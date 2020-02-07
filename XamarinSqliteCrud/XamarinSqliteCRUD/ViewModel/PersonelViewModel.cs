using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.ViewModel
{
    public class PersonelViewModel : INotifyPropertyChanged
    {
        public IUnitOfWork UnitOfWork;
        public string Personelname;
        public PersonelViewModel(IUnitOfWork unitOfWork)
        {
            personelRepository = unitOfWork.PersonelRepository;
        }
        public readonly IPersonelRepository personelRepository;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnModelChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
        public List<Department> DepartmentListss { get; set; }
        public Task<List<Department>> Departments()
        {
            return Task.Run(()=> personelRepository.GetDepartmentsListAsync()) ;
        }
    }
}
