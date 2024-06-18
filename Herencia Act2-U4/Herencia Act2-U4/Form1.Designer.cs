namespace Herencia_Act2_U4
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtRace = new System.Windows.Forms.TextBox();
            this.BtnCreateDog = new System.Windows.Forms.Button();
            this.LblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(237, 69);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 0;
            this.TxtName.Text = "Name";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(237, 114);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 22);
            this.TxtAge.TabIndex = 1;
            this.TxtAge.Text = "Age";
            // 
            // TxtRace
            // 
            this.TxtRace.Location = new System.Drawing.Point(237, 161);
            this.TxtRace.Name = "TxtRace";
            this.TxtRace.Size = new System.Drawing.Size(100, 22);
            this.TxtRace.TabIndex = 2;
            this.TxtRace.Text = "Race";
            // 
            // BtnCreateDog
            // 
            this.BtnCreateDog.Location = new System.Drawing.Point(227, 215);
            this.BtnCreateDog.Name = "BtnCreateDog";
            this.BtnCreateDog.Size = new System.Drawing.Size(110, 28);
            this.BtnCreateDog.TabIndex = 3;
            this.BtnCreateDog.Text = "Create dog";
            this.BtnCreateDog.UseVisualStyleBackColor = true;
            this.BtnCreateDog.Click += new System.EventHandler(this.BtnCreateDog_Click);
            // 
            // LblInformation
            // 
            this.LblInformation.AutoSize = true;
            this.LblInformation.Location = new System.Drawing.Point(262, 286);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(14, 16);
            this.LblInformation.TabIndex = 4;
            this.LblInformation.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblInformation);
            this.Controls.Add(this.BtnCreateDog);
            this.Controls.Add(this.TxtRace);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtRace;
        private System.Windows.Forms.Button BtnCreateDog;
        private System.Windows.Forms.Label LblInformation;
    }
}

