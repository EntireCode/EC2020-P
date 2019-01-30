using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace EC.Web.ViewModels.Base
{
    public class ValidationResultViewModel
    {
        public string Message { get; }

        public List<ValidationErrorViewModel> Errors { get; }

        public ValidationResultViewModel(ModelStateDictionary modelState)
        {
            Message = "Validation Failed";
            Errors = modelState.Keys.SelectMany(key => modelState[key].Errors.Select(x => new ValidationErrorViewModel(key, x.ErrorMessage))).ToList();
        }
    }
}
