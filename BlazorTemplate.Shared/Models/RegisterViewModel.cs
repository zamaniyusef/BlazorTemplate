namespace BlazorTemplate.Shared.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "شماره موبایل الزامی است")]
    [DataType(DataType.PhoneNumber,ErrorMessage = "شماره موبایل وارد شده معتبر نیست")]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = "کلمه عبور الزامی است")]
    [DataType(DataType.Password,ErrorMessage = "کلمه عبور معتبر نیست")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "تکرار کلمه عبور الزامی است")]
    [DataType(DataType.Password,ErrorMessage = "تکرار کلمه عبور معتبر نیست")]
    [Compare(nameof(Password), ErrorMessage = "پسورد ها یکسان نیستند!")]
    public string? PasswordConfirm { get; set; }

    [Required(ErrorMessage = "نام الزامی است")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "نام خانوادگی الزامی است")]
    public string? LastName { get; set; }
}