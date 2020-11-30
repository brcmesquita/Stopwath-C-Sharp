using System;
using System.Threading;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      System.Console.WriteLine("S = Segundo => 10s = 10 segundos");
      System.Console.WriteLine("M = Minuto => 1m = 1 minuto");
      System.Console.WriteLine("0 = Sair");
      System.Console.WriteLine("Quanto tempo deseja contar?");

      string data = Console.ReadLine().ToLower();
      Console.WriteLine(data);
    }

    static void Start(int time)
    {

      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      System.Console.WriteLine("Stopwatch finalizado.");
      Thread.Sleep(2500);
    }
  }
}
