using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRIS_Lab7.Libs
{
    internal class Captch
    {
        public string captch;
        private string abc = "АБВГДЖЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЯ";
        public string Create()
        {
            string combination = $"0123456789{abc}{abc.ToLower()}";
            captch = null;

            Random r = new Random();
            for(int i = 0; i < 5; i++) {
                captch += combination[r.Next(combination.Length)]; 
            }

            return captch;
        }
    }
}
