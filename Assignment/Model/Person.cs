using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Assignment.Model
{
    public class Person
    {
        public int Id { get; set; }

        [Required, MaxLength(20)] [NotNull]  public string FirstName { get; set; }
        [NotNull] [Required, MaxLength(30)] public string LastName { get; set; }
        [ValidHairColor] [Required] public string HairColor { get; set; }
        [NotNull] [ValidEyeColor] [Required] public string EyeColor { get; set; }
        [NotNull, Range(1, 125)][Required] public int Age { get; set; }
        [NotNull, Range(1, 250)][Required] public float Weight { get; set; }
        [NotNull, Range(30, 250)][Required] public int Height { get; set; }

        [NotNull]
        [Required, MaxLength(1, ErrorMessage = "Sex can be only M or F"),]

        public string Sex { get; set; }

        public void Update(Person toUpdate)
        {
            Age = toUpdate.Age;
            Height = toUpdate.Height;
            HairColor = toUpdate.HairColor.ToUpper();
            Sex = toUpdate.Sex.ToUpper();
            Weight = toUpdate.Weight;
            EyeColor = toUpdate.EyeColor.ToUpper();
            FirstName = toUpdate.FirstName;
            LastName = toUpdate.LastName;
        }
    }

    public class ValidHairColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "blond", "red", "brown", "black",
                "white", "grey", "blue", "green", "leverpostej"
            }.ToList();
            if (valid == null || valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
        }
    }

    public class ValidEyeColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "brown", "grey", "green", "blue",
                "amber", "hazel"
            }.ToList();
            if (valid != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
        }
    }
}