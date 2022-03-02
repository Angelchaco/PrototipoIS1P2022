namespace CapaVistaSeguridadHSC
{
    partial class frmProcesoNominaD
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
            this.navegador1 = new DLL.nav.navegador();
            this.txtCodigoConcepto = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.cbxCodConcepto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // txtCodigoConcepto
            // 
            this.txtCodigoConcepto.Location = new System.Drawing.Point(230, 289);
            this.txtCodigoConcepto.Name = "txtCodigoConcepto";
            this.txtCodigoConcepto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoConcepto.TabIndex = 81;
            this.txtCodigoConcepto.Tag = "codigo_concepto";
            this.txtCodigoConcepto.TextChanged += new System.EventHandler(this.txtCodigoConcepto_TextChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(230, 330);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(100, 20);
            this.txtEstatus.TabIndex = 78;
            this.txtEstatus.Tag = "valor_nominaD";
            this.txtEstatus.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 75;
            this.textBox2.Tag = "codigo_empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Valor Nomina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Cod. Concepto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Cod. Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 68;
            this.textBox1.Tag = "codigo_nomina";
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(428, 136);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.Size = new System.Drawing.Size(685, 323);
            this.dvgConsulta.TabIndex = 82;
            this.dvgConsulta.SelectionChanged += new System.EventHandler(this.dvgConsulta_SelectionChanged);
            // 
            // cbxCodConcepto
            // 
            this.cbxCodConcepto.FormattingEnabled = true;
            this.cbxCodConcepto.Location = new System.Drawing.Point(53, 136);
            this.cbxCodConcepto.Name = "cbxCodConcepto";
            this.cbxCodConcepto.Size = new System.Drawing.Size(121, 21);
            this.cbxCodConcepto.TabIndex = 83;
            this.cbxCodConcepto.SelectedIndexChanged += new System.EventHandler(this.cbxCodConcepto_SelectedIndexChanged);
            // 
            // frmProcesoNominaD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 473);
            this.Controls.Add(this.cbxCodConcepto);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.txtCodigoConcepto);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmProcesoNominaD";
            this.Text = "frmProcesoNominaD";
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtCodigoConcepto;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.ComboBox cbxCodConcepto;
    }
}