﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace _0_Framework.Application
{
    public class MaxTemplateSizeAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly int _maxFileSize;

        public MaxTemplateSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }



        public override bool IsValid(object value)
        {
            var file = (IFormFile) value;
            if (file == null) return true;
            return file.Length <= _maxFileSize;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-maxTemplateSize", ErrorMessage);
        }
    }
}
