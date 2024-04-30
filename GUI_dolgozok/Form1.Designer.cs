
namespace GUI_dolgozok
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
            this.listBox_dolgozok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_neme = new System.Windows.Forms.TextBox();
            this.textBox_reszleg = new System.Windows.Forms.TextBox();
            this.numericUpDown_belepesEve = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ber = new System.Windows.Forms.NumericUpDown();
            this.button_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_belepesEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ber)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dolgozok
            // 
            this.listBox_dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_dolgozok.FormattingEnabled = true;
            this.listBox_dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_dolgozok.Name = "listBox_dolgozok";
            this.listBox_dolgozok.Size = new System.Drawing.Size(211, 450);
            this.listBox_dolgozok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(232, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(232, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(232, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Részleg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(232, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Belépés éve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(232, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bér";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(348, 21);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(194, 24);
            this.textBox_nev.TabIndex = 6;
            // 
            // textBox_neme
            // 
            this.textBox_neme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_neme.Location = new System.Drawing.Point(348, 50);
            this.textBox_neme.Name = "textBox_neme";
            this.textBox_neme.Size = new System.Drawing.Size(194, 24);
            this.textBox_neme.TabIndex = 7;
            // 
            // textBox_reszleg
            // 
            this.textBox_reszleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_reszleg.Location = new System.Drawing.Point(348, 80);
            this.textBox_reszleg.Name = "textBox_reszleg";
            this.textBox_reszleg.Size = new System.Drawing.Size(194, 24);
            this.textBox_reszleg.TabIndex = 8;
            // 
            // numericUpDown_belepesEve
            // 
            this.numericUpDown_belepesEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_belepesEve.Location = new System.Drawing.Point(348, 108);
            this.numericUpDown_belepesEve.Name = "numericUpDown_belepesEve";
            this.numericUpDown_belepesEve.Size = new System.Drawing.Size(194, 24);
            this.numericUpDown_belepesEve.TabIndex = 9;
            this.numericUpDown_belepesEve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_ber
            // 
            this.numericUpDown_ber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ber.Location = new System.Drawing.Point(348, 137);
            this.numericUpDown_ber.Name = "numericUpDown_ber";
            this.numericUpDown_ber.Size = new System.Drawing.Size(194, 24);
            this.numericUpDown_ber.TabIndex = 10;
            this.numericUpDown_ber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_ber.ThousandsSeparator = true;
            // 
            // button_insert
            // 
            this.button_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_insert.Location = new System.Drawing.Point(236, 175);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(306, 42);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "Rögzítés";
            this.button_insert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.numericUpDown_ber);
            this.Controls.Add(this.numericUpDown_belepesEve);
            this.Controls.Add(this.textBox_reszleg);
            this.Controls.Add(this.textBox_neme);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_dolgozok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_belepesEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dolgozok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_neme;
        private System.Windows.Forms.TextBox textBox_reszleg;
        private System.Windows.Forms.NumericUpDown numericUpDown_belepesEve;
        private System.Windows.Forms.NumericUpDown numericUpDown_ber;
        private System.Windows.Forms.Button button_insert;
    }
}

