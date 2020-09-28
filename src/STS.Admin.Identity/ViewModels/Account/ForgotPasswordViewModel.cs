using STS.STS.Identity.Configuration;
using System.ComponentModel.DataAnnotations;
using STS.Shared.Configuration.Identity;

namespace STS.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}






