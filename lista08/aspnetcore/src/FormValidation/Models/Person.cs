using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation.Models
{
    public class Car
    {   // nr rejestracyjny / data / marka / rok / rodzaj paliwa
        public int Id { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]{2,3}[0-9]{4,6}", ErrorMessage = "Podany kod pocztowy jest niepoprawny")]
        public string RegNum { get; set; }
        [Required]
        [RegularExpression("[0-9]{2}-[0-9]{2}-[0-9]{4}", ErrorMessage = "Podany nr rejestracyjny jest niepoprawny")]
        public string Date { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]{1,40}", ErrorMessage = "Podany kod pocztowy jest niepoprawny")]
        public string Producent { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Fuel { get; set; }

        
    }
}
