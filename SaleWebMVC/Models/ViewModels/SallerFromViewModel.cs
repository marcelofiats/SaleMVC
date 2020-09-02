using System.Collections.Generic;

namespace SaleWebMVC.Models.ViewModels
{
    public class SallerFromViewModel
    {
        public Saller Saller{ get; set; }
        public ICollection<Department> Departments{ get; set; }
    }
}
