using System;
class Aula04{

    static int num=10;//Variável Escopo Global, "Vista" pela class
    static void Main(){
        int num=1;//Variável Escopo Local, "Vista" pelo método MAIN 
    }

    void teste(){
        int num=3;//Variável Escopo Local, "Vista" pelo método teste
        Console.WriteLine(num);
    }

}