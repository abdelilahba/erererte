namespace LinKTOSQLEXE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsupprime = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtmodele = new System.Windows.Forms.TextBox();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.ldbtelephone = new System.Windows.Forms.Label();
            this.lblmodele = new System.Windows.Forms.Label();
            this.lblmarque = new System.Windows.Forms.Label();
            this.lblmatricule = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.cbvoiture = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstreparation = new System.Windows.Forms.ListBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Controls.Add(this.btnclose);
            this.panel4.Location = new System.Drawing.Point(664, 497);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 75);
            this.panel4.TabIndex = 40;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(66, 18);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 28);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "valider";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(246, 18);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 35;
            this.btnclose.Text = "annuler";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnsupprime);
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Location = new System.Drawing.Point(664, 414);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 75);
            this.panel3.TabIndex = 39;
            // 
            // btnsupprime
            // 
            this.btnsupprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprime.Location = new System.Drawing.Point(306, 22);
            this.btnsupprime.Margin = new System.Windows.Forms.Padding(4);
            this.btnsupprime.Name = "btnsupprime";
            this.btnsupprime.Size = new System.Drawing.Size(100, 28);
            this.btnsupprime.TabIndex = 2;
            this.btnsupprime.Text = "suprimme";
            this.btnsupprime.UseVisualStyleBackColor = true;
            this.btnsupprime.Click += new System.EventHandler(this.btnsupprime_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(151, 22);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 28);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "modifier";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(4, 22);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttelephone);
            this.panel2.Controls.Add(this.txtmodele);
            this.panel2.Controls.Add(this.txtmarque);
            this.panel2.Controls.Add(this.txtmatricule);
            this.panel2.Controls.Add(this.ldbtelephone);
            this.panel2.Controls.Add(this.lblmodele);
            this.panel2.Controls.Add(this.lblmarque);
            this.panel2.Controls.Add(this.lblmatricule);
            this.panel2.Location = new System.Drawing.Point(597, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 384);
            this.panel2.TabIndex = 38;
            // 
            // txttelephone
            // 
            this.txttelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone.Location = new System.Drawing.Point(292, 350);
            this.txttelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(274, 34);
            this.txttelephone.TabIndex = 30;
            // 
            // txtmodele
            // 
            this.txtmodele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodele.Location = new System.Drawing.Point(292, 266);
            this.txtmodele.Margin = new System.Windows.Forms.Padding(4);
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.Size = new System.Drawing.Size(274, 34);
            this.txtmodele.TabIndex = 29;
            // 
            // txtmarque
            // 
            this.txtmarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarque.Location = new System.Drawing.Point(292, 173);
            this.txtmarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(278, 34);
            this.txtmarque.TabIndex = 28;
            // 
            // txtmatricule
            // 
            this.txtmatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricule.Location = new System.Drawing.Point(292, 56);
            this.txtmatricule.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(278, 34);
            this.txtmatricule.TabIndex = 21;
            // 
            // ldbtelephone
            // 
            this.ldbtelephone.AutoSize = true;
            this.ldbtelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtelephone.Location = new System.Drawing.Point(8, 349);
            this.ldbtelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldbtelephone.Name = "ldbtelephone";
            this.ldbtelephone.Size = new System.Drawing.Size(169, 29);
            this.ldbtelephone.TabIndex = 25;
            this.ldbtelephone.Text = "TELEPHONE";
            // 
            // lblmodele
            // 
            this.lblmodele.AutoSize = true;
            this.lblmodele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodele.Location = new System.Drawing.Point(17, 266);
            this.lblmodele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodele.Name = "lblmodele";
            this.lblmodele.Size = new System.Drawing.Size(120, 29);
            this.lblmodele.TabIndex = 23;
            this.lblmodele.Text = "MODELE";
            // 
            // lblmarque
            // 
            this.lblmarque.AutoSize = true;
            this.lblmarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarque.Location = new System.Drawing.Point(17, 173);
            this.lblmarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarque.Name = "lblmarque";
            this.lblmarque.Size = new System.Drawing.Size(123, 29);
            this.lblmarque.TabIndex = 22;
            this.lblmarque.Text = "MARQUE";
            // 
            // lblmatricule
            // 
            this.lblmatricule.AutoSize = true;
            this.lblmatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricule.Location = new System.Drawing.Point(17, 59);
            this.lblmatricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatricule.Name = "lblmatricule";
            this.lblmatricule.Size = new System.Drawing.Size(208, 29);
            this.lblmatricule.TabIndex = 21;
            this.lblmatricule.Text = "IMMMATRICULE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbvoiture);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.btnfirst);
            this.panel1.Controls.Add(this.btnlast);
            this.panel1.Controls.Add(this.btnprevious);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.txtfind);
            this.panel1.Location = new System.Drawing.Point(199, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 570);
            this.panel1.TabIndex = 37;
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(219, 58);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(136, 28);
            this.btnfind.TabIndex = 20;
            this.btnfind.Text = "recherche";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.Location = new System.Drawing.Point(256, 513);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(60, 28);
            this.btnfirst.TabIndex = 19;
            this.btnfirst.Text = "<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.Location = new System.Drawing.Point(175, 513);
            this.btnlast.Margin = new System.Windows.Forms.Padding(4);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(60, 28);
            this.btnlast.TabIndex = 18;
            this.btnlast.Text = ">>";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnprevious
            // 
            this.btnprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.Location = new System.Drawing.Point(86, 513);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(60, 28);
            this.btnprevious.TabIndex = 17;
            this.btnprevious.Text = "<";
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(4, 513);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(60, 28);
            this.btnnext.TabIndex = 16;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtfind
            // 
            this.txtfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfind.Location = new System.Drawing.Point(4, 58);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(200, 28);
            this.txtfind.TabIndex = 14;
            // 
            // cbvoiture
            // 
            this.cbvoiture.FormattingEnabled = true;
            this.cbvoiture.Location = new System.Drawing.Point(3, 3);
            this.cbvoiture.Name = "cbvoiture";
            this.cbvoiture.Size = new System.Drawing.Size(356, 24);
            this.cbvoiture.TabIndex = 22;
            this.cbvoiture.SelectedIndexChanged += new System.EventHandler(this.cbvoiture_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 398);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lstreparation
            // 
            this.lstreparation.FormattingEnabled = true;
            this.lstreparation.ItemHeight = 16;
            this.lstreparation.Location = new System.Drawing.Point(12, 15);
            this.lstreparation.Name = "lstreparation";
            this.lstreparation.Size = new System.Drawing.Size(180, 564);
            this.lstreparation.TabIndex = 41;
            this.lstreparation.SelectedIndexChanged += new System.EventHandler(this.lstreparation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 585);
            this.Controls.Add(this.lstreparation);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsupprime;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtmodele;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.Label ldbtelephone;
        private System.Windows.Forms.Label lblmodele;
        private System.Windows.Forms.Label lblmarque;
        private System.Windows.Forms.Label lblmatricule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.ComboBox cbvoiture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstreparation;
    }
}

