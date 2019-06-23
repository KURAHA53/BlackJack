using System;

namespace BlackJack
{
    class returnValue
    {
        public static string getMark(int i)
        {
            switch (i)
            {
                case 13: return "K";
                case 12: return "Q";
                case 11: return "J";
                case 1: return "A";
                default: return i.ToString();
            }

        }
        public static int getValue(string s)
        {
            try
            {
                switch (s)
                {
                    case "K": return 10;
                    case "Q": return 10;
                    case "J": return 10;
                    case "10": return 10;
                    case "9": return 9;
                    case "8": return 8;
                    case "7": return 7;
                    case "6": return 6;
                    case "5": return 5;
                    case "4": return 4;
                    case "3": return 3;
                    case "2": return 2;
                    case "A": return 1;
                    default:
                        Console.WriteLine("【エラー発生】" + s + "の値取得に失敗(swichcase文)");
                        return 0;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("【エラー発生】" + s + "の値の取得に失敗しました。:" + e.Message);
                return 0;
            }
        }
    }
}

