namespace hamburgerci
{
    partial class MenuPage
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
            this.geridonbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // geridonbtn
            // 
            this.geridonbtn.Location = new System.Drawing.Point(351, 314);
            this.geridonbtn.Margin = new System.Windows.Forms.Padding(2);
            this.geridonbtn.Name = "geridonbtn";
            this.geridonbtn.Size = new System.Drawing.Size(127, 48);
            this.geridonbtn.TabIndex = 20;
            this.geridonbtn.Text = "GERİ DÖN";
            this.geridonbtn.UseVisualStyleBackColor = true;
            this.geridonbtn.Click += new System.EventHandler(this.geridonbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(324, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "MENÜ EKLEME SAYFASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu :";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(340, 194);
            this.priceText.Margin = new System.Windows.Forms.Padding(2);
            this.priceText.Multiline = true;
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(161, 29);
            this.priceText.TabIndex = 16;
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(351, 248);
            this.eklebtn.Margin = new System.Windows.Forms.Padding(2);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(128, 49);
            this.eklebtn.TabIndex = 15;
            this.eklebtn.Text = "MENU EKLE";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // menuText
            // 
            this.menuText.Location = new System.Drawing.Point(340, 136);
            this.menuText.Margin = new System.Windows.Forms.Padding(2);
            this.menuText.Multiline = true;
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(161, 29);
            this.menuText.TabIndex = 14;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geridonbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.menuText);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geridonbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.TextBox menuText;
    }
}