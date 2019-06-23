using System;

namespace BlackJack
{
    /***************************************************/
    /*                                                 */
    /*  カードを追加で引く場合と引かない場合の処理     */
    /*                                                 */
    /***************************************************/
    class BlackJackDraw
    {
        //プレイヤーの選択を定数で管理
        const int YES = 1;
        const int NO = 2;

        public void Draw(Player player, Dealer dealer)
        {
            //ループのフラグ
            int endFlag = 0;

            //プレイヤーの選択を保持
            int choice;

            //プレイヤーがNoを選択するまでループし続ける
            do
            {
                //カードを引くか質問
                Console.WriteLine("もう一枚引きますか？ YESの場合：1, NOの場合：2");
                choice = int.Parse(Console.ReadLine());

                //プレイヤーの選択がYESの時
                if (choice == YES)
                {
                    //プレイヤーにカードを追加する
                    player.addCard();

                    //どちらかがバストしていたらフラグを変更
                    if (player.Bust == 1)
                    {
                        endFlag = 1; break;
                    }

                    //カードを表示する
                    dealer.ShowCards();
                    player.ShowCards();
                    Console.WriteLine("");
                }

                //プレイヤーの選択がNOの時
                if (choice == NO)
                {
                    //ディーラーにカードを追加する
                    dealer.addCard();

                    //ループを抜けるためにフラグを変更
                    endFlag = 1;
                }

            } while (endFlag == 0);
        }
    }
}
