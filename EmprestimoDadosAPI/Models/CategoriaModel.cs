﻿using System.ComponentModel.DataAnnotations;

namespace EmprestimoDadosAPI.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
