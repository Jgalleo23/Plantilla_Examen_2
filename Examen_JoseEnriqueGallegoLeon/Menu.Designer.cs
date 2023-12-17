
namespace Examen_JoseEnriqueGallegoLeon
{
    partial class formMenu
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
            this.panelNavegacionMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oP1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oP2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelNavegacionMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavegacionMenu
            // 
            this.panelNavegacionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(222)))), ((int)(((byte)(192)))));
            this.panelNavegacionMenu.Controls.Add(this.label1);
            this.panelNavegacionMenu.Controls.Add(this.btSalir);
            this.panelNavegacionMenu.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacionMenu.Name = "panelNavegacionMenu";
            this.panelNavegacionMenu.Size = new System.Drawing.Size(1070, 55);
            this.panelNavegacionMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú";
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
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oP1ToolStripMenuItem,
            this.oP2ToolStripMenuItem,
            this.oP3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oP1ToolStripMenuItem
            // 
            this.oP1ToolStripMenuItem.Name = "oP1ToolStripMenuItem";
            this.oP1ToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.oP1ToolStripMenuItem.Text = "OP1";
            this.oP1ToolStripMenuItem.Click += new System.EventHandler(this.oP1ToolStripMenuItem_Click);
            // 
            // oP2ToolStripMenuItem
            // 
            this.oP2ToolStripMenuItem.Name = "oP2ToolStripMenuItem";
            this.oP2ToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.oP2ToolStripMenuItem.Text = "OP2";
            // 
            // oP3ToolStripMenuItem
            // 
            this.oP3ToolStripMenuItem.Name = "oP3ToolStripMenuItem";
            this.oP3ToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.oP3ToolStripMenuItem.Text = "OP3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 595);
            this.dataGridView1.TabIndex = 3;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 695);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelNavegacionMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelNavegacionMenu.ResumeLayout(false);
            this.panelNavegacionMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacionMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oP1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oP2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oP3ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}