using System;

namespace BlackJack
{
    /**************************************/
    /*                                    */
    /* 勝ち負けを判断する処理のクラス 　　*/
    /*                                    */
    /**************************************/

    class BlackJackResult
    {
        public void Result(Player player, Dealer dealer)
        {

            //プレイヤーがバストしている場合
            if (player.Bust == 1)
            {
                Console.WriteLine("対戦結果");
                dealer.ShowAllCards();
                player.ShowCards();
                Console.WriteLine("");
                Console.WriteLine("あなたはバストしました。あなたの負けです");
                return;
            }

            //ディーラーがバストしている場合
            if (dealer.Bust == 1)
            {
                Console.WriteLine("対戦結果");
                dealer.ShowAllCards();
                player.ShowCards();
                Console.WriteLine("");
                Console.WriteLine("ディーラーがバストしましたあなたの勝ちです。");
                return;
            }

            //どちらもバストしていない場合
            if (player.TotalValueAas10() > dealer.TotalValueAas10())
            {
                Console.WriteLine("対戦結果");
                dealer.ShowAllCards();
                player.ShowCards();
                Console.WriteLine("");
                Console.WriteLine("ディーラー:" + dealer.TotalValueAas10() + "、あなた：" + player.TotalValueAas10() + "　あなたの勝ちです。");
                return;
            }

            if (player.TotalValueAas10() <= dealer.TotalValueAas10())
            {
                Console.WriteLine("対戦結果");
                dealer.ShowAllCards();
                player.ShowCards();
                Console.WriteLine("");
                Console.WriteLine("ディーラー:" + dealer.TotalValueAas10() + "、あなた：" + player.TotalValueAas10() + "　あなたの負けです。");
                return;
            }

            dealer.ShowAllCards();
            Console.WriteLine("-----------------------------------");
            player.ShowCards();
            Console.WriteLine("");

        }

    }
}
