using System;
using teste.Model;
namespace teste.Controller {
    public class UsuController {
        UsuModel Usu = new UsuModel ();

        public void DadoNome () {
            try {
                Console.WriteLine ("Olá, meu nome é Manuel e estou aqui para te ajudar com sua saúde!");
                Console.Write ("Primeiro digite seu nome: ");
                Usu.NomeUsu = Console.ReadLine ();

                Console.WriteLine ("\nQual sua altura?\n");
                Usu.Altura = double.Parse (Console.ReadLine ());

                Console.WriteLine ("\nQuanto você pesa atualmente?\n");
                Usu.Peso = double.Parse (Console.ReadLine ());

                Usu.Resultado = Usu.Peso / (Usu.Altura * Usu.Altura);

            } catch (SystemException) { }
        }

        public void ExibirDados () {
            Console.WriteLine ("Bom " + Usu.NomeUsu + ", temos algumas noticias pra você!");
            if (Usu.Resultado < 18.5) {
                Usu.IMC = "abaixo do peso!";
            } else if (Usu.Resultado >= 18.5 && Usu.Resultado <= 25) {
                Usu.IMC = "no peso ideal!";
            } else {
                Usu.IMC = "acima do peso!";
            }

            Console.Write ("Seu imc altual é de " + Usu.Resultado + " o que signica que você está " + Usu.IMC);
        }
    }
}