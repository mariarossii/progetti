using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using System.Xml.Serialization;
using static System.Console;
using System.Drawing; //per scrivere solo read e write invece che console. 

namespace ConsoleAppPonte
{
    internal class Program
    {
        //ponte che permette passaggio di veicoli, più di uno alla volta per corsia
        //in ciascuna corsia invece può passare una macchina alla volta

        static Object _lockConsole = new Object();

        static Thread thM1, thM2, thM3, thM4;

        static void start()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("     ~~~~~~~~~~~~~~~~~~~~~~MARIA ROSSI~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("           ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("               ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("════════════════════════════════════════════════════════════════════════════");
            WriteLine("");
            WriteLine("");
            WriteLine("");
            WriteLine("");
            WriteLine("════════════════════════════════════════════════════════════════════════════");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                     ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("                         ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("               ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("             ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        static void Macchine_r1()
        {
            ForegroundColor = ConsoleColor.Red;

            int posM = 10;

            do
            {
                posM++;
                Scrivi(posM, 10, "      ╔╦ð         ");
            } while (posM < 110);

            lock (_lockConsole)
            {
                SetCursorPosition(112, 2);
            }
        }
        static void Macchine_r2()
        {
            ForegroundColor = ConsoleColor.Yellow;

            int posM = 11;

            do
            {
                posM++;
                Scrivi(posM, 11, "      ╔╦ð         ");
            } while (posM < 110);

            lock (_lockConsole)
            {
                SetCursorPosition(112, 2);
            }
        }
        static void Macchine_r3()
        {
            ForegroundColor = ConsoleColor.Green;

            int posM = 12;

            do
            {
                posM++;
                Scrivi(posM, 12, "      ╔╦ð         ");
            } while (posM < 110);

            lock (_lockConsole)
            {
                SetCursorPosition(112, 2);
            }
        }
        static void Macchine_r4()
        {
            ForegroundColor = ConsoleColor.Blue;
            int posM = 13;

            do
            {
                posM++;
                Scrivi(posM, 13, "      ╔╦ð         ");
            } while (posM < 110);

            lock (_lockConsole)
            {
                SetCursorPosition(112, 2);
            }
        }

        static void Scrivi(int col, int row, string str)
        {
            Thread.Sleep(50);
            lock (_lockConsole)
            {
                SetCursorPosition(col, row);
                Write(@str);
            }
        }

        static void Main(string[] args)
        {
            CursorVisible = false;
            start();
            thM1 = new Thread(Macchine_r1);
            thM2 = new Thread(Macchine_r2);
            thM3 = new Thread(Macchine_r3);
            thM4 = new Thread(Macchine_r4);
            thM1.Start();
            thM2.Start();
            thM3.Start();


            thM4.Start();
        }
    }
}
