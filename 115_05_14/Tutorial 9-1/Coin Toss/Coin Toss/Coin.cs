using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class Coin
    {
        Random rand = new Random();
        private string sideUp; // 儲存硬幣的正面或反面

        public Coin()
        {
            // 建構子，初始化硬幣的正面或反面
            sideUp = "正面"; // 預設為正面
        }

        public void Toss()
        {
            //Random rand = new Random();
            int side = rand.Next(2); // 產生0或1的隨機數字
            if (side == 0)
            {
                sideUp = "正面";
            }
            else
            {
                sideUp = "反面";
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
