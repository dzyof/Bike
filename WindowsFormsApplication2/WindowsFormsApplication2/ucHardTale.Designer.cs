﻿namespace WindowsFormsApplication2
{
    partial class ucHardTale
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbWhell = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbColorCount = new System.Windows.Forms.ComboBox();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.tbWhellCount = new System.Windows.Forms.TextBox();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWhell
            // 
            this.lbWhell.AutoSize = true;
            this.lbWhell.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhell.Location = new System.Drawing.Point(108, 92);
            this.lbWhell.Name = "lbWhell";
            this.lbWhell.Size = new System.Drawing.Size(85, 36);
            this.lbWhell.TabIndex = 4;
            this.lbWhell.Text = "Whell";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbColorCount
            // 
            this.cbColorCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColorCount.FormattingEnabled = true;
            this.cbColorCount.Location = new System.Drawing.Point(323, 212);
            this.cbColorCount.Name = "cbColorCount";
            this.cbColorCount.Size = new System.Drawing.Size(121, 39);
            this.cbColorCount.TabIndex = 10;
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSpeedCount.Location = new System.Drawing.Point(323, 147);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(100, 38);
            this.tbSpeedCount.TabIndex = 8;
            this.tbSpeedCount.Text = "0";
            // 
            // tbWhellCount
            // 
            this.tbWhellCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWhellCount.Location = new System.Drawing.Point(323, 90);
            this.tbWhellCount.Name = "tbWhellCount";
            this.tbWhellCount.Size = new System.Drawing.Size(100, 38);
            this.tbWhellCount.TabIndex = 9;
            this.tbWhellCount.Text = "0";
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSpeedCount.Location = new System.Drawing.Point(108, 149);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(165, 36);
            this.lbSpeedCount.TabIndex = 5;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Whell";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColor.Location = new System.Drawing.Point(108, 212);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(79, 36);
            this.lbColor.TabIndex = 7;
            this.lbColor.Text = "Color";
            // 
            // ucHardTale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbWhell);
            this.Controls.Add(this.cbColorCount);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.tbWhellCount);
            this.Controls.Add(this.lbSpeedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbColor);
            this.Name = "ucHardTale";
            this.Size = new System.Drawing.Size(552, 341);
            this.Load += new System.EventHandler(this.ucHardTale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhell;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbColorCount;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.TextBox tbWhellCount;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbColor;
    }
}
