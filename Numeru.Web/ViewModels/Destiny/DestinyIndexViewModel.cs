using System;
using System.ComponentModel.DataAnnotations;

namespace Numeru.Web
{
    public class DestinyIndexViewModel
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
    }
}
