using System;
using System.ComponentModel.DataAnnotations;

namespace top_lista.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Required, MaxLength(40)]
        public string Ime { get; set; }

        [Required, MaxLength(40)]
        public string Prezime { get; set; }
        
        public int Minutes { get; set; } = 0;
        public int Seconds { get; set; } = 0;
        public int Miliseconds { get; set; } = 0;

        public bool IsApproved { get; set; } = false;
    }
}
