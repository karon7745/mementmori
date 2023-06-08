using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mement
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int my, ene = 0;
            Console.WriteLine("じゃんけんの手を選んでください");
            Console.Write("1.グー　2.チョキ　3.パー:");
            my = int.Parse(Console.ReadLine());
            Battel battel = new Battel();

        }
    }

    

    public class Battel
    {
        enum Janken : byte
        {
            グー = 1,
            チョキ,
            パー
        }

        Janken[] janken = new Janken[2];

        public string Jan(int n)
        {
            janken[0] = (Janken)Enum.ToObject(typeof(Janken), n);
            return janken[0].ToString();
        }

        public bool test(int anser)
        {
            return 1 + 1 == anser;
        }

    }
}
