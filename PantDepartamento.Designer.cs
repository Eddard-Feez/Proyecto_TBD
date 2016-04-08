namespace ProyectoTBD
{
    partial class PantDepartamento
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
            this.txtIdDPT = new System.Windows.Forms.TextBox();
            this.txtDescDPT = new System.Windows.Forms.TextBox();
            this.btnAgregarDPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Departamendo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtIdDPT
            // 
            this.txtIdDPT.Location = new System.Drawing.Point(117, 33);
            this.txtIdDPT.Name = "txtIdDPT";
            this.txtIdDPT.Size = new System.Drawing.Size(87, 20);
            this.txtIdDPT.TabIndex = 2;
            // 
            // txtDescDPT
            // 
            this.txtDescDPT.Location = new System.Drawing.Point(91, 71);
            this.txtDescDPT.Name = "txtDescDPT";
            this.txtDescDPT.Size = new System.Drawing.Size(119, 20);
            this.txtDescDPT.TabIndex = 3;
            // 
            // btnAgregarDPT
            // 
            this.btnAgregarDPT.Location = new System.Drawing.Point(135, 97);
            this.btnAgregarDPT.Name = "btnAgregarDPT";
            this.btnAgregarDPT.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDPT.TabIndex = 4;
            this.btnAgregarDPT.Text = "Agregar";
            this.btnAgregarDPT.UseVisualStyleBackColor = true;
            this.btnAgregarDPT.Click += new System.EventHandler(this.btnAgregarDPT_Click);
            // 
            // PantDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 149);
            this.Controls.Add(this.btnAgregarDPT);
            this.Controls.Add(this.txtDescDPT);
            this.Controls.Add(this.txtIdDPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantDepartamento";
            this.Text = "PantDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdDPT;
        private System.Windows.Forms.TextBox txtDescDPT;
        private System.Windows.Forms.Button btnAgregarDPT;
    }
}