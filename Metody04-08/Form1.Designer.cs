namespace Metody04_08
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMocnina = new System.Windows.Forms.Button();
            this.buttonFaktorial = new System.Windows.Forms.Button();
            this.buttonSoucetLich = new System.Windows.Forms.Button();
            this.buttonPrvocislo = new System.Windows.Forms.Button();
            this.buttonSudPocet = new System.Windows.Forms.Button();
            this.mocninaZaklad = new System.Windows.Forms.TextBox();
            this.mocninaExponent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.faktorialParametr = new System.Windows.Forms.TextBox();
            this.textBoxLich = new System.Windows.Forms.TextBox();
            this.textBoxPrvocislo = new System.Windows.Forms.TextBox();
            this.textBoxSud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMocnina
            // 
            this.buttonMocnina.Location = new System.Drawing.Point(68, 61);
            this.buttonMocnina.Name = "buttonMocnina";
            this.buttonMocnina.Size = new System.Drawing.Size(100, 23);
            this.buttonMocnina.TabIndex = 0;
            this.buttonMocnina.Text = "Mocnina";
            this.buttonMocnina.UseVisualStyleBackColor = true;
            this.buttonMocnina.Click += new System.EventHandler(this.buttonMocnina_Click);
            // 
            // buttonFaktorial
            // 
            this.buttonFaktorial.Location = new System.Drawing.Point(214, 35);
            this.buttonFaktorial.Name = "buttonFaktorial";
            this.buttonFaktorial.Size = new System.Drawing.Size(116, 23);
            this.buttonFaktorial.TabIndex = 1;
            this.buttonFaktorial.Text = "Faktorial";
            this.buttonFaktorial.UseVisualStyleBackColor = true;
            this.buttonFaktorial.Click += new System.EventHandler(this.buttonFaktorial_Click);
            // 
            // buttonSoucetLich
            // 
            this.buttonSoucetLich.Location = new System.Drawing.Point(336, 35);
            this.buttonSoucetLich.Name = "buttonSoucetLich";
            this.buttonSoucetLich.Size = new System.Drawing.Size(116, 23);
            this.buttonSoucetLich.TabIndex = 2;
            this.buttonSoucetLich.Text = "Liché cifry - součet";
            this.buttonSoucetLich.UseVisualStyleBackColor = true;
            this.buttonSoucetLich.Click += new System.EventHandler(this.buttonSoucetLich_Click);
            // 
            // buttonPrvocislo
            // 
            this.buttonPrvocislo.Location = new System.Drawing.Point(467, 35);
            this.buttonPrvocislo.Name = "buttonPrvocislo";
            this.buttonPrvocislo.Size = new System.Drawing.Size(116, 23);
            this.buttonPrvocislo.TabIndex = 3;
            this.buttonPrvocislo.Text = "Prvočíslo";
            this.buttonPrvocislo.UseVisualStyleBackColor = true;
            this.buttonPrvocislo.Click += new System.EventHandler(this.buttonPrvocislo_Click);
            // 
            // buttonSudPocet
            // 
            this.buttonSudPocet.Location = new System.Drawing.Point(606, 33);
            this.buttonSudPocet.Name = "buttonSudPocet";
            this.buttonSudPocet.Size = new System.Drawing.Size(116, 23);
            this.buttonSudPocet.TabIndex = 4;
            this.buttonSudPocet.Text = "Sudý dělitel - počet";
            this.buttonSudPocet.UseVisualStyleBackColor = true;
            this.buttonSudPocet.Click += new System.EventHandler(this.buttonSudPocet_Click);
            // 
            // mocninaZaklad
            // 
            this.mocninaZaklad.Location = new System.Drawing.Point(68, 9);
            this.mocninaZaklad.Name = "mocninaZaklad";
            this.mocninaZaklad.Size = new System.Drawing.Size(100, 20);
            this.mocninaZaklad.TabIndex = 5;
            // 
            // mocninaExponent
            // 
            this.mocninaExponent.Location = new System.Drawing.Point(68, 35);
            this.mocninaExponent.Name = "mocninaExponent";
            this.mocninaExponent.Size = new System.Drawing.Size(100, 20);
            this.mocninaExponent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Základ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exponent";
            // 
            // faktorialParametr
            // 
            this.faktorialParametr.Location = new System.Drawing.Point(230, 9);
            this.faktorialParametr.Name = "faktorialParametr";
            this.faktorialParametr.Size = new System.Drawing.Size(100, 20);
            this.faktorialParametr.TabIndex = 9;
            // 
            // textBoxLich
            // 
            this.textBoxLich.Location = new System.Drawing.Point(352, 9);
            this.textBoxLich.Name = "textBoxLich";
            this.textBoxLich.Size = new System.Drawing.Size(100, 20);
            this.textBoxLich.TabIndex = 10;
            // 
            // textBoxPrvocislo
            // 
            this.textBoxPrvocislo.Location = new System.Drawing.Point(483, 9);
            this.textBoxPrvocislo.Name = "textBoxPrvocislo";
            this.textBoxPrvocislo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrvocislo.TabIndex = 11;
            // 
            // textBoxSud
            // 
            this.textBoxSud.Location = new System.Drawing.Point(622, 9);
            this.textBoxSud.Name = "textBoxSud";
            this.textBoxSud.Size = new System.Drawing.Size(100, 20);
            this.textBoxSud.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSud);
            this.Controls.Add(this.textBoxPrvocislo);
            this.Controls.Add(this.textBoxLich);
            this.Controls.Add(this.faktorialParametr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mocninaExponent);
            this.Controls.Add(this.mocninaZaklad);
            this.Controls.Add(this.buttonSudPocet);
            this.Controls.Add(this.buttonPrvocislo);
            this.Controls.Add(this.buttonSoucetLich);
            this.Controls.Add(this.buttonFaktorial);
            this.Controls.Add(this.buttonMocnina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMocnina;
        private System.Windows.Forms.Button buttonFaktorial;
        private System.Windows.Forms.Button buttonSoucetLich;
        private System.Windows.Forms.Button buttonPrvocislo;
        private System.Windows.Forms.Button buttonSudPocet;
        private System.Windows.Forms.TextBox mocninaZaklad;
        private System.Windows.Forms.TextBox mocninaExponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox faktorialParametr;
        private System.Windows.Forms.TextBox textBoxLich;
        private System.Windows.Forms.TextBox textBoxPrvocislo;
        private System.Windows.Forms.TextBox textBoxSud;
    }
}

