﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WordsCombinator
{
    public partial class FormMain : Form
    {
        List<string> listCombinations = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                processCheckCopyKeys(e);
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
                    processAdding();
                }
                processCheckCopyKeys(e);
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
                    processRemoving();
                }
                processCheckCopyKeys(e);
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
                processCheckCopyKeys(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processCheckCopyKeys(KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    processCopy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processCombinations()
        {
            this.Enabled = false;
            try
            {
                listCombinations = ClassWordsCombinations.constructCombinationsList(this.LstInitialWords.Items.Cast<string>().ToList());

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

        private void processAdding()
        {
            try
            {
                if (this.TbInitialWords.Text != "")
                {
                    bool exists = false;
                    foreach (string word in this.LstInitialWords.Items)
                    {
                        if (this.TbInitialWords.Text == word.ToString())
                        {
                            exists = true;
                        }
                    }
                    if (exists == false)
                    {
                        this.LstInitialWords.Items.Add(this.TbInitialWords.Text);
                        this.TbInitialWords.Text = "";
                        this.TbInitialWords.Select();

                        processCombinations();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processRemoving()
        {
            try
            {
                if (this.LstInitialWords.SelectedIndex != -1)
                {
                    this.LstInitialWords.Items.RemoveAt(this.LstInitialWords.SelectedIndex);
                }
                processCombinations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processCopy()
        {
            try
            {
                ClassWordsCombinations.copyStringListToClipboard(listCombinations);
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
                processAdding();
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
                processRemoving();
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
                processCopy();
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

        private void BtQuit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
