using CoursPOO.Demo14Generic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursPOO.Demo14Generic.Tools
{
    internal static class ArrayUtils
    {
        public static int FindPosition(List<string> list, string search)
        {
            int position = -1;
            for (int i = 0; i < list.Count() && position == -1; i++)
            {
                if (list[i] == search)
                {
                    position = i;
                }
            }
            return position;
        }

        public static int FindPosition<T>(List<T> list, T search)
            where T : IEquatable<T>
        {
            int position = -1;
            for (int i = 0; i < list.Count() && position == -1; i++)
            {
                if (list[i].Equals(search))
                {
                    position = i;
                }
            }
            return position;
        }

        public static int FindPosition<T>(List<T> list, 
            /* Comment faire la comparaison (delegate) */
            Func<T, bool> fnComparaison
            )
        {
            int position = -1;
            for (int i = 0; i < list.Count() && position == -1; i++)
            {
                /*Delegate*/
                if (fnComparaison(list[i]))
                {
                    position = i;
                }
            }
            return position;
        }
    }
}
