
using System;
using System.Globalization;
using System.Xml;


namespace PrimeiroProjetoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y, z, p, cpf1, cpf2;
            Times a, b, c, d;
            

            x = new Pessoa();
            z = new Pessoa();

            a = new Times();
            b = new Times();
            c = new Times();

            cpf1 = new Pessoa();
            cpf2 = new Pessoa();


            x.Nome1 = "Pedrin";
            z.Nome2 = "joaquina";

            a.Nome = "Liqud";
            a.Titulos = 50;
            a.Color = "Azul";


            b.Nome = "FaZe";
            b.Titulos = 40;
            b.Color = "Red";

            c.Nome = "NiP";
            c.Titulos = 35;
            c.Color = "Green";

            cpf1.CPF = 909090;
            cpf2.CPF2 = 101010;

            Console.WriteLine(a.Nome + " " + b.Nome + " e " + c.Nome  + " Esses times fazem parte do RainbowSix") ;
            Console.WriteLine("O " + x.Nome1 + " disse que o time preferido dele é a " + a.Nome);
            Console.WriteLine("A " + z.Nome2 + " disse que o time preferido dela é a " + b.Nome);
            Console.WriteLine("Somando os títulos da " + a.Nome+  " e " + b.Nome + " Teremos o resultado " + (a.Titulos + b.Titulos));
            Console.WriteLine("O CPF do " + x.Nome1 + " é " + cpf1.CPF + " e o da " + z.Nome2 + " é " + cpf2.CPF2);

            
             



        }
    }
}

