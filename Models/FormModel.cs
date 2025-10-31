using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Le nom est requis")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est requis")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner un genre")]
        public string Genres { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit être à 5 chiffres")]
        public string Codepostal { get; set; }

        [Required(ErrorMessage = "La ville est requise")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "L'adresse mail est requise.")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Le format de l'adresse mail est invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une date de début de formation")]
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner la formation suivie.")]
        public string Formation { get; set; }

        public string Cobol { get; set; }

        public string Csharp { get; set; }
    }
}
