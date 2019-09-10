using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateKeikyuLedAging
{
    class Program
    {
        static void Main(string[] args)
        {
            //時刻表取得を書く
            Console.WriteLine("取得する時刻表のURLを入力してください\n> ");
            String sUri = Console.ReadLine();
            Console.WriteLine("出力するファイル名を入力してください\n> ");
            String sOutputFileName = Console.ReadLine();

            //時刻表をパースして時刻と種別・行先に分離する
            //劣化度を計算する
            //ビットマップなどに吐く
        }
    }
}
