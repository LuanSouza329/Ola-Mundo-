using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code01
{
    public class Pessoa
    {   
        private string nome = "";
        private string cpf = "";

        public Pessoa (string nome, string cpf)
        {
            this.nome = nome;

            this.cpf = cpf;
        }
        public string Nome
        {
            get {return this.nome;}
            set {this.nome = value;}
        }
        public string CPF
        {
            get 
            {
                return FormatarCPF (cpf);
            }
            set {this.cpf = value;}
            
        }
        private string FormatarCPF(string cpf)
        {
            if (cpf.Length == 11)
            {
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
            }
            else if (cpf.Length == 10)
            {
               return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 1)}";
            }
            return cpf;
        }
    }
}