﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
 *  Collide
 *  Eine Simulation im 2-dimensionalen Raum
 *  Aufgabenverteilung
 *  a) Ausserer Alex
 *  b) Ritsch Julian
 *  c) Verdorfer Martin
 *  d) Pircher Marjan
 * 
 * 2020 TFO-Meran
 */

namespace ConsoleApplication1

{
    
    class Program
    {
        
        const int seite = 50;
        static int[,] feld = new int[seite, seite];

        class einer
        {
            // Private Eigenschaften

            // Öffentliche Eigenschaften
            public int posx, posy;
            public ConsoleColor farbe;
            // Konstruktor
            public einer()
            {
            }
            //Private Methoden
            void show()
            {
            }
            void hide()
            {
            }
            void collide()
            {
            }
            //Öffentliche Methoden
            public void Move()
            {
            }

        }

        static void Main(string[] args)
        {
            

            Console.WindowWidth = seite*2;
            Console.WindowHeight = seite;
            Console.Clear();
            Random ZG = new Random();
            int Anzahl=ZG.Next(1,6);
            einer[] meineEiner = new einer[Anzahl];
            for (int i = 0; i < Anzahl; i++)
            {
                meineEiner[i] = new einer();
            }
            Console.CursorVisible = false;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < Anzahl; j++)
                {
                    meineEiner[j].Move();
                }
                System.Threading.Thread.Sleep(10);

            }

            SaveConfig(Anzahl);
            LoadConfig(ref Anzahl);

        }
        static bool LoadConfig(ref int Anzahl)

        {
            bool status;
            var path = @"C:\Users\marja\Desktop\AufgabeD\4_Collide\Collision\config.ini";
            StreamReader reader = new StreamReader(path);

             var Anzahl2 = reader.ReadToEnd();
             Anzahl = Convert.ToInt32(Anzahl2);

             reader.Close();

             Console.WriteLine(Anzahl);
            
             if (path == @"C:\Users\marja\Desktop\AufgabeD\4_Collide\Collision\config.ini" || !(Anzahl == 0))
             {
                 status = true;
             }
             else
             {
                 status = false;
             }
            return status;
             
        }
        static bool SaveConfig(int Anzahl)
        {
            var path = @"C:\Users\marja\Desktop\AufgabeD\4_Collide\Collision\config.ini";
            StreamWriter writer = new StreamWriter(path);
             Anzahl = 12;

             bool status;

            //writer.Write(Anzahl);
             writer.Close();
            
             if (path == @"C:\Users\marja\Desktop\AufgabeD\4_Collide\Collision\config.ini")
             {
                 status = true;
             }
             else
             {
                 status = false;
             }
             return status;

        }
       
        

       
    }
}
