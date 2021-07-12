using System;
class Aula12{ //Condicional IF (SE); Ele gera um desvio no fluxo do programa, dependendo do resultado de uma expressão lógica. Caso verdadeiro, ele executa o IF, se não ele segue o fluxo normal do programa.
// Operadores condicionais; < > <= >= == != 
//SE(expreção lógica = verdadeira){executa}
        //Ex.: 10 > 5 = True {Executa}
        //Ex.: 10 < 5 = False {Não Executa}
    static void Main(){

        /*int nota = 80; // a variável nota recebe "80"
        string resultado = "Reprovado"; // a variavel resultado recebe "Reprovado"

        if(nota >= 60){ // dentro dos () inserimos a condição.
            resultado = "Aprovado";
        }

        Console.WriteLine("Resultado:{0}", resultado);*/

        /*int nota = 0;
        string resultado = "Reprovado";

        Console.Write("Qual é a sua nota? ");

        nota = int.Parse(Console.ReadLine()); //Aqui chamamos o tipo "int" e aplicamos o método "Parse" para fazer a conversão

        if(nota>= 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("Resultado: {0}", resultado);*/

        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0; //Aqui inicializamos todas as variáveis em "0".
        string resultado = "Reprovado";

        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());
    
        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=(n1+n2+n3+n4)/4;

        if(res >= 70){
            resultado = "Aprovado";
        }

        Console.WriteLine("Média: {0} - Resultado: {1}",res,resultado);

    }
}