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
            this.BtQuit = new System.Windows.Forms.Button();
            this.BtClearInitialWords = new System.Windows.Forms.Button();
            this.LbCombinations = new System.Windows.Forms.Label();
            this.LstResults = new System.Windows.Forms.ListBox();
            this.BtRemove = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.LstInitialWords = new System.Windows.Forms.ListBox();
            this.LbWords = new System.Windows.Forms.Label();
            this.TbInitialWords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbAlpha.SuspendLayout();
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
            this.GbAlpha.Controls.Add(this.BtCopy);
            this.GbAlpha.Controls.Add(this.BtQuit);
            this.GbAlpha.Controls.Add(this.BtClearInitialWords);
            this.GbAlpha.Controls.Add(this.LbCombinations);
            this.GbAlpha.Controls.Add(this.LstResults);
            this.GbAlpha.Controls.Add(this.BtRemove);
            this.GbAlpha.Controls.Add(this.BtAdd);
            this.GbAlpha.Controls.Add(this.LstInitialWords);
            this.GbAlpha.Controls.Add(this.LbWords);
            this.GbAlpha.Controls.Add(this.TbInitialWords);
            this.GbAlpha.Controls.Add(this.label2);
            this.GbAlpha.Location = new System.Drawing.Point(13, 13);
            this.GbAlpha.Name = "GbAlpha";
            this.GbAlpha.Size = new System.Drawing.Size(408, 347);
            this.GbAlpha.TabIndex = 1;
            this.GbAlpha.TabStop = false;
            // 
            // BtCopy
            // 
            this.BtCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtCopy.Location = new System.Drawing.Point(195, 289);
            this.BtCopy.Name = "BtCopy";
            this.BtCopy.Size = new System.Drawing.Size(100, 31);
            this.BtCopy.TabIndex = 11;
            this.BtCopy.Text = "Copy";
            this.BtCopy.UseVisualStyleBackColor = true;
            this.BtCopy.Click += new System.EventHandler(this.BtCopy_Click);
            // 
            // BtQuit
            // 
            this.BtQuit.ForeColor = System.Drawing.Color.Red;
            this.BtQuit.Location = new System.Drawing.Point(327, 289);
            this.BtQuit.Name = "BtQuit";
            this.BtQuit.Size = new System.Drawing.Size(62, 31);
            this.BtQuit.TabIndex = 10;
            this.BtQuit.Text = "Quit";
            this.BtQuit.UseVisualStyleBackColor = true;
            this.BtQuit.Click += new System.EventHandler(this.BtQuit_Click);
            // 
            // BtClearInitialWords
            // 
            this.BtClearInitialWords.Location = new System.Drawing.Point(20, 289);
            this.BtClearInitialWords.Name = "BtClearInitialWords";
            this.BtClearInitialWords.Size = new System.Drawing.Size(100, 31);
            this.BtClearInitialWords.TabIndex = 8;
            this.BtClearInitialWords.Text = "Clear";
            this.BtClearInitialWords.UseVisualStyleBackColor = true;
            this.BtClearInitialWords.Click += new System.EventHandler(this.BtClearInitialWords_Click);
            // 
            // LbCombinations
            // 
            this.LbCombinations.AutoSize = true;
            this.LbCombinations.Location = new System.Drawing.Point(195, 44);
            this.LbCombinations.Name = "LbCombinations";
            this.LbCombinations.Size = new System.Drawing.Size(76, 13);
            this.LbCombinations.TabIndex = 7;
            this.LbCombinations.Text = "Combinations :";
            // 
            // LstResults
            // 
            this.LstResults.FormattingEnabled = true;
            this.LstResults.Location = new System.Drawing.Point(195, 63);
            this.LstResults.Name = "LstResults";
            this.LstResults.Size = new System.Drawing.Size(194, 199);
            this.LstResults.TabIndex = 6;
            this.LstResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstResults_KeyDown);
            // 
            // BtRemove
            // 
            this.BtRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRemove.ForeColor = System.Drawing.Color.Red;
            this.BtRemove.Location = new System.Drawing.Point(127, 89);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(22, 20);
            this.BtRemove.TabIndex = 5;
            this.BtRemove.Text = "-";
            this.BtRemove.UseVisualStyleBackColor = true;
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.ForeColor = System.Drawing.Color.Green;
            this.BtAdd.Location = new System.Drawing.Point(127, 62);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(22, 20);
            this.BtAdd.TabIndex = 4;
            this.BtAdd.Text = "+";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // LstInitialWords
            // 
            this.LstInitialWords.FormattingEnabled = true;
            this.LstInitialWords.Location = new System.Drawing.Point(20, 89);
            this.LstInitialWords.Name = "LstInitialWords";
            this.LstInitialWords.Size = new System.Drawing.Size(100, 173);
            this.LstInitialWords.TabIndex = 3;
            this.LstInitialWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstInitialWords_KeyDown);
            // 
            // LbWords
            // 
            this.LbWords.AutoSize = true;
            this.LbWords.Location = new System.Drawing.Point(20, 43);
            this.LbWords.Name = "LbWords";
            this.LbWords.Size = new System.Drawing.Size(44, 13);
            this.LbWords.TabIndex = 2;
            this.LbWords.Text = "Words :";
            // 
            // TbInitialWords
            // 
            this.TbInitialWords.Location = new System.Drawing.Point(20, 62);
            this.TbInitialWords.Name = "TbInitialWords";
            this.TbInitialWords.Size = new System.Drawing.Size(100, 20);
            this.TbInitialWords.TabIndex = 1;
            this.TbInitialWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbInitialWords_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your words list and get all combinations.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 376);
            this.Controls.Add(this.GbAlpha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Words Combination";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.GbAlpha.ResumeLayout(false);
            this.GbAlpha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbAlpha;
        private System.Windows.Forms.Button BtQuit;
        private System.Windows.Forms.Button BtClearInitialWords;
        private System.Windows.Forms.Label LbCombinations;
        private System.Windows.Forms.ListBox LstResults;
        private System.Windows.Forms.Button BtRemove;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.ListBox LstInitialWords;
        private System.Windows.Forms.Label LbWords;
        private System.Windows.Forms.TextBox TbInitialWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtCopy;
    }
}

