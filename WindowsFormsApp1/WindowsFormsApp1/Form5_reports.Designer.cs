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
            this.btnInformeMensual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTotalIngresos = new System.Windows.Forms.Label();
            this.lbGanancia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.cbMeses = new System.Windows.Forms.ComboBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.cbAnio = new System.Windows.Forms.ComboBox();
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
            this.cbPeriodo.Location = new System.Drawing.Point(44, 24);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(204, 33);
            this.cbPeriodo.TabIndex = 0;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInformeMensual
            // 
            this.btnInformeMensual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInformeMensual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInformeMensual.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInformeMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformeMensual.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformeMensual.ForeColor = System.Drawing.Color.White;
            this.btnInformeMensual.Location = new System.Drawing.Point(42, 375);
            this.btnInformeMensual.Margin = new System.Windows.Forms.Padding(2);
            this.btnInformeMensual.Name = "btnInformeMensual";
            this.btnInformeMensual.Size = new System.Drawing.Size(155, 68);
            this.btnInformeMensual.TabIndex = 11;
            this.btnInformeMensual.Text = "INFORME MENSUAL";
            this.btnInformeMensual.UseVisualStyleBackColor = true;
            this.btnInformeMensual.Click += new System.EventHandler(this.btnInformeMensual_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "INFORME DIARIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTotalIngresos
            // 
            this.lbTotalIngresos.AutoSize = true;
            this.lbTotalIngresos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIngresos.ForeColor = System.Drawing.Color.White;
            this.lbTotalIngresos.Location = new System.Drawing.Point(38, 104);
            this.lbTotalIngresos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalIngresos.Name = "lbTotalIngresos";
            this.lbTotalIngresos.Size = new System.Drawing.Size(30, 33);
            this.lbTotalIngresos.TabIndex = 13;
            this.lbTotalIngresos.Text = "0";
            // 
            // lbGanancia
            // 
            this.lbGanancia.AutoSize = true;
            this.lbGanancia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGanancia.ForeColor = System.Drawing.Color.White;
            this.lbGanancia.Location = new System.Drawing.Point(40, 186);
            this.lbGanancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGanancia.Name = "lbGanancia";
            this.lbGanancia.Size = new System.Drawing.Size(21, 22);
            this.lbGanancia.TabIndex = 14;
            this.lbGanancia.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Ingresos: ";
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodo.ForeColor = System.Drawing.Color.White;
            this.lbPeriodo.Location = new System.Drawing.Point(159, 85);
            this.lbPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(57, 21);
            this.lbPeriodo.TabIndex = 16;
            this.lbPeriodo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Ganancia";
            // 
            // cbDias
            // 
            this.cbDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDias.DropDownHeight = 150;
            this.cbDias.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDias.FormattingEnabled = true;
            this.cbDias.IntegralHeight = false;
            this.cbDias.ItemHeight = 25;
            this.cbDias.Location = new System.Drawing.Point(42, 328);
            this.cbDias.Margin = new System.Windows.Forms.Padding(2);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(62, 33);
            this.cbDias.TabIndex = 20;
            // 
            // cbMeses
            // 
            this.cbMeses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMeses.DropDownHeight = 150;
            this.cbMeses.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.FormattingEnabled = true;
            this.cbMeses.IntegralHeight = false;
            this.cbMeses.ItemHeight = 25;
            this.cbMeses.Location = new System.Drawing.Point(107, 328);
            this.cbMeses.Margin = new System.Windows.Forms.Padding(2);
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Size = new System.Drawing.Size(61, 33);
            this.cbMeses.TabIndex = 21;
            // 
            // lbMensaje
            // 
            this.lbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbMensaje.Location = new System.Drawing.Point(41, 453);
            this.lbMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(251, 17);
            this.lbMensaje.TabIndex = 24;
            this.lbMensaje.Text = "El Informe fue Generado Exitosamente";
            this.lbMensaje.Visible = false;
            // 
            // cbAnio
            // 
            this.cbAnio.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbAnio.Location = new System.Drawing.Point(252, 24);
            this.cbAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(80, 33);
            this.cbAnio.TabIndex = 25;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(810, 497);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.cbMeses);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGanancia);
            this.Controls.Add(this.lbTotalIngresos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInformeMensual);
            this.Controls.Add(this.cbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reportes";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnInformeMensual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTotalIngresos;
        private System.Windows.Forms.Label lbGanancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.ComboBox cbMeses;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.ComboBox cbAnio;
    }
}