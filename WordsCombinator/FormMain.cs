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
using System.Linq;
using System.Windows.Forms;

namespace WordsCombinator
{
    public partial class FormMain : Form
    {
        #region Load

        private const string configFilePath = @"..\debug\WordsList.xml";
        private const string nodesName = "word";

        List<string> listCombinations = new List<string>();

        public FormMain()
        {
            InitializeComponent();

            ChargeWordsList();
        }

        /// <summary>
        /// Chargement de la liste des mots mémorisés dans le controle listbox dédié.
        /// </summary>
        private void ChargeWordsList()
        {
            try
            {
                this.LstInitialWords.Items.Clear();

                foreach (string word in ClassXmlTreatments.GetWordsListFromFile(configFilePath))
                {
                    this.LstInitialWords.Items.Add(word);
                }
                ProcessCombinations();
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
            this.Enabled = false;
            try
            {
                if (this.LstInitialWords.Items.Count == 0) return;

                listCombinations = ClassWordsCombinations.ConstructCombinationsList(this.LstInitialWords.Items.Cast<string>().ToList());

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
                this.LstInitialWords.Items.Clear();
                this.LstResults.Items.Clear();
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
                List<string> listWords = new List<string>();

                foreach (object item in this.LstInitialWords.Items)
                {
                    listWords.Add((string)item);
                }

                ClassXmlTreatments.EditWordsListFile(configFilePath, nodesName, listWords);

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
