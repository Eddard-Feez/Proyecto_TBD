namespace ProyectoTBD
{
    partial class pUnidadMedida
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUM = new System.Windows.Forms.TextBox();
            this.txtDescUM = new System.Windows.Forms.TextBox();
            this.btnAgregarIDUM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID unidad medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtIdUM
            // 
            this.txtIdUM.Location = new System.Drawing.Point(129, 34);
            this.txtIdUM.Name = "txtIdUM";
            this.txtIdUM.Size = new System.Drawing.Size(101, 20);
            this.txtIdUM.TabIndex = 2;
            // 
            // txtDescUM
            // 
            this.txtDescUM.Location = new System.Drawing.Point(99, 70);
            this.txtDescUM.Name = "txtDescUM";
            this.txtDescUM.Size = new System.Drawing.Size(131, 20);
            this.txtDescUM.TabIndex = 3;
            // 
            // btnAgregarIDUM
            // 
            this.btnAgregarIDUM.Location = new System.Drawing.Point(99, 111);
            this.btnAgregarIDUM.Name = "btnAgregarIDUM";
            this.btnAgregarIDUM.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIDUM.TabIndex = 4;
            this.btnAgregarIDUM.Text = "Agregar";
            this.btnAgregarIDUM.UseVisualStyleBackColor = true;
            this.btnAgregarIDUM.Click += new System.EventHandler(this.btnAgregarIDUM_Click);
            // 
            // UnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 155);
            this.Controls.Add(this.btnAgregarIDUM);
            this.Controls.Add(this.txtDescUM);
            this.Controls.Add(this.txtIdUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnidadMedida";
            this.Text = "UnidadMedida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUM;
        private System.Windows.Forms.TextBox txtDescUM;
        private System.Windows.Forms.Button btnAgregarIDUM;
    }
}