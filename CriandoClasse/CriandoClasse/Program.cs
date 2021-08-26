using System;

namespace CriandoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // criar objeto da classe BichinhoVirtual
            BichinhoVirtual Bichinho;

            // instanciar o objeto
            Bichinho = new BichinhoVirtual();

            //Atribuindo valores
            Bichinho.Nome = "Tamagotchi";
            Bichinho.Idade = 18;

            Console.WriteLine(Bichinho);
        }
    }
}
