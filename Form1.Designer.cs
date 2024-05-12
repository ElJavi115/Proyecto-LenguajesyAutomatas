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
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(70, 47);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(136, 53);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Abrir Archivo";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(70, 140);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(136, 53);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Análisis Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // btnSintactico
            // 
            this.btnSintactico.Location = new System.Drawing.Point(70, 246);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(136, 53);
            this.btnSintactico.TabIndex = 2;
            this.btnSintactico.Text = "Análisis Sintáctico";
            this.btnSintactico.UseVisualStyleBackColor = true;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(325, 47);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(590, 323);
            this.txtFile.TabIndex = 3;
            this.txtFile.Text = "";
            // 
            // txtErrores
            // 
            this.txtErrores.BackColor = System.Drawing.SystemColors.Window;
            this.txtErrores.Location = new System.Drawing.Point(325, 411);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(590, 323);
            this.txtErrores.TabIndex = 4;
            this.txtErrores.Text = "";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.BackColor = System.Drawing.SystemColors.Window;
            this.txtSimbolos.Location = new System.Drawing.Point(28, 340);
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.ReadOnly = true;
            this.txtSimbolos.Size = new System.Drawing.Size(262, 394);
            this.txtSimbolos.TabIndex = 5;
            this.txtSimbolos.Text = "";
            // 
            // txtTokens
            // 
            this.txtTokens.BackColor = System.Drawing.SystemColors.Window;
            this.txtTokens.Location = new System.Drawing.Point(966, 47);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.ReadOnly = true;
            this.txtTokens.Size = new System.Drawing.Size(262, 687);
            this.txtTokens.TabIndex = 6;
            this.txtTokens.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 788);
            this.Controls.Add(this.txtTokens);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.txtErrores);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSintactico);
            this.Controls.Add(this.btnLexico);
            this.Controls.Add(this.btnFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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
    }
}

