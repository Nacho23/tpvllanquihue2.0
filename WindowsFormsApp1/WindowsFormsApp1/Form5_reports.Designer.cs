namespace WindowsFormsApp1
{
    partial class Reportes
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
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnDescontinuar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTotalIngresos = new System.Windows.Forms.Label();
            this.lbGanancia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbPeriodo.Location = new System.Drawing.Point(58, 30);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(271, 41);
            this.cbPeriodo.TabIndex = 0;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDescontinuar
            // 
            this.btnDescontinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDescontinuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDescontinuar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDescontinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescontinuar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescontinuar.ForeColor = System.Drawing.Color.White;
            this.btnDescontinuar.Location = new System.Drawing.Point(58, 475);
            this.btnDescontinuar.Name = "btnDescontinuar";
            this.btnDescontinuar.Size = new System.Drawing.Size(207, 84);
            this.btnDescontinuar.TabIndex = 11;
            this.btnDescontinuar.Text = "INFORME MENSUAL";
            this.btnDescontinuar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 84);
            this.button1.TabIndex = 12;
            this.button1.Text = "INFORME DIARIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTotalIngresos
            // 
            this.lbTotalIngresos.AutoSize = true;
            this.lbTotalIngresos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIngresos.ForeColor = System.Drawing.Color.White;
            this.lbTotalIngresos.Location = new System.Drawing.Point(51, 128);
            this.lbTotalIngresos.Name = "lbTotalIngresos";
            this.lbTotalIngresos.Size = new System.Drawing.Size(36, 40);
            this.lbTotalIngresos.TabIndex = 13;
            this.lbTotalIngresos.Text = "0";
            // 
            // lbGanancia
            // 
            this.lbGanancia.AutoSize = true;
            this.lbGanancia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGanancia.ForeColor = System.Drawing.Color.White;
            this.lbGanancia.Location = new System.Drawing.Point(53, 229);
            this.lbGanancia.Name = "lbGanancia";
            this.lbGanancia.Size = new System.Drawing.Size(26, 30);
            this.lbGanancia.TabIndex = 14;
            this.lbGanancia.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Ingresos: ";
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodo.ForeColor = System.Drawing.Color.White;
            this.lbPeriodo.Location = new System.Drawing.Point(212, 105);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(72, 23);
            this.lbPeriodo.TabIndex = 16;
            this.lbPeriodo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Ganancia";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.Location = new System.Drawing.Point(555, 30);
            this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(25);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(478, 529);
            this.printPreviewControl1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGanancia);
            this.Controls.Add(this.lbTotalIngresos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDescontinuar);
            this.Controls.Add(this.cbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnDescontinuar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTotalIngresos;
        private System.Windows.Forms.Label lbGanancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Label label2;
    }
}