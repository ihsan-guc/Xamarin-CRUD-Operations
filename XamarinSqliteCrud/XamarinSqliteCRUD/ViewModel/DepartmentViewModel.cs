using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Model.Entity;

namespace XamarinSqliteCRUD.ViewModel
{
    public class DepartmentViewModel : INotifyPropertyChanged
    {
        public DepartmentViewModel(IUnitOfWork unitOfWork)
        {
            departmentRepository = unitOfWork.DepartmentRepository;
        }
        public readonly IDepartmentRepository departmentRepository;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnModelChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public IEnumerable<Department> departmentList;
        public IEnumerable<Department> DepartmentList
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
        public string DepartmentName { get; set; }
        public ICommand AddCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var department = new Department
                    {
                        Name = DepartmentName,
                    };
                    //await UnitOfWork.DepartmentRepository.AddDepartmentAsync(department);
                    await departmentRepository.AddDepartmentAsync(department);
                    DepartmentList = await departmentRepository.GetDepartmentsListAsync();
                });
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                return new Command(async (object depart) =>
                {
                    Department department = (Department)depart;
                    if (department != null)
                    {
                        await departmentRepository.DeleteDepartmentAsync(department.Id);
                        DepartmentList = await departmentRepository.GetDepartmentsListAsync();
                    }
                });
            }
        }
    }
}
