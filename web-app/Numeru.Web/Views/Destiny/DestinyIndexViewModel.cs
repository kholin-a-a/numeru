using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace Numeru.Web
{
    public class DestinyIndexViewModel: IValidatableObject
    {
        public DestinyIndexViewModel()
        {
            this.BirthDate = new DateTime(1970, 1, 1);
        }

        [Required(ErrorMessage = "Заполните, пожалуйста")]
        [Display(Name = "Полное имя при рождении")]
        [MaxLength(512)]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Заполните, пожалуйста")]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }

        public bool Calculated { get; set; }

        public int Number { get; set; }

        public string Prediction { get; set; }

        public CalculationViewModel Calculation { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            var allowedRegex = new Regex("[а-яА-Я ]");
            
            var allAlowed = this.Fullname
                .Select(c => c.ToString())
                .All(c => allowedRegex.IsMatch(c))
                ;

            if (!allAlowed)
            {
                errors.Add(
                    new ValidationResult("Можно вводить только русские буквы и пробелы", new List<string> { nameof(Fullname) })
                );
            }

            return errors;
        }
    }
}
