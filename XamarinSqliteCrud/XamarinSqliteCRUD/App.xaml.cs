using Xamarin.Forms;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.ViewModel;

namespace XamarinSqliteCRUD
{
    public partial class App : Application
    {
        public App(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            MainPage = new DepartmentView() { BindingContext = new DepartmentViewModel(unitOfWork) } ;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
