namespace BookApplication
{
    partial class CWID
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
            this.CWIDlabel = new System.Windows.Forms.Label();
            this.textCWID = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CWIDlabel
            // 
            this.CWIDlabel.AutoSize = true;
            this.CWIDlabel.Location = new System.Drawing.Point(83, 61);
            this.CWIDlabel.Name = "CWIDlabel";
            this.CWIDlabel.Size = new System.Drawing.Size(226, 17);
            this.CWIDlabel.TabIndex = 0;
            this.CWIDlabel.Text = "Enter in you campus wide ID ";
            // 
            // textCWID
            // 
            this.textCWID.Location = new System.Drawing.Point(332, 50);
            this.textCWID.Name = "textCWID";
            this.textCWID.Size = new System.Drawing.Size(178, 28);
            this.textCWID.TabIndex = 1;
            this.textCWID.TextChanged += new System.EventHandler(this.TextCWID_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(332, 93);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(436, 93);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(74, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 128);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textCWID);
            this.Controls.Add(this.CWIDlabel);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CWID";
            this.Text = "CWID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CWIDlabel;
        private System.Windows.Forms.TextBox textCWID;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonExit;
    }
}

