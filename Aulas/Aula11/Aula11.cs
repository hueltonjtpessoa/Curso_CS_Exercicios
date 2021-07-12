using System;
class Aula11{//Typecast, quando é preciso converter um tipo em outro quando a conversão não é implícita.
    static void Main(){

       float n1=10.5f; //pra usar o tipo float precisa colocar esse f após o valor.
       int n2=(int)n1;//Typecast. dentro do () estou indicando explicitamente que estou convertendo o tipo float em int.

       Console.WriteLine(n2);

    }
}