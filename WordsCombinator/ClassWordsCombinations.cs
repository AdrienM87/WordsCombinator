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
        public static void copyStringListToClipboard(List<string> listCombinations)
        {
            try
            {
                string words = "";
                foreach (string combination in listCombinations)
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
