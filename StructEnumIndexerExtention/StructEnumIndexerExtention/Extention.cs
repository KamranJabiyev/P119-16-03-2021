using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace StructEnumIndexerExtention
{
    public static class Extention
    {
        public static bool IsMail(this string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static double GetPower(this int number,int power)
        {
            return Math.Pow(number, power);
        }

        public static int[] AddItem(this int[] arr, int number)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = number;

            return arr;
        }
    }
}
