﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DanielProva01Exercicio.Models
{
    public class ProfessorModel
    {
        [Key]
        public int ID { get; set; }


        [Display(Name ="Nome:")]
        [Required(ErrorMessage ="Informe o Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereco:")]
        [Required(ErrorMessage = "Informe o Endereço")]
        public string Endereco { get; set; }

        [Display(Name ="Telefone:")]
        [Required(ErrorMessage ="Informe o Telefone:")]
        public string Telefone { get; set; }

        [Display(Name ="E-mail:")]
        [EmailAddress(ErrorMessage ="Informe o E-mail")]
        public string Email { get; set; }

        [Display(Name ="Disciplina:")]
        [Required(ErrorMessage ="Informe a Disciplina")]
        public string Disciplina { get; set; }

    }
}