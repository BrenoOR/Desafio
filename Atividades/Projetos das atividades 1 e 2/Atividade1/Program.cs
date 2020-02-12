using System;
using System.Collections.Generic;

namespace Atividade1
{
    //Classe que calcula e guarda os intervalos
    class Interval
    {
        public List<int> intervalo;

        public Interval(int i, int f)
        {
            intervalo = new List<int>();
            while (i <= f)
            {
                intervalo.Add(i);
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva abaixo a lista de intervalos. Ex.: (x,y),(z,w),(a,b)...");
            Console.WriteLine("Caso queira finalizar escreva 'fim'.");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "fim")
                {
                    break;
                }
                //entrada vai ao contador que já retorna a resposta
                int r = Program.IntervalCounter(input);
                Console.WriteLine(r);
                input = Console.ReadLine();
            }

        }

        //contador
        public static int IntervalCounter(string msg)
        {
            List<Interval> intervalList = new List<Interval>(); //Lista de todos os intervalos calculados no momento
            List<Interval> finalList = new List<Interval>(); //Lista final de todos os intervalos calculados
            int c = 0;
            //Tratamento da entrada para cálculo dos intervalos
            while (c < msg.Length)
            {
                int i = int.Parse(msg.Substring(c + 1, 1));
                int f = int.Parse(msg.Substring(c + 3, 1));
                Interval nextInterval = new Interval(i, f);     //intervalo sendo calculado
                intervalList.Add(nextInterval); //intervalo sendo adicionado à lista de intervalos
                if (msg.Length < 6)
                {
                    break;
                } else
                {
                    msg = msg.Substring(c + 6);
                }
            }
            //Detecção de colisão entre intervalos
            for (int i = 0; i < intervalList.Count - 1; i++)
            {
                for (int j = i + 1; j < intervalList.Count; j++)
                {
                    if (IsInside(intervalList[i], intervalList[j]))
                    {
                        intervalList[i] = Match(intervalList[i], intervalList[j]);
                        intervalList.RemoveAt(j);
                        i = 0;
                        j = i;
                    }
                }
            }

            return intervalList.Count;
        }

        public static Boolean IsInside(Interval a, Interval b)
        {
            int c = 0;
            int[] intrvlA = a.intervalo.ToArray();
            int[] intrvlB = b.intervalo.ToArray();
            if (intrvlA.Length > intrvlB.Length)
            {
                while (c < intrvlB.Length)
                {
                    if (intrvlB[c] < intrvlA[0])
                    {
                        c++;
                    } else if (intrvlB[c] > intrvlA[intrvlA.Length - 1])
                    {
                        return false;
                    } else
                    {
                        return true;
                    }
                }
            } else
            {
                while (c < intrvlA.Length)
                {
                    if (intrvlA[c] < intrvlB[0])
                    {
                        c++;
                    }
                    else if (intrvlA[c] > intrvlB[intrvlB.Length - 1])
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Interval Match(Interval a, Interval b)
        {
            int[] intrvlA = a.intervalo.ToArray();
            int[] intrvlB = b.intervalo.ToArray();
            int i, f;
            if (intrvlA[0] < intrvlB[0])
            {
                i = intrvlA[0];
            } else
            {
                i = intrvlB[0];
            }

            if (intrvlA[intrvlA.Length - 1] > intrvlB[intrvlB.Length - 1])
            {
                f = intrvlA[intrvlA.Length - 1];
            } else
            {
                f = intrvlB[intrvlB.Length - 1];
            }
            Interval resp = new Interval(i, f);
            return resp;
        }

    }
}
