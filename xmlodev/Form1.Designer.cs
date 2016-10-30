namespace xmlodev
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
            this.lsbUrunler = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbUrunler
            // 
            this.lsbUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbUrunler.FormattingEnabled = true;
            this.lsbUrunler.Location = new System.Drawing.Point(0, 70);
            this.lsbUrunler.Name = "lsbUrunler";
            this.lsbUrunler.Size = new System.Drawing.Size(581, 251);
            this.lsbUrunler.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 12);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(115, 39);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Verileri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lsbUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbUrunler;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button button2;
    }
}

