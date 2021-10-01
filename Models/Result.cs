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

        [Required, DataType(DataType.Time)]
        public DateTime Vrijeme { get; set; }

        public bool IsApproved { get; set; } = false;
    }
}
