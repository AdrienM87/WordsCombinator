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
    }
}
