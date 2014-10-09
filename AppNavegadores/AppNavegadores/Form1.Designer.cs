namespace AppNavegadores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkexplore = new System.Windows.Forms.CheckBox();
            this.chkchrome = new System.Windows.Forms.CheckBox();
            this.chkmozilla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnavegador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkexplore
            // 
            this.chkexplore.AutoSize = true;
            this.chkexplore.Location = new System.Drawing.Point(51, 30);
            this.chkexplore.Name = "chkexplore";
            this.chkexplore.Size = new System.Drawing.Size(64, 17);
            this.chkexplore.TabIndex = 0;
            this.chkexplore.Text = "Explorer";
            this.chkexplore.UseVisualStyleBackColor = true;
            // 
            // chkchrome
            // 
            this.chkchrome.AutoSize = true;
            this.chkchrome.Location = new System.Drawing.Point(51, 71);
            this.chkchrome.Name = "chkchrome";
            this.chkchrome.Size = new System.Drawing.Size(99, 17);
            this.chkchrome.TabIndex = 1;
            this.chkchrome.Text = "Google Chrome";
            this.chkchrome.UseVisualStyleBackColor = true;
            this.chkchrome.CheckedChanged += new System.EventHandler(this.chkchrome_CheckedChanged);
            // 
            // chkmozilla
            // 
            this.chkmozilla.AutoSize = true;
            this.chkmozilla.Location = new System.Drawing.Point(51, 112);
            this.chkmozilla.Name = "chkmozilla";
            this.chkmozilla.Size = new System.Drawing.Size(92, 17);
            this.chkmozilla.TabIndex = 2;
            this.chkmozilla.Text = "Mozilla Firefox";
            this.chkmozilla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar Navegadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnavegador
            // 
            this.lblnavegador.AutoSize = true;
            this.lblnavegador.Location = new System.Drawing.Point(48, 208);
            this.lblnavegador.Name = "lblnavegador";
            this.lblnavegador.Size = new System.Drawing.Size(61, 13);
            this.lblnavegador.TabIndex = 4;
            this.lblnavegador.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.lblnavegador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkmozilla);
            this.Controls.Add(this.chkchrome);
            this.Controls.Add(this.chkexplore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkexplore;
        private System.Windows.Forms.CheckBox chkchrome;
        private System.Windows.Forms.CheckBox chkmozilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblnavegador;
    }
}

