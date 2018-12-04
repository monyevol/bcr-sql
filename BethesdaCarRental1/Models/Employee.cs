//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BethesdaCarRental1.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.RentalOrders = new HashSet<RentalOrder>();
        }

        [Display(Name = "Rental Order ID")]
        public int EmployeeID { get; set; }
        [Display(Name = "Employee #")]
        public string EmployeeNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Employment Title")]
        public string EmploymentTitle { get; set; }

        public string Clerk
        {
            get
            {
                return EmployeeNumber + " - " + FirstName + " " + LastName + " (" + EmploymentTitle + ")";
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalOrder> RentalOrders { get; set; }
    }
}