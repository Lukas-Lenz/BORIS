using System.ComponentModel.DataAnnotations;

namespace BORIS.Models
{
    public class ContactViewModel
    {

        [Required(ErrorMessage = "Bitte geben Sie einen Namen an")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Die eingegbene E-Mail ist ungültig")]
        [Required(ErrorMessage = "Bitte geben Sie eine E-Mail an")]
        public string EMail { get; set; }
        public string PreferredLocation { get; set; }
        public Specialisation? PreferredSpecialisation { get; set; }

        [Required]
        [Display(Name = "Ich stimme zu, dass meine Daten ")]
        public bool DataConsent { get; set; }

    }
}
