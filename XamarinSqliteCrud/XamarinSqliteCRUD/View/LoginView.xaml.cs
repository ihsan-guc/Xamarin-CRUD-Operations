using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.ViewModel;

namespace XamarinSqliteCRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(unitOfWork);
        }
    }
}