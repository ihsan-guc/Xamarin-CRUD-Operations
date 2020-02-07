using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace XamarinSqliteCRUD.Model.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        public string PersonelName { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
