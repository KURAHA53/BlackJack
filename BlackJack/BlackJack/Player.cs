using System;
using static BlackJack.returnValue;

namespace BlackJack
{
    class Player : User
    {
        //カードを追加するメソッド
        public override void addCard()
        {
            cardsAry[cardNum] = getMark(rnd.Next(13) + 1);
            cardNum++;

            //追加したカードによってバストしたか確認する

            if (this.TotalValue() > 21)
            {
                //バスト
                bust = 1;
            }

        }

        public override void ShowCards()
        {
            hyouji = "あなた：";

            foreach (string s in cardsAry)
            {
                hyouji += s + "_";
            }

            hyouji = hyouji.Trim('_');

            Console.WriteLine(hyouji);
        }

    }
}
