﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    class ContatoModel
    {
        //public int id { get { return id; } set { id = value; } }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public ContatoModel(/*int id, */string nome, string sobrenome, string telefone, string email)
        {
            //this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.email = email;
        }

        public string NomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(NomeCompleto(nome, sobrenome).ToString())
                   .Append(", ")
                   .Append(telefone)
                   .Append(", ")
                   .Append(email);
            return builder.ToString();
        }
    }
}
