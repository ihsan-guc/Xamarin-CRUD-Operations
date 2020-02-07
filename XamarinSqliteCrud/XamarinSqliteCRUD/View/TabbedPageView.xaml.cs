using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.ViewModel;

namespace XamarinSqliteCRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageView : TabbedPage
    {
        public TabbedPageView(IUnitOfWork unitOfWork)
        {
            Children.Add(new DepartmentView() {BindingContext = new DepartmentViewModel(unitOfWork)});
            Children.Add(new PersonelView() { BindingContext = new PersonelViewModel(unitOfWork) });
        }
    }
}