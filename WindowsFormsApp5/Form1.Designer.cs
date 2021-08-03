
namespace WindowsFormsApp5
{
    partial class BestOIL
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
            this.BenzinGrupBox = new System.Windows.Forms.GroupBox();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.LiterTxtBox = new System.Windows.Forms.TextBox();
            this.ChoseGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceRadioBtn = new System.Windows.Forms.RadioButton();
            this.LiterRadioBtn = new System.Windows.Forms.RadioButton();
            this.AZNlbl = new System.Windows.Forms.Label();
            this.ShowTxtBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.OILComboBox = new System.Windows.Forms.ComboBox();
            this.OILtypeLbl = new System.Windows.Forms.Label();
            this.MiniKafegroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BenzinGrupBox.SuspendLayout();
            this.ChoseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BenzinGrupBox
            // 
            this.BenzinGrupBox.AutoSize = true;
            this.BenzinGrupBox.Controls.Add(this.PriceTxtBox);
            this.BenzinGrupBox.Controls.Add(this.LiterTxtBox);
            this.BenzinGrupBox.Controls.Add(this.ChoseGroupBox);
            this.BenzinGrupBox.Controls.Add(this.AZNlbl);
            this.BenzinGrupBox.Controls.Add(this.ShowTxtBox);
            this.BenzinGrupBox.Controls.Add(this.PriceLbl);
            this.BenzinGrupBox.Controls.Add(this.OILComboBox);
            this.BenzinGrupBox.Controls.Add(this.OILtypeLbl);
            this.BenzinGrupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BenzinGrupBox.Location = new System.Drawing.Point(12, 12);
            this.BenzinGrupBox.Name = "BenzinGrupBox";
            this.BenzinGrupBox.Size = new System.Drawing.Size(315, 433);
            this.BenzinGrupBox.TabIndex = 0;
            this.BenzinGrupBox.TabStop = false;
            this.BenzinGrupBox.Text = "Benzin";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Enabled = false;
            this.PriceTxtBox.Location = new System.Drawing.Point(189, 275);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(110, 29);
            this.PriceTxtBox.TabIndex = 7;
            // 
            // LiterTxtBox
            // 
            this.LiterTxtBox.Enabled = false;
            this.LiterTxtBox.Location = new System.Drawing.Point(189, 233);
            this.LiterTxtBox.Name = "LiterTxtBox";
            this.LiterTxtBox.Size = new System.Drawing.Size(110, 29);
            this.LiterTxtBox.TabIndex = 6;
            // 
            // ChoseGroupBox
            // 
            this.ChoseGroupBox.Controls.Add(this.PriceRadioBtn);
            this.ChoseGroupBox.Controls.Add(this.LiterRadioBtn);
            this.ChoseGroupBox.Location = new System.Drawing.Point(21, 213);
            this.ChoseGroupBox.Name = "ChoseGroupBox";
            this.ChoseGroupBox.Size = new System.Drawing.Size(157, 99);
            this.ChoseGroupBox.TabIndex = 5;
            this.ChoseGroupBox.TabStop = false;
            // 
            // PriceRadioBtn
            // 
            this.PriceRadioBtn.AutoSize = true;
            this.PriceRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceRadioBtn.Location = new System.Drawing.Point(6, 62);
            this.PriceRadioBtn.Name = "PriceRadioBtn";
            this.PriceRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.PriceRadioBtn.TabIndex = 1;
            this.PriceRadioBtn.TabStop = true;
            this.PriceRadioBtn.Text = "Price";
            this.PriceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LiterRadioBtn
            // 
            this.LiterRadioBtn.AutoSize = true;
            this.LiterRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LiterRadioBtn.Location = new System.Drawing.Point(6, 30);
            this.LiterRadioBtn.Name = "LiterRadioBtn";
            this.LiterRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.LiterRadioBtn.TabIndex = 0;
            this.LiterRadioBtn.TabStop = true;
            this.LiterRadioBtn.Text = "Liter";
            this.LiterRadioBtn.UseVisualStyleBackColor = true;
            this.LiterRadioBtn.CheckedChanged += new System.EventHandler(this.LiterRadioBtn_CheckedChanged);
            // 
            // AZNlbl
            // 
            this.AZNlbl.AutoSize = true;
            this.AZNlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AZNlbl.Location = new System.Drawing.Point(231, 141);
            this.AZNlbl.Name = "AZNlbl";
            this.AZNlbl.Size = new System.Drawing.Size(38, 16);
            this.AZNlbl.TabIndex = 4;
            this.AZNlbl.Text = "AZN";
            // 
            // ShowTxtBox
            // 
            this.ShowTxtBox.Enabled = false;
            this.ShowTxtBox.Location = new System.Drawing.Point(103, 136);
            this.ShowTxtBox.Name = "ShowTxtBox";
            this.ShowTxtBox.Size = new System.Drawing.Size(110, 29);
            this.ShowTxtBox.TabIndex = 3;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLbl.Location = new System.Drawing.Point(18, 141);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 16);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Price";
            // 
            // OILComboBox
            // 
            this.OILComboBox.FormattingEnabled = true;
            this.OILComboBox.Location = new System.Drawing.Point(103, 48);
            this.OILComboBox.Name = "OILComboBox";
            this.OILComboBox.Size = new System.Drawing.Size(146, 32);
            this.OILComboBox.TabIndex = 0;
            this.OILComboBox.SelectedIndexChanged += new System.EventHandler(this.OILComboBox_SelectedIndexChanged);
            // 
            // OILtypeLbl
            // 
            this.OILtypeLbl.AutoSize = true;
            this.OILtypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OILtypeLbl.Location = new System.Drawing.Point(18, 58);
            this.OILtypeLbl.Name = "OILtypeLbl";
            this.OILtypeLbl.Size = new System.Drawing.Size(54, 16);
            this.OILtypeLbl.TabIndex = 0;
            this.OILtypeLbl.Text = "Benzin";
            // 
            // MiniKafegroupBox
            // 
            this.MiniKafegroupBox.AutoSize = true;
            this.MiniKafegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiniKafegroupBox.Location = new System.Drawing.Point(388, 12);
            this.MiniKafegroupBox.Name = "MiniKafegroupBox";
            this.MiniKafegroupBox.Size = new System.Drawing.Size(285, 433);
            this.MiniKafegroupBox.TabIndex = 1;
            this.MiniKafegroupBox.TabStop = false;
            this.MiniKafegroupBox.Text = "Mini-Kafe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.BestOIL;
            this.pictureBox1.Location = new System.Drawing.Point(686, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BestOIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1075, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MiniKafegroupBox);
            this.Controls.Add(this.BenzinGrupBox);
            this.Name = "BestOIL";
            this.Text = "BestOIL";
            this.Load += new System.EventHandler(this.BestOIL_Load);
            this.BenzinGrupBox.ResumeLayout(false);
            this.BenzinGrupBox.PerformLayout();
            this.ChoseGroupBox.ResumeLayout(false);
            this.ChoseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BenzinGrupBox;
        private System.Windows.Forms.GroupBox MiniKafegroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox OILComboBox;
        private System.Windows.Forms.Label OILtypeLbl;
        private System.Windows.Forms.Label AZNlbl;
        private System.Windows.Forms.TextBox ShowTxtBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox LiterTxtBox;
        private System.Windows.Forms.GroupBox ChoseGroupBox;
        private System.Windows.Forms.RadioButton PriceRadioBtn;
        private System.Windows.Forms.RadioButton LiterRadioBtn;
    }
}

