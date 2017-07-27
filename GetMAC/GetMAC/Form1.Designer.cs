namespace GetMAC
{
    partial class Form1
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
            this.ButtonGetMAC1 = new System.Windows.Forms.Button();
            this.ButtonGetMAC2 = new System.Windows.Forms.Button();
            this.richTextBoxMAC1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMAC2 = new System.Windows.Forms.RichTextBox();
            this.buttonGetMAC3 = new System.Windows.Forms.Button();
            this.richTextBoxMAC3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonGetMAC1
            // 
            this.ButtonGetMAC1.Location = new System.Drawing.Point(13, 13);
            this.ButtonGetMAC1.Name = "ButtonGetMAC1";
            this.ButtonGetMAC1.Size = new System.Drawing.Size(75, 23);
            this.ButtonGetMAC1.TabIndex = 0;
            this.ButtonGetMAC1.Text = "Get MAC 1";
            this.ButtonGetMAC1.UseVisualStyleBackColor = true;
            this.ButtonGetMAC1.Click += new System.EventHandler(this.ButtonGetMAC1_Click);
            // 
            // ButtonGetMAC2
            // 
            this.ButtonGetMAC2.Location = new System.Drawing.Point(120, 13);
            this.ButtonGetMAC2.Name = "ButtonGetMAC2";
            this.ButtonGetMAC2.Size = new System.Drawing.Size(75, 23);
            this.ButtonGetMAC2.TabIndex = 0;
            this.ButtonGetMAC2.Text = "Get MAC 2";
            this.ButtonGetMAC2.UseVisualStyleBackColor = true;
            this.ButtonGetMAC2.Click += new System.EventHandler(this.ButtonGetMAC2_Click);
            // 
            // richTextBoxMAC1
            // 
            this.richTextBoxMAC1.Location = new System.Drawing.Point(13, 59);
            this.richTextBoxMAC1.Name = "richTextBoxMAC1";
            this.richTextBoxMAC1.Size = new System.Drawing.Size(833, 115);
            this.richTextBoxMAC1.TabIndex = 1;
            this.richTextBoxMAC1.Text = "";
            // 
            // richTextBoxMAC2
            // 
            this.richTextBoxMAC2.Location = new System.Drawing.Point(13, 180);
            this.richTextBoxMAC2.Name = "richTextBoxMAC2";
            this.richTextBoxMAC2.Size = new System.Drawing.Size(833, 140);
            this.richTextBoxMAC2.TabIndex = 2;
            this.richTextBoxMAC2.Text = "";
            // 
            // buttonGetMAC3
            // 
            this.buttonGetMAC3.Location = new System.Drawing.Point(249, 13);
            this.buttonGetMAC3.Name = "buttonGetMAC3";
            this.buttonGetMAC3.Size = new System.Drawing.Size(75, 23);
            this.buttonGetMAC3.TabIndex = 3;
            this.buttonGetMAC3.Text = "Get MAC 3";
            this.buttonGetMAC3.UseVisualStyleBackColor = true;
            this.buttonGetMAC3.Click += new System.EventHandler(this.buttonGetMAC3_Click);
            // 
            // richTextBoxMAC3
            // 
            this.richTextBoxMAC3.Location = new System.Drawing.Point(12, 326);
            this.richTextBoxMAC3.Name = "richTextBoxMAC3";
            this.richTextBoxMAC3.Size = new System.Drawing.Size(833, 186);
            this.richTextBoxMAC3.TabIndex = 4;
            this.richTextBoxMAC3.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 524);
            this.Controls.Add(this.richTextBoxMAC3);
            this.Controls.Add(this.buttonGetMAC3);
            this.Controls.Add(this.richTextBoxMAC2);
            this.Controls.Add(this.richTextBoxMAC1);
            this.Controls.Add(this.ButtonGetMAC2);
            this.Controls.Add(this.ButtonGetMAC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetMAC1;
        private System.Windows.Forms.Button ButtonGetMAC2;
        private System.Windows.Forms.RichTextBox richTextBoxMAC1;
        private System.Windows.Forms.RichTextBox richTextBoxMAC2;
        private System.Windows.Forms.Button buttonGetMAC3;
        private System.Windows.Forms.RichTextBox richTextBoxMAC3;
    }
}

