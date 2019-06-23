using System;
using static BlackJack.returnValue;

namespace BlackJack
{
    /**************************************/
    /*                                    */
    /* プレイヤーとディーラーを表すクラス */
    /*                                    */
    /**************************************/
    class User
    {
        protected string[] cardsAry = new string[10];       //手札を表す配列
        protected int bust = 0;                             //バーストしているか判断するフラグ  0:セーフ　1:バースト
        protected Random rnd;                               //乱数取得のための変数
        protected int cardNum = 0;                          //配列のカウンタ(手札の枚数 - 1)
        protected string hyouji;

        //カードを追加するメソッド
        public virtual void addCard() { }

        //カードを出力するメソッド
        public virtual void ShowCards() { }


        //コンストラクタ
        public User()
        {
            //最初に配られる2枚のカードを手札（配列）に追加
            rnd = new Random();
            cardsAry[0] = getMark(rnd.Next(13) + 1);
            cardsAry[1] = getMark(rnd.Next(13) + 1);
            cardNum = 2;
        }

        public int Bust { get { return this.bust; } }


        //手札の合計を返すメソッド
        public int TotalValue()
        {
            //配列の値をすべて足して返す
            int total = 0;

            for (int i = 0; i < cardNum; i++)
            { total += getValue(cardsAry[i]); }

            return total;
        }

        //Aを11とする場合も考慮して合計を返す
        public int TotalValueAas10()
        {
            int aNum = 0;
            int total = 0;

            for (int i = 0;i < cardNum;i++)
            {
                total += getValue(cardsAry[i]);
                if (cardsAry[i] == "A")
                {
                    aNum += 1;
                }
            }

            //Aの数分10を足す
            for (int i = 0; i < aNum; i++)
            {
                if ((total + 10) <= 21)
                {
                    total += 10;
                }
            }

            return total;

        }
    }
}
