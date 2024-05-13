using System.Drawing;
using System.Windows.Forms;

namespace CompiladorCeceña
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
            this.btnFile = new System.Windows.Forms.Button();
            this.btnLexico = new System.Windows.Forms.Button();
            this.btnSintactico = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.RichTextBox();
            this.txtErrores = new System.Windows.Forms.RichTextBox();
            this.txtSimbolos = new System.Windows.Forms.RichTextBox();
            this.txtTokens = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(44, 121);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(161, 53);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Abrir Archivo";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnLexico
            // 
            this.btnLexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexico.Location = new System.Drawing.Point(245, 121);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(161, 53);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Análisis Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // btnSintactico
            // 
            this.btnSintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSintactico.Location = new System.Drawing.Point(445, 121);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(161, 53);
            this.btnSintactico.TabIndex = 2;
            this.btnSintactico.Text = "Análisis Sintáctico";
            this.btnSintactico.UseVisualStyleBackColor = true;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(43, 228);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(686, 252);
            this.txtFile.TabIndex = 3;
            this.txtFile.Text = "";
            // 
            // txtErrores
            // 
            this.txtErrores.BackColor = System.Drawing.SystemColors.Window;
            this.txtErrores.Location = new System.Drawing.Point(43, 549);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(686, 257);
            this.txtErrores.TabIndex = 4;
            this.txtErrores.Text = "";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.BackColor = System.Drawing.SystemColors.Window;
            this.txtSimbolos.Location = new System.Drawing.Point(813, 169);
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.ReadOnly = true;
            this.txtSimbolos.Size = new System.Drawing.Size(478, 311);
            this.txtSimbolos.TabIndex = 5;
            this.txtSimbolos.Text = "";
            // 
            // txtTokens
            // 
            this.txtTokens.BackColor = System.Drawing.SystemColors.Window;
            this.txtTokens.Location = new System.Drawing.Point(813, 549);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.ReadOnly = true;
            this.txtTokens.Size = new System.Drawing.Size(482, 257);
            this.txtTokens.TabIndex = 6;
            this.txtTokens.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "Analizador Léxico y Sintáctico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Errores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(805, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Símbolos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(805, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tokens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1356, 942);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTokens);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.txtErrores);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSintactico);
            this.Controls.Add(this.btnLexico);
            this.Controls.Add(this.btnFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Analizador Léxico y Sintáctico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.RichTextBox txtFile;
        private System.Windows.Forms.RichTextBox txtErrores;
        private System.Windows.Forms.RichTextBox txtSimbolos;
        private System.Windows.Forms.RichTextBox txtTokens;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

