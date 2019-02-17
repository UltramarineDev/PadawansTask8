using System.Text;
using System;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            // put your code here
            // throw new NotImplementedException();
            if (text == null)
            {
                throw new ArgumentNullException();
            }

            if (text == "")
            {
                throw new ArgumentException();
            }
            char[] arr;
            arr = text.ToCharArray();

            List<string> list = new List<string>();
            var index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ' || arr[i] == '.' || arr[i] == ',' || arr[i] == '!' || arr[i] == '?' || arr[i] == '-' || arr[i] == ':' || arr[i] == ';')
                {
                    string stringTemp = "";
                    for (int j = index; j < i; j++)
                    {
                        stringTemp += arr[j];
                    }
                    index = i + 1;
                    list.Add(stringTemp);
                    list.Add(arr[i].ToString());
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {

                    if (list[i].CompareTo(list[j]) == 0 && list[i] != " " && list[i] != "." && list[i] != "," && list[i] != "!" && list[i] != "?" && list[i] != "-" && list[i] != ":" && list[i] != ";")
                    {
                        list[j] = "";
                    }
                }
            }

            string result = String.Join("", list);
            text = result;
        }
    }
}
