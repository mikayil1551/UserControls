namespace UserControls
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlTelefon = new UserControls.InputControls();
            this.ctrlAdres = new UserControls.InputControls();
            this.ctrlSoyadi = new UserControls.InputControls();
            this.ctrlAdi = new UserControls.InputControls();
            this.columHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columHeader1,
            this.columHeader2,
            this.columHeader3,
            this.columHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 248);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlTelefon
            // 
            this.ctrlTelefon.Location = new System.Drawing.Point(292, 101);
            this.ctrlTelefon.Name = "ctrlTelefon";
            this.ctrlTelefon.Size = new System.Drawing.Size(335, 83);
            this.ctrlTelefon.TabIndex = 4;
            // 
            // ctrlAdres
            // 
            this.ctrlAdres.Location = new System.Drawing.Point(292, 12);
            this.ctrlAdres.Name = "ctrlAdres";
            this.ctrlAdres.Size = new System.Drawing.Size(335, 83);
            this.ctrlAdres.TabIndex = 3;
            // 
            // ctrlSoyadi
            // 
            this.ctrlSoyadi.Location = new System.Drawing.Point(22, 101);
            this.ctrlSoyadi.Name = "ctrlSoyadi";
            this.ctrlSoyadi.Size = new System.Drawing.Size(335, 83);
            this.ctrlSoyadi.TabIndex = 2;
            this.ctrlSoyadi.Load += new System.EventHandler(this.ınputControls2_Load);
            // 
            // ctrlAdi
            // 
            this.ctrlAdi.Location = new System.Drawing.Point(22, 12);
            this.ctrlAdi.Name = "ctrlAdi";
            this.ctrlAdi.Size = new System.Drawing.Size(335, 83);
            this.ctrlAdi.TabIndex = 1;
            // 
            // columHeader1
            // 
            this.columHeader1.Text = "Adi";
            this.columHeader1.Width = 209;
            // 
            // columHeader2
            // 
            this.columHeader2.Text = "Soyadi";
            this.columHeader2.Width = 228;
            // 
            // columHeader3
            // 
            this.columHeader3.Text = "Adres";
            this.columHeader3.Width = 182;
            // 
            // columHeader4
            // 
            this.columHeader4.Text = "Telefon";
            this.columHeader4.Width = 147;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlTelefon);
            this.Controls.Add(this.ctrlAdres);
            this.Controls.Add(this.ctrlSoyadi);
            this.Controls.Add(this.ctrlAdi);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private InputControls ctrlAdi;
        private InputControls ctrlSoyadi;
        private InputControls ctrlAdres;
        private InputControls ctrlTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columHeader1;
        private System.Windows.Forms.ColumnHeader columHeader2;
        private System.Windows.Forms.ColumnHeader columHeader3;
        private System.Windows.Forms.ColumnHeader columHeader4;
    }
}

