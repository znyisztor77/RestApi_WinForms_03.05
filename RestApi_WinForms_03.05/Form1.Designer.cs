
namespace RestApi_WinForms_03._05
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
            this.listBox_Adatok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_azonosito = new System.Windows.Forms.TextBox();
            this.textBoxFizetes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label_Nev = new System.Windows.Forms.Label();
            this.button_beszuras = new System.Windows.Forms.Button();
            this.button_modositas = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Adatok
            // 
            this.listBox_Adatok.FormattingEnabled = true;
            this.listBox_Adatok.Location = new System.Drawing.Point(60, 55);
            this.listBox_Adatok.Name = "listBox_Adatok";
            this.listBox_Adatok.Size = new System.Drawing.Size(250, 355);
            this.listBox_Adatok.TabIndex = 0;
            this.listBox_Adatok.SelectedIndexChanged += new System.EventHandler(this.listBox_Adatok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosító:";
            // 
            // textBox_azonosito
            // 
            this.textBox_azonosito.Location = new System.Drawing.Point(443, 23);
            this.textBox_azonosito.Name = "textBox_azonosito";
            this.textBox_azonosito.Size = new System.Drawing.Size(317, 20);
            this.textBox_azonosito.TabIndex = 2;
            // 
            // textBoxFizetes
            // 
            this.textBoxFizetes.Location = new System.Drawing.Point(443, 93);
            this.textBoxFizetes.Name = "textBoxFizetes";
            this.textBoxFizetes.Size = new System.Drawing.Size(317, 20);
            this.textBoxFizetes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fizetés:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(443, 55);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(317, 20);
            this.textBox_Nev.TabIndex = 6;
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.CausesValidation = false;
            this.label_Nev.Location = new System.Drawing.Point(379, 55);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(30, 13);
            this.label_Nev.TabIndex = 5;
            this.label_Nev.Text = "Név:";
            // 
            // button_beszuras
            // 
            this.button_beszuras.Location = new System.Drawing.Point(382, 145);
            this.button_beszuras.Name = "button_beszuras";
            this.button_beszuras.Size = new System.Drawing.Size(75, 23);
            this.button_beszuras.TabIndex = 7;
            this.button_beszuras.Text = "Beszúrás";
            this.button_beszuras.UseVisualStyleBackColor = true;
            this.button_beszuras.Click += new System.EventHandler(this.button_beszuras_Click);
            // 
            // button_modositas
            // 
            this.button_modositas.Location = new System.Drawing.Point(478, 145);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(75, 23);
            this.button_modositas.TabIndex = 8;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = true;
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(581, 145);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(75, 23);
            this.button_torles.TabIndex = 9;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_modositas);
            this.Controls.Add(this.button_beszuras);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label_Nev);
            this.Controls.Add(this.textBoxFizetes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_azonosito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Adatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_azonosito;
        private System.Windows.Forms.TextBox textBoxFizetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Button button_beszuras;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Button button_torles;
    }
}

