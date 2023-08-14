using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagment.Web
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage ="حصل مطلوب")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
