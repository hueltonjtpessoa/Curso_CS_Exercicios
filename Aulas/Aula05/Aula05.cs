using System;
class Aula05{

    static void Main(){

        /*bool res=10<5; //Operadores relacionais ( <  >  >=  <=  != )

        int num=10;

        num++; //num+=1; //num=num+1;
        //num*=2;num=num*2; Podemos usar para 4 operações



        Console.WriteLine(res);
        Console.WriteLine(num);*/

        // Operadores Lógicos
        // & = AND (E)
        // | = OR (OU)
        
        bool res=(5>3)&(10<5);
        bool res1=(5>3)|(10<5);

        Console.WriteLine(res);
        Console.WriteLine(res1);

    }
}