using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Validation
{
    public class MaxWordsAttribute:ValidationAttribute
    {
        public MaxWordsAttribute(int maxWords) : base("{0} has too many words.!!")
        {
            // constructor
            _maxWords = maxWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);



                }
            }
            return ValidationResult.Success;



        }
        private readonly int _maxWords;
    }
}