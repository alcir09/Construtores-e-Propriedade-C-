using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores{
    
    class Program {

        public delegate void Operacao(int x, int y);

        static void Main(string[] args){

            Matematica m = new Matematica(10, 20);

            m.Somar();

            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            // op.Invoke(10,10);

            // op(10,20);

            // const double pi = 3.14;

            // System.Console.WriteLine(pi);

            // Data data = new Data();

            //data.SetMes(20);

            // data.Mes = 3;

            //System.Console.WriteLine(data.Mes);

            //System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Aluno p1 = new Aluno("Alcir", "Amorim", "ADS");
            //  p1.Apresentar();

            // Log log = Log.GetInstance();

            // log.PropiedadeLog = "Teste instância";

            // Log log2 = Log.GetInstance();

            // System.Console.WriteLine(log2.PropiedadeLog);

            //  Pessoa p1 = new Pessoa("Alcir", "Amorim");
            //  p1.Apresentar();

        }

    }

}
