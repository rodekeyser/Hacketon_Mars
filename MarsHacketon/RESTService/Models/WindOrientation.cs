using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RESTService.Models
{
    public class WindOrientation
    {
        [Key]
        public int Id { get; set; }
        public int Value{get; set;}
        public int Orientation { get;set;}
    }
}