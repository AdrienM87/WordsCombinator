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

namespace WordsCombinator
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.GbAlpha = new System.Windows.Forms.GroupBox();
            this.BtCopy = new System.Windows.Forms.Button();
            this.BtQuitSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbCombinations = new System.Windows.Forms.Label();
            this.LstResults = new System.Windows.Forms.ListBox();
            this.CbWordsLists = new System.Windows.Forms.ComboBox();
            this.GbWords = new System.Windows.Forms.GroupBox();
            this.BtRemove = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.LstInitialWords = new System.Windows.Forms.ListBox();
            this.LbWords = new System.Windows.Forms.Label();
            this.TbInitialWords = new System.Windows.Forms.TextBox();
            this.BtClearInitialWords = new System.Windows.Forms.Button();
            this.GbAlpha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // GbAlpha
            // 
            this.GbAlpha.Controls.Add(this.CbWordsLists);
            this.GbAlpha.Controls.Add(this.groupBox1);
            this.GbAlpha.Controls.Add(this.label2);
            this.GbAlpha.Location = new System.Drawing.Point(12, 12);
            this.GbAlpha.Name = "GbAlpha";
            this.GbAlpha.Size = new System.Drawing.Size(427, 359);
            this.GbAlpha.TabIndex = 1;
            this.GbAlpha.TabStop = false;
            // 
            // BtCopy
            // 
            this.BtCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtCopy.Location = new System.Drawing.Point(187, 256);
            this.BtCopy.Name = "BtCopy";
            this.BtCopy.Size = new System.Drawing.Size(79, 31);
            this.BtCopy.TabIndex = 11;
            this.BtCopy.Text = "Copy";
            this.BtCopy.UseVisualStyleBackColor = true;
            this.BtCopy.Click += new System.EventHandler(this.BtCopy_Click);
            // 
            // BtQuitSave
            // 
            this.BtQuitSave.ForeColor = System.Drawing.Color.Red;
            this.BtQuitSave.Location = new System.Drawing.Point(302, 256);
            this.BtQuitSave.Name = "BtQuitSave";
            this.BtQuitSave.Size = new System.Drawing.Size(79, 31);
            this.BtQuitSave.TabIndex = 10;
            this.BtQuitSave.Text = "Quit + Save";
            this.BtQuitSave.UseVisualStyleBackColor = true;
            this.BtQuitSave.Click += new System.EventHandler(this.BtQuitSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose your words list and get all combinations.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GbWords);
            this.groupBox1.Controls.Add(this.LbCombinations);
            this.groupBox1.Controls.Add(this.LstResults);
            this.groupBox1.Controls.Add(this.BtCopy);
            this.groupBox1.Controls.Add(this.BtQuitSave);
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 303);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // LbCombinations
            // 
            this.LbCombinations.AutoSize = true;
            this.LbCombinations.Location = new System.Drawing.Point(187, 22);
            this.LbCombinations.Name = "LbCombinations";
            this.LbCombinations.Size = new System.Drawing.Size(76, 13);
            this.LbCombinations.TabIndex = 13;
            this.LbCombinations.Text = "Combinations :";
            // 
            // LstResults
            // 
            this.LstResults.FormattingEnabled = true;
            this.LstResults.Location = new System.Drawing.Point(187, 41);
            this.LstResults.Name = "LstResults";
            this.LstResults.Size = new System.Drawing.Size(194, 199);
            this.LstResults.TabIndex = 12;
            // 
            // CbWordsLists
            // 
            this.CbWordsLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbWordsLists.FormattingEnabled = true;
            this.CbWordsLists.Location = new System.Drawing.Point(290, 19);
            this.CbWordsLists.Name = "CbWordsLists";
            this.CbWordsLists.Size = new System.Drawing.Size(121, 21);
            this.CbWordsLists.TabIndex = 13;
            this.CbWordsLists.SelectedIndexChanged += new System.EventHandler(this.CbWordsLists_SelectedIndexChanged);
            // 
            // GbWords
            // 
            this.GbWords.Controls.Add(this.BtRemove);
            this.GbWords.Controls.Add(this.BtAdd);
            this.GbWords.Controls.Add(this.LstInitialWords);
            this.GbWords.Controls.Add(this.LbWords);
            this.GbWords.Controls.Add(this.TbInitialWords);
            this.GbWords.Controls.Add(this.BtClearInitialWords);
            this.GbWords.Location = new System.Drawing.Point(6, 19);
            this.GbWords.Name = "GbWords";
            this.GbWords.Size = new System.Drawing.Size(162, 268);
            this.GbWords.TabIndex = 14;
            this.GbWords.TabStop = false;
            // 
            // BtRemove
            // 
            this.BtRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemove.ForeColor = System.Drawing.Color.Red;
            this.BtRemove.Location = new System.Drawing.Point(123, 62);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(22, 20);
            this.BtRemove.TabIndex = 24;
            this.BtRemove.Text = "-";
            this.BtRemove.UseVisualStyleBackColor = true;
            // 
            // BtAdd
            // 
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.ForeColor = System.Drawing.Color.Green;
            this.BtAdd.Location = new System.Drawing.Point(123, 35);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(22, 20);
            this.BtAdd.TabIndex = 23;
            this.BtAdd.Text = "+";
            this.BtAdd.UseVisualStyleBackColor = true;
            // 
            // LstInitialWords
            // 
            this.LstInitialWords.FormattingEnabled = true;
            this.LstInitialWords.Location = new System.Drawing.Point(16, 62);
            this.LstInitialWords.Name = "LstInitialWords";
            this.LstInitialWords.Size = new System.Drawing.Size(100, 160);
            this.LstInitialWords.TabIndex = 22;
            // 
            // LbWords
            // 
            this.LbWords.AutoSize = true;
            this.LbWords.Location = new System.Drawing.Point(16, 16);
            this.LbWords.Name = "LbWords";
            this.LbWords.Size = new System.Drawing.Size(44, 13);
            this.LbWords.TabIndex = 21;
            this.LbWords.Text = "Words :";
            // 
            // TbInitialWords
            // 
            this.TbInitialWords.Location = new System.Drawing.Point(16, 35);
            this.TbInitialWords.Name = "TbInitialWords";
            this.TbInitialWords.Size = new System.Drawing.Size(100, 20);
            this.TbInitialWords.TabIndex = 20;
            // 
            // BtClearInitialWords
            // 
            this.BtClearInitialWords.Location = new System.Drawing.Point(16, 228);
            this.BtClearInitialWords.Name = "BtClearInitialWords";
            this.BtClearInitialWords.Size = new System.Drawing.Size(100, 31);
            this.BtClearInitialWords.TabIndex = 19;
            this.BtClearInitialWords.Text = "Clear";
            this.BtClearInitialWords.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 382);
            this.Controls.Add(this.GbAlpha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Words Combination";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.GbAlpha.ResumeLayout(false);
            this.GbAlpha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbWords.ResumeLayout(false);
            this.GbWords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbAlpha;
        private System.Windows.Forms.Button BtQuitSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtCopy;
        private System.Windows.Forms.ComboBox CbWordsLists;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbCombinations;
        private System.Windows.Forms.ListBox LstResults;
        private System.Windows.Forms.GroupBox GbWords;
        private System.Windows.Forms.Button BtRemove;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.ListBox LstInitialWords;
        private System.Windows.Forms.Label LbWords;
        private System.Windows.Forms.TextBox TbInitialWords;
        private System.Windows.Forms.Button BtClearInitialWords;
    }
}

