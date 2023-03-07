using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniProject_MCC75.ViewModels;

public class RegisterVM
{
    [Required(ErrorMessage = "Employee ID Must Be Filled.")]
    public int Id { get; set; }
    [Display (Name = "Office Code")]
    [Required(ErrorMessage = "Office Code Must Be Filled.")]
    public int OfficeCode { get; set; }
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name Must Be Filled.")]
    public string FirstName { get; set; }
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }
    [EmailAddress]
    [Required(ErrorMessage = "Email Must Be Filled")]
    public string Email { get; set; }
    [Display(Name = "Job Title")]
    [Required(ErrorMessage = "Job Title Must Be Filled.")]
    public string JobTitle { get; set; }
    [DataType(DataType.Password)]
    [StringLength(12, ErrorMessage = "The {0} Must Be Filled Between {2} and {1} Characters.", MinimumLength = 6)]
    public string Password { get; set; }
    [Display(Name = "Password Confirmation")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "The Password Confirmation Did Not Match With the Password.")]
    public string PasswordConfirm { get; set; }
}
