using System;
using System.ComponentModel.DataAnnotations;

namespace DemoModal
{
    public class ValuesModal
    {
        [Required(ErrorMessage ="Name is required!!")]
        public string name { get; set; }
        [Required(ErrorMessage ="Amount is required!!")]
        public string amount { get; set; }
    }
}
