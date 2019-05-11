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

    Words Combinations is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Words Combinations.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WordsCombinator
{
    public static class ClassXmlTreatments
    {
        private const string xmlHeader = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n";
        private const string xmlRoot = "<root></root>\n";
        private const string xmlNodeListAttribute = "name";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static XmlDocument OpenXMLFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                    FileStreamUTF8Writing(ref fs, xmlHeader);
                    FileStreamUTF8Writing(ref fs, xmlRoot);
                    fs.Close();
                }

                FileStream xmlStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                doc.Load(xmlStream);
                xmlStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return doc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="text"></param>
        private static void FileStreamUTF8Writing(ref FileStream fs, string text)
        {
            try
            {
                foreach (byte b in Encoding.UTF8.GetBytes(text))
                {
                    fs.WriteByte(b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static Dictionary<string, List<string>> GetWordsListsFromFile(string path)
        {
            Dictionary<string, List<string>> dicoWordsLists = new Dictionary<string, List<string>>();
            try
            {
                XmlDocument doc = OpenXMLFile(path);

                if (doc.DocumentElement.HasChildNodes)
                {
                    foreach (XmlNode nodeList in doc.DocumentElement.ChildNodes)
                    {
                        dicoWordsLists.Add(nodeList.Attributes.GetNamedItem(xmlNodeListAttribute).Value, GetWordsFromList(nodeList));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dicoWordsLists;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private static List<string> GetWordsFromList(XmlNode node)
        {
            List<string> listWords = new List<string>();
            try
            {
                if (node.HasChildNodes)
                {
                    foreach (XmlNode nodeWord in node)
                    {
                        if (listWords.Contains(nodeWord.InnerXml) == false)
                        {
                            listWords.Add(nodeWord.InnerXml);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listWords;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nodesName"></param>
        /// <param name="wordsList"></param>
        public static void EditWordsListFile(string path, string nodesName, List<string> wordsList)
        {
            XmlDocument doc = OpenXMLFile(path);
            try
            {
                if (doc.DocumentElement.HasChildNodes)
                {
                    doc.DocumentElement.RemoveAll();
                }
                foreach (string word in wordsList)
                {

                    XmlElement wordElement = doc.CreateElement(nodesName);
                    wordElement.InnerXml = word;

                    doc.DocumentElement.AppendChild(wordElement);
                }
                doc.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
