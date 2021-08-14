using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace rpg
{

    public class GameEngine 
    {
    	//D dano V valor
        public static int cash = 10000;
        public static int valor;
        public static int Vfazenda = 1000;
        public static int Vcomida = 3000;
        public static int Vguerreiro = 100;
        public static int Dguerreiro = 5;
        public static int Vescudo = 20000;
        public static int Varqueiro = 180;
        public static int Vlanceiro = 250;
        public static int Vcavaleiro = 500;
        public static int Dcavaleiro = 20;
        public static int Darqueiro = 10;
        public static int Dlanceiro = 15;
        
        
        
        public static void add(float money){
        
            //Funcao recebe valor e adiciona
        	cash = cash + valor;
        }
        public static void rev(int money){
        	cash = cash - Vfazenda;
        }
    }
}