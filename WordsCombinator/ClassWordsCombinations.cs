using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCombinator
{
    public static class ClassWordsCombinations
    {
        /// <summary>
        /// Receive a string list to copy them to clipboard separated by end lines.
        /// </summary>
        /// <param name="listString"></param>
        public static void copyStringListToClipboard(List<string> listString)
        {
            try
            {
                string words = "";
                foreach (string combination in listString)
                {
                    words += combination.ToString() + "\n";
                }
                Clipboard.SetText(words);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Receive a words list and make all combinations (pairs) between them.
        /// </summary>
        /// <param name="listWords"></param>
        /// <returns></returns>
        public static List<string> constructCombinationsList(List<string> listWords)
        {
            List<string> listCombinations = new List<string>();
            try
            {
                for (int i = 0; i < listWords.Count; i++)
                {
                    for (int j = i; j < listWords.Count; j++)
                    {
                        if (listWords[i] != listWords[j])
                        {
                            listCombinations.Add(listWords[i] + " " + listWords[j]);
                            listCombinations.Add(listWords[j] + " " + listWords[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listCombinations;
        }
    }
}
