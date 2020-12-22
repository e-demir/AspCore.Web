using System.ComponentModel.DataAnnotations;

namespace AspCore.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsim zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email zorunludur")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon zorunludur")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Katılım durumu belirtiniz")]
        public bool? WillAttend { get; set; }
    }
}