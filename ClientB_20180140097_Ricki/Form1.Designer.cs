namespace ClientB_20180140097_Ricki
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
            this.btDatasemua = new System.Windows.Forms.Button();
            this.NIMSearch1 = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtAngkatan = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Creat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btDatasemua
            // 
            this.btDatasemua.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatasemua.Location = new System.Drawing.Point(371, 121);
            this.btDatasemua.Name = "btDatasemua";
            this.btDatasemua.Size = new System.Drawing.Size(75, 23);
            this.btDatasemua.TabIndex = 28;
            this.btDatasemua.Text = "Lihat Data";
            this.btDatasemua.UseVisualStyleBackColor = true;
            this.btDatasemua.Click += new System.EventHandler(this.btDatasemua_Click);
            // 
            // NIMSearch1
            // 
            this.NIMSearch1.Location = new System.Drawing.Point(136, 230);
            this.NIMSearch1.Name = "NIMSearch1";
            this.NIMSearch1.Size = new System.Drawing.Size(168, 20);
            this.NIMSearch1.TabIndex = 27;
            this.NIMSearch1.TextChanged += new System.EventHandler(this.NIMSearch_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(371, 73);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(324, 202);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(110, 66);
            this.btSearch.TabIndex = 25;
            this.btSearch.Text = "Cari Berdasarkan NIM";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.Location = new System.Drawing.Point(136, 164);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.Size = new System.Drawing.Size(214, 20);
            this.txtAngkatan.TabIndex = 24;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(136, 114);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(214, 20);
            this.txtProdi.TabIndex = 23;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(136, 21);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(214, 20);
            this.txtNIM.TabIndex = 22;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(136, 70);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(214, 20);
            this.txtNama.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Creat
            // 
            this.Creat.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creat.Location = new System.Drawing.Point(371, 23);
            this.Creat.Name = "Creat";
            this.Creat.Size = new System.Drawing.Size(75, 23);
            this.Creat.TabIndex = 19;
            this.Creat.Text = "Create";
            this.Creat.UseVisualStyleBackColor = true;
            this.Creat.Click += new System.EventHandler(this.Creat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Angkatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.btDatasemua);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtAngkatan);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Creat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NIMSearch1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDatasemua;
        private System.Windows.Forms.TextBox NIMSearch1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtAngkatan;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Creat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

