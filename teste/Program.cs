using System;
using teste.Controller;
namespace teste {
    class Program {
        static void Main (string[] args) {
            UsuController Usu = new UsuController ();
            Console.Clear ();
            Usu.DadoNome ();
            Usu.ExibirDados();
        }
    }
}