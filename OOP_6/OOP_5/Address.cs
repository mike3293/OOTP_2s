using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OOP_6
{
    [Serializable]
    public class Address
    {
        [Required]
        [RegularExpression(@"^[А-Я][а-яА-Я\-]*",
         ErrorMessage = "Страна должна начинаться с заглавной буквы")]
        public string Country { get; set; }
        [Required]
        [RegularExpression(@"^[А-Я][а-яА-Я\-]*",
         ErrorMessage = "Город должен начинаться с заглавной буквы")]
        public string City { get; set; }
        [Street]
        public string Street { get; set; }
        [Required]
        [Range(1, 500)]
        public int Home { get; set; }
        [Required]
        [Range(1, 500)]
        public int Apartment { get; set; }
    }

    public class StreetAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string street = value.ToString();
                if (street.Length > 0 && char.IsUpper(street[0]))
                    return true;
                else
                    this.ErrorMessage = "Улица должна начинаться с заглавной буквы";
            }
            return false;
        }
    }
}
