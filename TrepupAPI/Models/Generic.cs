using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrepupAPI.Models
{
    public class SuggestedText
    {
        public string TxtSuggestion { get; set; }
    }

    public class AttrErrorMessage
    {
        public string Attribute { get; set; }
        public string Message { get; set; }
    }
}