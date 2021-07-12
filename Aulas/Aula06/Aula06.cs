using System;
class Aula06{
    static void Main(){


        /*int n1,n2,n3;

        n1=10; n2=20; n3=30;

        Console.Write("\nn1=\t{0} \nn2=\t{1} \nn3=\t{2}\n", n1,n2,n3); //inclusão de indices
        // o "\n" é = ao Enter, ou seja uma quebra de linha.
        // o "\t" é = a tab (tabulação), ou seja ele irá afastar um pouco.*/

        //Formatando a saída no console
        double valorCompra=2.20;
        double valorVenda;
        double lucro=1.3;
        string produto="Bolacha Suiça";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto......:{0,15}",produto); //{0} = puxando o indice 0 que nesse cado = produto. {15} igual ao espaçamento 
        Console.WriteLine("Val.Compra...:{0,15:c}",valorCompra); // c = formato de saída monetário  
        Console.WriteLine("Lucro........:{0,15:p}",lucro); // p = formato de saída em porcentagem
        Console.WriteLine("Val.Venda....:{0,15:c}",valorVenda);

    }
}