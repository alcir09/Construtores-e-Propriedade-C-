using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores{
    
    class Program {

        static void Main(string[] args){

            Aluno p1 = new Aluno("Alcir", "Amorim", "ADS");
             p1.Apresentar();

            // Log log = Log.GetInstance();

            // log.PropiedadeLog = "Teste instância";

            // Log log2 = Log.GetInstance();

            // System.Console.WriteLine(log2.PropiedadeLog);

            //  Pessoa p1 = new Pessoa("Alcir", "Amorim");
            //  p1.Apresentar();

        }

    }

}
