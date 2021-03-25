using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwoFactAuth.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "El correo no es valido")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} y un máximo de {1} caracteres.", MinimumLength = 6)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Las contraseñas deben tener al menos 6 caracteres y contener minimamente 1 de los siguientes: mayúsculas(A - Z), minúsculas(a - z), números(0 - 9) y un carácter especial(por ejemplo, @ # $% ^ & *!)")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "La primera contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
