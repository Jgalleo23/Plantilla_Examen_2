
namespace Examen_JoseEnriqueGallegoLeon
{
    partial class Formulario
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
            this.panelNavegacionFormulario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btModelo = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.panelNavegacionFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacionFormulario
            // 
            this.panelNavegacionFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(222)))), ((int)(((byte)(192)))));
            this.panelNavegacionFormulario.Controls.Add(this.button1);
            this.panelNavegacionFormulario.Controls.Add(this.label1);
            this.panelNavegacionFormulario.Controls.Add(this.btSalir);
            this.panelNavegacionFormulario.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacionFormulario.Name = "panelNavegacionFormulario";
            this.panelNavegacionFormulario.Size = new System.Drawing.Size(896, 55);
            this.panelNavegacionFormulario.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(818, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario";
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Transparent;
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(992, 3);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 49);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "X";
            this.btSalir.UseVisualStyleBackColor = false;
            // 
            // btModelo
            // 
            this.btModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btModelo.Location = new System.Drawing.Point(128, 82);
            this.btModelo.Name = "btModelo";
            this.btModelo.Size = new System.Drawing.Size(270, 30);
            this.btModelo.TabIndex = 3;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lbModelo.Location = new System.Drawing.Point(12, 83);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(90, 28);
            this.lbModelo.TabIndex = 4;
            this.lbModelo.Text = "Modelo";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 555);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.btModelo);
            this.Controls.Add(this.panelNavegacionFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.panelNavegacionFormulario.ResumeLayout(false);
            this.panelNavegacionFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacionFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox btModelo;
        private System.Windows.Forms.Label lbModelo;
    }
}