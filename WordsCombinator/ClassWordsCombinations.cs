/*
 * Created by Adrien Marini - Copyright 2019
 * 
 * Words Combinations is a program created to make words combinations.
 * 
 * LICENCE :
 * 
 * This file is part of Words Combinations.

    Words Combinations is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
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
