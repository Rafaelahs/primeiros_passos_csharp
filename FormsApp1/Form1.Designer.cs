
namespace FormsApp1
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
            this.btnn = new System.Windows.Forms.Button();
            this.caixatxt = new System.Windows.Forms.Label();
            this.parcela2 = new System.Windows.Forms.TextBox();
            this.parcela1 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnn
            // 
            this.btnn.Location = new System.Drawing.Point(12, 196);
            this.btnn.Name = "btnn";
            this.btnn.Size = new System.Drawing.Size(75, 23);
            this.btnn.TabIndex = 0;
            this.btnn.Text = "executar";
            this.btnn.UseVisualStyleBackColor = true;
            this.btnn.Click += new System.EventHandler(this.btnn_Click);
            // 
            // caixatxt
            // 
            this.caixatxt.AutoSize = true;
            this.caixatxt.Location = new System.Drawing.Point(18, 137);
            this.caixatxt.Name = "caixatxt";
            this.caixatxt.Size = new System.Drawing.Size(0, 17);
            this.caixatxt.TabIndex = 1;
            this.caixatxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // parcela2
            // 
            this.parcela2.Location = new System.Drawing.Point(12, 90);
            this.parcela2.Name = "parcela2";
            this.parcela2.Size = new System.Drawing.Size(100, 22);
            this.parcela2.TabIndex = 2;
            // 
            // parcela1
            // 
            this.parcela1.Location = new System.Drawing.Point(12, 12);
            this.parcela1.Name = "parcela1";
            this.parcela1.Size = new System.Drawing.Size(100, 22);
            this.parcela1.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(12, 137);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 17);
            this.resultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.parcela1);
            this.Controls.Add(this.parcela2);
            this.Controls.Add(this.caixatxt);
            this.Controls.Add(this.btnn);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnn;
        private System.Windows.Forms.Label caixatxt;
        private System.Windows.Forms.TextBox parcela2;
        private System.Windows.Forms.TextBox parcela1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label2;
    }
}

