using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        List <string> compras = new List<string>();
        int opcao = 0;

        do{
            Console.WriteLine("==== Lista de compras ====");
            Console.WriteLine("1 = Adicionar produto");
            Console.WriteLine("2 = Remover produto");
            Console.WriteLine("3 = Ver lista");
            Console.WriteLine("4 = Sair");

            if(!int.TryParse(Console.ReadLine(), out opcao) || opcao > 4 || opcao < 1){
                Console.WriteLine("Opcao invalida!");
                continue;
            }

            switch(opcao){
                case 1:
                    Console.WriteLine("Informe o nome do produto: ");
                    string produto = Console.ReadLine();

                    compras.Add(produto);

                    Console.WriteLine("Produto adicionado.");
                    break;
                case 2:
                    Console.WriteLine("Informe o nome do produto");
                    string remover = Console.ReadLine();

                    if(compras.Remove(remover)){
                        Console.WriteLine("Produto removido.");
                    }else{
                        Console.WriteLine("Produto nao encontrado!");
                    }
                    break;
                case 3:
                    if(compras.Count > 0){
                        for(int i = 0; i < compras.Count; i++){
                            Console.WriteLine($"{i + 1} - {compras[i]}");
                        }
                    }else{
                        Console.WriteLine("Lista de compras vazia!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }
        }while(opcao!=4);
    }
}