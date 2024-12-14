namespace Client
{
    partial class WCFSyndicationClient
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RSS = new System.Windows.Forms.Button();
            this.ATOM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // RSS
            // 
            this.RSS.BackColor = System.Drawing.Color.White;
            this.RSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RSS.Font = new System.Drawing.Font("Myanmar Text", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RSS.Location = new System.Drawing.Point(78, 457);
            this.RSS.Name = "RSS";
            this.RSS.Size = new System.Drawing.Size(143, 51);
            this.RSS.TabIndex = 3;
            this.RSS.Text = "RSS";
            this.RSS.UseVisualStyleBackColor = false;
            this.RSS.Click += new System.EventHandler(this.RSS_Click);
            // 
            // ATOM
            // 
            this.ATOM.BackColor = System.Drawing.Color.White;
            this.ATOM.Font = new System.Drawing.Font("Myanmar Text", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATOM.Location = new System.Drawing.Point(408, 459);
            this.ATOM.Name = "ATOM";
            this.ATOM.Size = new System.Drawing.Size(143, 49);
            this.ATOM.TabIndex = 4;
            this.ATOM.Text = "ATOM";
            this.ATOM.UseVisualStyleBackColor = false;
            this.ATOM.Click += new System.EventHandler(this.ATOM_Click);
            // 
            // WCFSyndicationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.ATOM);
            this.Controls.Add(this.RSS);
            this.Controls.Add(this.richTextBox1);
            this.Name = "WCFSyndicationClient";
            this.Text = "WCFSyndicationClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button RSS;
        private System.Windows.Forms.Button ATOM;
    }
}