namespace PriceBarcode
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
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.cmbCam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(50, 107);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(374, 175);
            this.pbPic.TabIndex = 0;
            this.pbPic.TabStop = false;
            // 
            // cmbCam
            // 
            this.cmbCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCam.FormattingEnabled = true;
            this.cmbCam.Location = new System.Drawing.Point(105, 65);
            this.cmbCam.Name = "cmbCam";
            this.cmbCam.Size = new System.Drawing.Size(274, 21);
            this.cmbCam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select:";
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(105, 300);
            this.txtBar.Name = "txtBar";
            this.txtBar.ReadOnly = true;
            this.txtBar.Size = new System.Drawing.Size(274, 20);
            this.txtBar.TabIndex = 3;
            this.txtBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBar.TextChanged += new System.EventHandler(this.txtBar_TextChanged);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(313, 337);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 40);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "SUBMIT";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "PRICE CHECKER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRODUCT DESCRIPTION: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Abril Fatface", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "BARCODE SCANNER";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(95, 613);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(325, 33);
            this.txtDes.TabIndex = 10;
            this.txtDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(121, 442);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(267, 117);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "SCAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 662);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCam);
            this.Controls.Add(this.pbPic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.ComboBox cmbCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblPrice;
    }
}

