namespace Lab5
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.connectBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.disconnBtn = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rok_produkcji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojemnosc_skokowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moc_silnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(687, 200);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Polacz";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 200);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "label1";
            // 
            // disconnBtn
            // 
            this.disconnBtn.Location = new System.Drawing.Point(687, 229);
            this.disconnBtn.Name = "disconnBtn";
            this.disconnBtn.Size = new System.Drawing.Size(75, 23);
            this.disconnBtn.TabIndex = 2;
            this.disconnBtn.Text = "Rozlacz";
            this.disconnBtn.UseVisualStyleBackColor = true;
            this.disconnBtn.Click += new System.EventHandler(this.disconnBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.marka,
            this.Model,
            this.rok_produkcji,
            this.pojemnosc_skokowa,
            this.moc_silnika,
            this.cena});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(750, 171);
            this.dataGrid.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // marka
            // 
            this.marka.HeaderText = "Marka";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // rok_produkcji
            // 
            this.rok_produkcji.HeaderText = "Rok produkcji";
            this.rok_produkcji.Name = "rok_produkcji";
            this.rok_produkcji.ReadOnly = true;
            // 
            // pojemnosc_skokowa
            // 
            this.pojemnosc_skokowa.HeaderText = "Pojemność";
            this.pojemnosc_skokowa.Name = "pojemnosc_skokowa";
            this.pojemnosc_skokowa.ReadOnly = true;
            // 
            // moc_silnika
            // 
            this.moc_silnika.HeaderText = "Moc silnika";
            this.moc_silnika.Name = "moc_silnika";
            this.moc_silnika.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.HeaderText = "Cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(561, 200);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 52);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Dodaj samochód";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(344, 201);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(104, 51);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Usun";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(454, 201);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(101, 51);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Edytuj";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 259);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.disconnBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button disconnBtn;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn rok_produkcji;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojemnosc_skokowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn moc_silnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
    }
}

