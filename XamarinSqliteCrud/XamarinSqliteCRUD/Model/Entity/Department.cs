using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinSqliteCRUD.Model.Entity
{
    public class Department : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public virtual ICollection<Personel> Personel{ get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
