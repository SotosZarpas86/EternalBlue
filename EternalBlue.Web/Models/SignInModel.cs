using System.ComponentModel.DataAnnotations;


namespace EternalBlue.Web.Models
{
    public class SignInModel
    {
        [Required]
        public string Passowrd { get; set; }
    }
}
