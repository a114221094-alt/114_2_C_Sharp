using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class Coin
    {
        private string sideUp; // 儲存硬幣的正面或反面

        public Coin()
        {
            // 建構子，初始化硬幣的正面或反面
            Toss();
        }

        public void Toss()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
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
