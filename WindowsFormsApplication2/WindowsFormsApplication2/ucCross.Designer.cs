namespace WindowsFormsApplication2
{
    partial class ucCross
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
            this.lbColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.tbWhellCount = new System.Windows.Forms.TextBox();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.cbColorCount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbWhell
            // 
            this.lbWhell.AutoSize = true;
            this.lbWhell.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWhell.Location = new System.Drawing.Point(57, 44);
            this.lbWhell.Name = "lbWhell";
            this.lbWhell.Size = new System.Drawing.Size(85, 36);
            this.lbWhell.TabIndex = 0;
            this.lbWhell.Text = "Whell";
            this.lbWhell.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbColor.Location = new System.Drawing.Point(57, 164);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(79, 36);
            this.lbColor.TabIndex = 0;
            this.lbColor.Text = "Color";
            this.lbColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Whell";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSpeedCount.Location = new System.Drawing.Point(57, 101);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(165, 36);
            this.lbSpeedCount.TabIndex = 0;
            this.lbSpeedCount.Text = "Speed Count";
            this.lbSpeedCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbWhellCount
            // 
            this.tbWhellCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWhellCount.Location = new System.Drawing.Point(272, 42);
            this.tbWhellCount.Name = "tbWhellCount";
            this.tbWhellCount.Size = new System.Drawing.Size(100, 38);
            this.tbWhellCount.TabIndex = 1;
            this.tbWhellCount.Text = "0";
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSpeedCount.Location = new System.Drawing.Point(272, 99);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(100, 38);
            this.tbSpeedCount.TabIndex = 1;
            this.tbSpeedCount.Text = "0";
            // 
            // cbColorCount
            // 
            this.cbColorCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbColorCount.FormattingEnabled = true;
            this.cbColorCount.Location = new System.Drawing.Point(272, 164);
            this.cbColorCount.Name = "cbColorCount";
            this.cbColorCount.Size = new System.Drawing.Size(121, 39);
            this.cbColorCount.TabIndex = 3;
            this.cbColorCount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ucCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.cbColorCount);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.tbWhellCount);
            this.Controls.Add(this.lbSpeedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbWhell);
            this.MaximumSize = new System.Drawing.Size(558, 363);
            this.MinimumSize = new System.Drawing.Size(558, 363);
            this.Name = "ucCross";
            this.Size = new System.Drawing.Size(558, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhell;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.TextBox tbWhellCount;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.ComboBox cbColorCount;
    }
}
