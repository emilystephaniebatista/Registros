using System;
using System.ComponentModel.DataAnnotations;
namespace BlazorFilmes.Shared
{
    public class Registro{
        [Required]
        public string Title {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        //a interrogação serve pra trazer o date sem valor
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        //validar e-mail
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        //dar um valor minimo e máximo de caracteres
        [MinLength(6)]
        public string Password {get; set;}
        [Required]
        //comparar senha
        [Compare("Password")]
        public string ConfirmPassword {get; set;}
        [Required]
        [Compare("Validation")]
        public bool AcceptTermsConditions {get; set;}
        public bool Validation=>true;
    }
}