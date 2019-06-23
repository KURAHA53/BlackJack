using System;

namespace BlackJack
{
    /*********************/
    /*                   */
    /* メインの処理      */
    /*                   */
    /*********************/
    class BlackJackMain
    {
        static void Main(string[] args)
        {
            int gameFlg = 1;

            while (gameFlg == 1)
            {

                //プレイヤーとディーラーを作成
                Player player = new Player();
                System.Threading.Thread.Sleep(500); // sleep in 0.5 sec.
                Dealer dealer = new Dealer();

                dealer.ShowCards();
                player.ShowCards();

                //ドローフェーズ
                BlackJackDraw bjdraw = new BlackJackDraw();
                bjdraw.Draw(player, dealer);

                //勝ち負けを確認する
                BlackJackResult bjresult = new BlackJackResult();
                bjresult.Result(player, dealer);

                Console.WriteLine("もう一度対戦しますか？ YES:1 ,NO:2");
                gameFlg = int.Parse(Console.ReadLine());
            }
        }
    }
}