using System;
class Aula03{
    static void Main(){
        //variáveis primitivas
        byte n1=10; // byte= int só q é de 8bits, armazena valores entre 0 e 255
        int num1,num2,res; //inteiro pode receber sinal " - "
        
        num1=10;
        num2=2;
        res = num1 + num2;

        Console.WriteLine(" A soma de " + num1 + " + " + num2 + " é igual a: " + res);

        /*char letra='c'; // armazena apenas um caracter, usa ' ' e não " " do string
        float valor=5.3f; //recebe pontos flutuantes
        //variáveis do tipo referência
        string nome="Huelton"; //é um conjunto de "char"


        var aux=10; //Mesmo sendo fortemente tipada vc pode declarar o var que é uma variável não especifica. O compilador que define.
        var aux1=nome;

        Console.WriteLine(aux);
        Console.WriteLine("Valor da variável: "+aux1);*/



    }
}