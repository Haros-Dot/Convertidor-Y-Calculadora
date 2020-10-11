namespace Convertidor_Usd_a_Mxn
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbentradadatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbresultado = new System.Windows.Forms.Label();
            this.gbdivisas = new System.Windows.Forms.GroupBox();
            this.rbmxnausd = new System.Windows.Forms.RadioButton();
            this.rbusdamxn = new System.Windows.Forms.RadioButton();
            this.btnconversor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbdivisas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // tbentradadatos
            // 
            this.tbentradadatos.Location = new System.Drawing.Point(15, 44);
            this.tbentradadatos.Name = "tbentradadatos";
            this.tbentradadatos.Size = new System.Drawing.Size(100, 20);
            this.tbentradadatos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(139, 51);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(0, 13);
            this.lbresultado.TabIndex = 8;
            // 
            // gbdivisas
            // 
            this.gbdivisas.Controls.Add(this.rbmxnausd);
            this.gbdivisas.Controls.Add(this.rbusdamxn);
            this.gbdivisas.Location = new System.Drawing.Point(54, 67);
            this.gbdivisas.Name = "gbdivisas";
            this.gbdivisas.Size = new System.Drawing.Size(120, 74);
            this.gbdivisas.TabIndex = 9;
            this.gbdivisas.TabStop = false;
            // 
            // rbmxnausd
            // 
            this.rbmxnausd.AutoSize = true;
            this.rbmxnausd.Checked = true;
            this.rbmxnausd.Location = new System.Drawing.Point(18, 19);
            this.rbmxnausd.Name = "rbmxnausd";
            this.rbmxnausd.Size = new System.Drawing.Size(84, 17);
            this.rbmxnausd.TabIndex = 5;
            this.rbmxnausd.TabStop = true;
            this.rbmxnausd.Text = "MXN a USD";
            this.rbmxnausd.UseVisualStyleBackColor = true;
            // 
            // rbusdamxn
            // 
            this.rbusdamxn.AutoSize = true;
            this.rbusdamxn.Location = new System.Drawing.Point(18, 42);
            this.rbusdamxn.Name = "rbusdamxn";
            this.rbusdamxn.Size = new System.Drawing.Size(84, 17);
            this.rbusdamxn.TabIndex = 5;
            this.rbusdamxn.Text = "USD a MXN";
            this.rbusdamxn.UseVisualStyleBackColor = true;
            // 
            // btnconversor
            // 
            this.btnconversor.Location = new System.Drawing.Point(74, 147);
            this.btnconversor.Name = "btnconversor";
            this.btnconversor.Size = new System.Drawing.Size(75, 23);
            this.btnconversor.TabIndex = 10;
            this.btnconversor.Text = "Convertir";
            this.btnconversor.UseVisualStyleBackColor = true;
            this.btnconversor.Click += new System.EventHandler(this.btnconversor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 195);
            this.Controls.Add(this.btnconversor);
            this.Controls.Add(this.gbdivisas);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbentradadatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbdivisas.ResumeLayout(false);
            this.gbdivisas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbentradadatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.GroupBox gbdivisas;
        private System.Windows.Forms.RadioButton rbmxnausd;
        private System.Windows.Forms.RadioButton rbusdamxn;
        private System.Windows.Forms.Button btnconversor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}

