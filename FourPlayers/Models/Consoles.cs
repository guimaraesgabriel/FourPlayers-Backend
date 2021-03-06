﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FourPlayers.Models
{
    public class Consoles
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        public bool Deletado { get; set; }


        //FK


        //ICOLLECTIONS
        public ICollection<UsuariosConsoles> UsuariosConsoles { get; set; }
    }
}