using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZAD_WEB_1b.Areas.SpravaZpravy.Models
{
    public class Modesilani
    {
       [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Odesilatel musi mit minimalne 3 a maximalne 30 znaku")]
        public string Odesilatel { get; set; } = "";


        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Odesilatel musi mit minimalne 3 a maximalne 30 znaku")]
        public string Prijemce { get; set; } = "";


        [Required]

        public string Zprava { get; set; } = "";    

        public Modesilani()                    
        {

        }
        // Další možnosti atributů
        // [StringLength(30, MinimumLength = 10, ErrorMessage = "delka musi byt minimalne 10 a maximalne 30 znaku")]
        // [Range(100, 50000, ErrorMessage = "velikost musi byt minimalne 100 a maximalne 50000 znaku")]
        // [Display(Name = "Zadejte velikost")]
    }



}

