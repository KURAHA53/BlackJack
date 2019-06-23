using System;
using static BlackJack.returnValue;

namespace BlackJack
{
    class Dealer : User
    {

        //カードを追加するメソッド
        public override void addCard()
        {
            //手札の合計が17以上になるまで引く
            while (this.TotalValueAas10() < 17)
            {
                cardsAry[cardNum] = getMark(rnd.Next(13) + 1);
                cardNum += 1;

                //追加したカードによってバストしたか確認する
                if (this.TotalValue() > 21)
                {
                    //バスト
                    bust = 1;
                }
            }
        }
        public override void ShowCards()
        {
            hyouji = "ﾃﾞｨｰﾗｰ：?";

            for (int i = 1; i < cardNum; i++)
            {
                hyouji += "_" + cardsAry[i];
            }
            Console.WriteLine(hyouji);
        }

        public void ShowAllCards()
        {
            hyouji = "ﾃﾞｨｰﾗｰ：";

            for (int i = 0; i < cardNum; i++)
            {
                hyouji += cardsAry[i] + "_";
            }
            hyouji = hyouji.Trim('_');

            Console.WriteLine(hyouji);
        }
    }
}
