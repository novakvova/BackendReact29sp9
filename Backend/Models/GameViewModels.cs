using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class GameItemViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
    }
    public class GameAddViewModel
    {
        [Required(ErrorMessage = "Забув написати назву")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Провтикав малюнок")]
        public string Image { get; set; }
    }
}