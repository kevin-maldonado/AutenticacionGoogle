using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwoFactAuth.Models.ManageViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} y un máximo de {1} caracteres.", MinimumLength = 6)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Las contraseñas deben tener al menos 6 caracteres y contener minimamente 1 de los siguientes: mayúsculas(A - Z), minúsculas(a - z), números(0 - 9) y un carácter especial(por ejemplo, @ # $% ^ & *!)")]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} y un máximo de {1} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
