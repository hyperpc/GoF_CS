using System.Reflection;
using System;
using System.Configuration;
//dotnet add package System.Configuration.ConfigurationManager --version 4.7.0

namespace ch07_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Score : sort, search => single adapter: IScoreOperation
            {
                /*
                var adapterStr = ConfigurationManager.AppSettings["adapter"];
                var operation = (Score.ScoreOperation)Assembly.Load("ch07_Adapter").CreateInstance(adapterStr);
                int[] scores = {84,76,50,69,90,91,88,96};
                int[] result;
                int score;
                System.Console.WriteLine("Score Sort: ");
                result = operation.Sort(scores);

                foreach (var item in result) {
                    System.Console.Write(item +",");
                }
                System.Console.WriteLine();
                System.Console.Write("Search score 90: ");
                score = operation.Search(result, 90);
                if(score!=-1){
                    System.Console.WriteLine("Found score 90.");
                }else{
                    System.Console.WriteLine("Not found score 90.");
                }
                System.Console.Write("Search score 92: ");
                score = operation.Search(result, 92);
                if(score!=-1){
                    System.Console.WriteLine("Found score 92.");
                }else{
                    System.Console.WriteLine("Not found score 92.");
                }
                */
            }

            // Exercise 1. Animal: cat.eatFish, dog.eatBone => double adapter
            {                
                System.Console.Write("Cat ");
                var cat = new Animal.Cat();
                cat.EatFish();

                System.Console.Write("Dog ");
                var dog = new Animal.Dog();
                dog.EatBone();

                var adapter = new Animal.EatAdapter(cat, dog);
                System.Console.Write("Cat ");
                adapter.EatFish();
                System.Console.Write("Dog ");
                adapter.EatBone();
            }

            // Exercise 2. Player: WMPlayer.WPlay, RealPlayer.RPlay, NewPlayer.NPlay => single adapter, IPlayer.Play()

            // Exercise 3. OAEcryption: ThirdParty.Encrypt() => single adapter: IEncryption.Encrypt()

            Console.ReadKey();
        }
    }
}
