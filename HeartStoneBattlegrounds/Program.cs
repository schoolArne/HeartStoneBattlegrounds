using System;
using HeartStoneBattlegrounds.classes;
using HeartStoneBattlegrounds.Classes;

namespace HeartStoneBattlegrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myFirstCard = new Card();
            myFirstCard.Tier = TierType.Tier1;
            myFirstCard.Title = "Rockpool Hunter";
            myFirstCard.MaxHealth = 3;
            myFirstCard.Attack = 2;
            myFirstCard.TribeType = CategoryType.Murloc;
            myFirstCard.Abilities = new string[] { "Battlecry: Give a friendly Murloc +1/+1"};
            myFirstCard.Draw(5, 5);

            Card mySecondCard = new Card();
            mySecondCard.Tier = TierType.Tier2;
            mySecondCard.Title = "Nathrezim Overseer";
            mySecondCard.MaxHealth = 4;
            mySecondCard.Attack = 2;
            mySecondCard.TribeType = CategoryType.Demon;
            mySecondCard.Abilities = new string[] { "Battlecry: Give a friendly Demon +2/+2" };
            mySecondCard.Draw(20, 8);

            mySecondCard.Draw(20, 20);


            Console.Clear();
            Minion minionPlayerA = myFirstCard.Summon();
            Minion minionPlayerB = mySecondCard.Summon();

            minionPlayerA.Draw(1, 1);
            minionPlayerB.Draw(1, 20);

            Console.WriteLine(minionPlayerA.ActualHealth);
            minionPlayerB.DoeAttack(minionPlayerB);
            Console.WriteLine(minionPlayerA.ActualHealth);



            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.ReadLine();
        }
    }
}
