using System;
class Aula15{ //Como usamos o Comando "switch"
    static void Main(){

        int tempo=0;
        char escolha;

        Console.WriteLine("Viagem Paulista-PE a Caruaru/PE");
        Console.WriteLine("Escolha o transporte:[a] Avião | [c]Carro | [o]Ônibus ");

        escolha=char.Parse(Console.ReadLine());
            //Ele compara uma variável com a sua constante (case), o que for semelhante a expressão fixada, terá seu bloco de comandos executado. Ex.: Chat Bot
        switch(escolha){ 
            case 'a':
            case 'A':
                tempo=30;
                break; //sempre no final do bloco de comandos precisamos colocar o "Break".
            case 'c':
            case 'C':
                tempo=120;
                break;
            case 'o':
            case 'O':
                tempo=180;   
                break;
            default: //Ele só executará o "default" caso não encontre nenhum correspondente.
                tempo=-1;
                break;         
        }

        if(tempo <0 ){
            Console.WriteLine("Transporte Indisponível");
        }else{
            Console.WriteLine("Para o Transporte escolhido o tempo é: {0} minutos", tempo);
        }
    }
}