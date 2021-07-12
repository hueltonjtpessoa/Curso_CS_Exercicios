using System;
class Aula08{ //Lendo Valores do Teclado
    static void Main(){
        int v1,v2,soma;
        /*string nome;

        Console.Write("Digite seu nome: "); //O método "Write" é pra poder escrever com teclado.
        nome=Console.ReadLine();//O método "Read" é pra retornar o que foi lido pelo teclado
        Console.WriteLine("Olá, {0}!",nome);*/

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine()); //O método "Parse" serve para converter uma valor inserido no teclado para classe Int.
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());// O método "Convert.Toint32" é igual ao "Int.Parse".
        soma=v1+v2;
        Console.WriteLine("{0} + {1} = {2}", v1,v2,soma);
    }
}