using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace rpg
{

    public class Program 
    {
        public static void Main()
        {
        	
Console.SetCursorPosition(12, 4);
Console.WriteLine("Aperte uma tecla, q para sair");
while (Console.ReadKey().KeyChar != 'q'){
	Console.Clear();
	Sparta c = new Sparta();
	
	Console.WriteLine("Escolha sua nacao");
	Console.WriteLine("Para escolher Sparta aperte S");
	Console.WriteLine("Para escolher Sarovia aperte C");
	Console.WriteLine("");
	switch (Console.ReadKey().KeyChar){
		
		case 's':
		 Console.Clear();
		 break;
		case 'c':
		   new GameEngine();
		   new Sarovia();
		   Console.Clear();
		
		  Console.WriteLine("Seu dinheiro:" +GameEngine.cash);
		
		   Console.WriteLine("Sua populacao:"+Sarovia.populacao);
		   
		   Console.WriteLine("Quantidade de fazendas:"+Sarovia.fazenda);
		   Console.SetCursorPosition(0, 4);
		   if (Console.ReadKey().KeyChar == 's'){
		   	  Console.Clear();
		   	  Console.WriteLine("Preço da fazenda:"+GameEngine.Vfazenda);
		   	  Console.WriteLine("Preço da comida:"+GameEngine.Vcomida);
		   	  Console.WriteLine("Preço do escudo:"+GameEngine.Vescudo);
		   	  Console.WriteLine("Preço do guerreiro: "+GameEngine.Vguerreiro);
		   	  Console.WriteLine("Preco do arqueiro: "+GameEngine.Varqueiro);
		   	  Console.WriteLine("Preço do lanceiro: "+GameEngine.Vlanceiro);
		   	  Console.WriteLine("Preço do Cavaleiro: "+GameEngine.Vcavaleiro);
		   	  String toBuy = Console.ReadLine();
		   	  if (toBuy == "bf"){
		   	  	 GameEngine.rev(1000);
		   	         switch (Console.ReadKey().Char){
                                 case 'b':
break;
}
}
		   }
		   
		break;
	}
}
        }
    }
}
