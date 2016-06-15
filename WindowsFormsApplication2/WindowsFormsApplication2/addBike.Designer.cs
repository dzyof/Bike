namespace WindowsFormsApplication2
{
    partial class addBike
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(391, 314);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(310, 314);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Location = new System.Drawing.Point(102, 17);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(121, 21);
            this.cbBikeType.TabIndex = 1;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(13, 68);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(453, 240);
            this.panelContent.TabIndex = 3;
            // 
            // addBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(478, 339);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 900);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "addBike";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addBike";
            this.Load += new System.EventHandler(this.addBike_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ComboBox cbBikeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
    }
}