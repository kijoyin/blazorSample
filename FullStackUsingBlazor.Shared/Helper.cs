using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackUsingBlazor.Shared
{
    public static class Helper
    {
        public static string  VerySpecialFormatting(this double amount)
        {
            return amount.ToString("0.00");
        }
    }
}
