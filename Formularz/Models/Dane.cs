using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj Hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną małą literę, jedną dużą literę i jedną cyfrę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdź Hasło")]
        [Compare("Haslo", ErrorMessage = "Hasło i potwierdzenie hasła muszą być identyczne")]
        public string PowtorzHaslo { get; set; }

        [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
        public string? NrTel { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale od 10 do 80 lat")]
        public int? Wiek { get; set; }

        public string? Miasto { get; set; }


        public Kategorie Kategoria { get; set; }
        public enum Kategorie { Low = 1, Normal = 2, High = 3 }
    }
}
