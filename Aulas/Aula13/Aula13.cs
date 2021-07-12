using System;
class Aula13{
    static void Main(){

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