﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourPlayers.Models
{
    public class JogosContas
    {
        [Key]
        public int Id { get; set; }

        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual StatusJogos StatusJogos { get; set; }

        public int TipoId { get; set; }

        [ForeignKey("TipoId")]
        public virtual TiposContas TiposContas { get; set; }

        public int JogoId { get; set; }

        [ForeignKey("JogoId")]
        public virtual Jogos Jogos { get; set; }

        public int ConsoleId { get; set; }

        [ForeignKey("ConsoleId")]
        public virtual Consoles Consoles { get; set; }
    }
}