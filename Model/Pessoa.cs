﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public abstract class Pessoa
    {
        private string nome;
        private string email;

        public string Nome { get => nome; set => nome = value; }        
        public string Email { get => email; set => email = value; }

        //Exercício do commit
        public void ExercicioCommit()
        {
            Console.WriteLine("Marcelim RJ");
        }
    }
}
