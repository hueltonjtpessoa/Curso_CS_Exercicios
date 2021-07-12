using System;
class Aula10{ //Enumeradores (enum), permite criar um tipo próprios com valroes prédefinido.

enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){

        DiasSemana ds = (DiasSemana)3; //expressão cast: para executar uma conversão explícita. Ele esta querendo identificar dentro de Diassemana a posição 3.
        
        int dsNumInd = (int)DiasSemana.Sexta;//aqui ele está pegando o indice do tipo DiasSemana, que no caso e sexta=5

        Console.WriteLine(ds);
        Console.WriteLine(dsNumInd);
    }
}