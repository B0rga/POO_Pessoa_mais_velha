using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto30.Models{
    
    public class Pessoa{
        
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa(){}
        public Pessoa(string nome, int idade){
            this.nome = nome;
            this.idade = idade;
        }
    }
}