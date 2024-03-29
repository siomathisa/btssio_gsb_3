namespace Mission3rapport
{
    partial class FrmAjouterMedicament
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
            this.txtIdMedicament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomCommercial = new System.Windows.Forms.TextBox();
            this.comboIdFamille = new System.Windows.Forms.ComboBox();
            this.bdgSFamille = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEffets = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIndication = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdMedicament
            // 
            this.txtIdMedicament.Location = new System.Drawing.Point(308, 59);
            this.txtIdMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMedicament.Name = "txtIdMedicament";
            this.txtIdMedicament.Size = new System.Drawing.Size(116, 20);
            this.txtIdMedicament.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ajouter un nouveau médicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom commercial";
            // 
            // txtNomCommercial
            // 
            this.txtNomCommercial.Location = new System.Drawing.Point(304, 92);
            this.txtNomCommercial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomCommercial.Name = "txtNomCommercial";
            this.txtNomCommercial.Size = new System.Drawing.Size(120, 20);
            this.txtNomCommercial.TabIndex = 4;
            // 
            // comboIdFamille
            // 
            this.comboIdFamille.DataSource = this.bdgSFamille;
            this.comboIdFamille.DisplayMember = "id";
            this.comboIdFamille.FormattingEnabled = true;
            this.comboIdFamille.Location = new System.Drawing.Point(304, 122);
            this.comboIdFamille.Margin = new System.Windows.Forms.Padding(2);
            this.comboIdFamille.Name = "comboIdFamille";
            this.comboIdFamille.Size = new System.Drawing.Size(120, 21);
            this.comboIdFamille.TabIndex = 5;
            // 
            // bdgSFamille
            // 
            this.bdgSFamille.DataSource = typeof(Mission3rapport.famille);
            // 
            // bdgSMedicament
            // 
            this.bdgSMedicament.DataSource = typeof(Mission3rapport.medicament);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id Famille";
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(308, 165);
            this.txtComposition.Margin = new System.Windows.Forms.Padding(2);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(120, 20);
            this.txtComposition.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Composition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "effets";
            // 
            // txtEffets
            // 
            this.txtEffets.Location = new System.Drawing.Point(308, 211);
            this.txtEffets.Margin = new System.Windows.Forms.Padding(2);
            this.txtEffets.Name = "txtEffets";
            this.txtEffets.Size = new System.Drawing.Size(120, 20);
            this.txtEffets.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "contre indication";
            // 
            // txtIndication
            // 
            this.txtIndication.Location = new System.Drawing.Point(308, 264);
            this.txtIndication.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndication.Name = "txtIndication";
            this.txtIndication.Size = new System.Drawing.Size(120, 20);
            this.txtIndication.TabIndex = 11;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(236, 305);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(132, 30);
            this.btnEnregistrer.TabIndex = 13;
            this.btnEnregistrer.Text = "Enregistrer ";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmAjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIndication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEffets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboIdFamille);
            this.Controls.Add(this.txtNomCommercial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdMedicament);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAjouterMedicament";
            this.Text = "FrmAjouterMedicament";
            this.Load += new System.EventHandler(this.FrmAjouterMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomCommercial;
        private System.Windows.Forms.ComboBox comboIdFamille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEffets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIndication;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource bdgSMedicament;
        private System.Windows.Forms.BindingSource bdgSFamille;
    }
}