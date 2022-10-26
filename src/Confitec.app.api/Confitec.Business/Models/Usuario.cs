﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Confitec.Business.Models
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Escolaridade { get; set; }
    }
}
