﻿/*
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
using System.Linq;
using System.Windows.Forms;

namespace WordsCombinator
{
    public partial class FormMain : Form
    {
        #region Load

        private const string configFilePath = @"..\debug\WordsList.xml";
        private const string NEW = "New";

        Dictionary<string, List<string>> wordsLists;
        List<string> listCombinations = new List<string>();
        string listSelected;

        public FormMain()
        {
            InitializeComponent();

            ChargeWordsLists();
        }

        /// <summary>
        /// Chargement de la liste des mots mémorisés dans le controle listbox dédié.
        /// </summary>
        private void ChargeWordsLists()
        {
            try
            {
                wordsLists = ClassXmlTreatments.GetWordsListsFromFile(configFilePath);
                if (!wordsLists.ContainsKey(NEW)) wordsLists.Add(NEW, new List<string>());

                this.LstInitialWords.Items.Clear();
                this.CbWordsLists.Items.Clear();

                string[] listsNames = wordsLists.Keys.ToArray();
                this.CbWordsLists.Items.AddRange(listsNames);
                this.CbWordsLists.SelectedItem = NEW;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Process

        /// <summary>
        /// Appel de la classe de calcul des combinaisons pour récupérer la liste et chargement dans le controle listbox dédié.
        /// </summary>
        private void ProcessCombinations()
        {
            try
            {
                if (this.LstInitialWords.Items.Count == 0) return;
                this.Enabled = false;

                listCombinations = ClassWordsCombinations.ConstructCombinationsList(this.LstInitialWords.Items.Cast<string>().ToList());

                this.LstResults.Items.Clear();
                this.LstResults.Items.AddRange(listCombinations.ToArray());
                this.LbWords.Text = "Mots (" + this.LstInitialWords.Items.Count.ToString() + ") :";
                this.LbCombinations.Text = "Combinaisons (" + this.listCombinations.Count.ToString() + ") :";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Enabled = true;
        }

        /// <summary>
        /// Ajout d'un mot à la liste et traitement du nouveau résultat avec affichages.
        /// </summary>
        private void ProcessAdding()
        {
            try
            {
                if (this.TbInitialWords.Text != "" &&
                    this.LstInitialWords.Items.Cast<string>().ToList().Contains(this.TbInitialWords.Text) == false)
                {
                    wordsLists[this.CbWordsLists.Text].Add(this.TbInitialWords.Text);

                    this.LstInitialWords.Items.Add(this.TbInitialWords.Text);
                    this.TbInitialWords.Text = "";
                    this.TbInitialWords.Select();

                    ProcessCombinations();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Suppression d'un mot à la liste et traitement du nouveau résultat avec affichages.
        /// </summary>
        private void ProcessRemoving()
        {
            try
            {
                if (this.LstInitialWords.SelectedIndex != -1)
                {
                    wordsLists[this.CbWordsLists.Text].Remove(this.LstInitialWords.SelectedItem.ToString());

                    this.LstInitialWords.Items.RemoveAt(this.LstInitialWords.SelectedIndex);
                    if (this.LstInitialWords.Items.Count != 0)
                    {
                        this.LstInitialWords.SelectedIndex = 0;
                    }
                }
                ProcessCombinations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Copie de la liste des combinaisons dans le presse-papier.
        /// </summary>
        private void ProcessCopy()
        {
            try
            {
                ClassWordsCombinations.CopyStringListToClipboard(listCombinations);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Effacement du contenu des contrôles d'affichage des résultats
        /// </summary>
        private void ProcessClearing()
        {
            try
            {
                this.LstInitialWords.Items.Clear();
                this.LstResults.Items.Clear();
                this.LbCombinations.Text = "";
                this.LbWords.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Keyboard

        /// <summary>
        /// Vérifie si le raccourci clavier Ctrl + C a été exécuté.
        /// </summary>
        /// <param name="e"></param>
        private void ProcessCheckCopyKeys(KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    ProcessCopy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProcessCheckCopyKeys(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TbInitialWords_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProcessAdding();
                }
                ProcessCheckCopyKeys(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LstInitialWords_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    ProcessRemoving();
                }
                ProcessCheckCopyKeys(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LstResults_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProcessCheckCopyKeys(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Buttons

        private void CbWordsLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listSelected = this.CbWordsLists.Text;
                
                if (this.CbWordsLists.Text == NEW || this.CbWordsLists.Text == "")
                {
                    ProcessClearing();
                    return;
                }

                //chargement dans la listbox du contenu sélectionné
                string[] oneList = wordsLists[this.CbWordsLists.Text].ToArray();

                this.LstInitialWords.Items.Clear();
                this.LstInitialWords.Items.AddRange(oneList);
                ProcessCombinations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CbWordsLists_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (listSelected == null || listSelected == "" || listSelected == this.CbWordsLists.Text || wordsLists.ContainsKey(this.CbWordsLists.Text)) return;

                int indexCbElement = this.CbWordsLists.Items.IndexOf(listSelected);

                List<string> oneList = wordsLists[listSelected];
                wordsLists.Remove(listSelected);

                listSelected = this.CbWordsLists.Text;
                wordsLists.Add(listSelected, oneList);

                this.CbWordsLists.Items.RemoveAt(indexCbElement);
                this.CbWordsLists.Items.Add(this.CbWordsLists.Text);

                if (!this.CbWordsLists.Items.Contains(NEW))
                {
                    this.CbWordsLists.Items.Add(NEW);
                    wordsLists.Add(NEW, new List<string>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessAdding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessRemoving();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtRemoveList_Click(object sender, EventArgs e)
        {
            try
            {
                if (wordsLists.ContainsKey(this.CbWordsLists.Text))
                {                
                    wordsLists.Remove(this.CbWordsLists.Text);
                    this.CbWordsLists.Items.Remove(this.CbWordsLists.Text);
                    this.CbWordsLists.SelectedIndex = this.CbWordsLists.Items.IndexOf(NEW);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtCopy_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessCopy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtClearInitialWords_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessClearing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtQuitSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (wordsLists.ContainsKey(NEW))
                {
                    if (wordsLists[NEW].Count > 0)
                    {
                        MessageBox.Show("Renommer liste avant sauvegarde.");
                        return;
                    }
                    else wordsLists.Remove(NEW);
                }                    

                ClassXmlTreatments.EditWordsListFile(configFilePath, wordsLists);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion
    }
}
