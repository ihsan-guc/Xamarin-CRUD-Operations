using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinSqliteCRUD.Model;

namespace XamarinSqliteCRUD.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged ([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }
        public string LoginUser { get; set; }
        public string LoginPassword { get; set; }
        public LoginViewModel(IUnitOfWork unitOfWork)
        {

            LoginRepository = unitOfWork.LoginRepository;
        }
        public readonly ILoginRepository LoginRepository;
        public ICommand LoginControl
        {
            get
            {
                return new Command(async () =>
                {
                    var control = LoginRepository.GetUserControl(LoginUser, LoginPassword);
                    if (control != null)
                    {
                        
                    }
                });
            }
        }
    }
}
