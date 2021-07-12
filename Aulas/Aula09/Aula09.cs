using System;
class Aula09{ //Operações de Bitwise ou operadores de SHIFT. << (para a esquerda) dobra o valor da variável e >> (para a direita) divide pela metade o valor.
    static void Main(){

        int num1=10;
        int num2=12;

        num1=num1<<1; //aqui o número vai dobrar um vez
        num2=num2>>2; //aqui p número vai ser dividido na metade duas vezes

        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }
}