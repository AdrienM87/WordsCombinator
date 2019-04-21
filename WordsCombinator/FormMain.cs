using System;
using System.Windows.Forms;

namespace WordsCombinator
{
    public partial class FormMain : Form
    {
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
            this.LstResults.Items.Clear();
            try
            {
                for (int i = 0; i < this.LstInitialWords.Items.Count; i++)
                {
                    for (int j = i; j < this.LstInitialWords.Items.Count; j++)
                    {
                        if (this.LstInitialWords.Items[i].ToString() != this.LstInitialWords.Items[j].ToString())
                        {
                            this.LstResults.Items.Add(this.LstInitialWords.Items[i].ToString() + " " + this.LstInitialWords.Items[j].ToString());
                            this.LstResults.Items.Add(this.LstInitialWords.Items[j].ToString() + " " + this.LstInitialWords.Items[i].ToString());
                        }
                    }
                }
                this.LbCombinations.Text = "Combinaisons (" + this.LstResults.Items.Count.ToString() + ") :";
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
                string words = "";
                foreach (string combination in this.LstResults.Items)
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
