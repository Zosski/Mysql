namespace Lab5
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.markaBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.rokBox = new System.Windows.Forms.TextBox();
            this.pojemBox = new System.Windows.Forms.TextBox();
            this.mocBox = new System.Windows.Forms.TextBox();
            this.cenaBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.abortBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moc silnika [KM]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pojemność silnika";
            // 
            // markaBox
            // 
            this.markaBox.Location = new System.Drawing.Point(131, 36);
            this.markaBox.Name = "markaBox";
            this.markaBox.Size = new System.Drawing.Size(100, 20);
            this.markaBox.TabIndex = 6;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(131, 65);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 7;
            // 
            // rokBox
            // 
            this.rokBox.Location = new System.Drawing.Point(131, 94);
            this.rokBox.Name = "rokBox";
            this.rokBox.Size = new System.Drawing.Size(100, 20);
            this.rokBox.TabIndex = 8;
            // 
            // pojemBox
            // 
            this.pojemBox.Location = new System.Drawing.Point(131, 124);
            this.pojemBox.Name = "pojemBox";
            this.pojemBox.Size = new System.Drawing.Size(100, 20);
            this.pojemBox.TabIndex = 9;
            // 
            // mocBox
            // 
            this.mocBox.Location = new System.Drawing.Point(131, 153);
            this.mocBox.Name = "mocBox";
            this.mocBox.Size = new System.Drawing.Size(100, 20);
            this.mocBox.TabIndex = 10;
            // 
            // cenaBox
            // 
            this.cenaBox.Location = new System.Drawing.Point(131, 182);
            this.cenaBox.Name = "cenaBox";
            this.cenaBox.Size = new System.Drawing.Size(100, 20);
            this.cenaBox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(131, 234);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 38);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Dodaj samochód";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // abortBtn
            // 
            this.abortBtn.Location = new System.Drawing.Point(29, 234);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(82, 38);
            this.abortBtn.TabIndex = 13;
            this.abortBtn.Text = "Anuluj";
            this.abortBtn.UseVisualStyleBackColor = true;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(29, 215);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 14;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 284);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cenaBox);
            this.Controls.Add(this.mocBox);
            this.Controls.Add(this.pojemBox);
            this.Controls.Add(this.rokBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.markaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox markaBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox rokBox;
        private System.Windows.Forms.TextBox pojemBox;
        private System.Windows.Forms.TextBox mocBox;
        private System.Windows.Forms.TextBox cenaBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button abortBtn;
        private System.Windows.Forms.Label infoLabel;
    }
}