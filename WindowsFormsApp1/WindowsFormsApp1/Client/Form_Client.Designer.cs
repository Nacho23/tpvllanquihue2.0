namespace WindowsFormsApp1
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPropiedades = new System.Windows.Forms.Panel();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPropiedades
            // 
            this.panelPropiedades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.panelPropiedades.Controls.Add(this.txtDeuda);
            this.panelPropiedades.Controls.Add(this.label9);
            this.panelPropiedades.Controls.Add(this.txtName);
            this.panelPropiedades.Controls.Add(this.txtRut);
            this.panelPropiedades.Controls.Add(this.btnPay);
            this.panelPropiedades.Controls.Add(this.label4);
            this.panelPropiedades.Controls.Add(this.label3);
            this.panelPropiedades.Controls.Add(this.label2);
            this.panelPropiedades.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPropiedades.Location = new System.Drawing.Point(610, 0);
            this.panelPropiedades.Name = "panelPropiedades";
            this.panelPropiedades.Size = new System.Drawing.Size(470, 612);
            this.panelPropiedades.TabIndex = 18;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.Location = new System.Drawing.Point(188, 196);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(259, 30);
            this.txtDeuda.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "DEUDA";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(188, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtRut
            // 
            this.txtRut.Enabled = false;
            this.txtRut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(188, 113);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(259, 30);
            this.txtRut.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos Cliente";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(216, 633);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 41);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(94, 633);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 41);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvClients.ColumnHeadersHeight = 30;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvClients.Location = new System.Drawing.Point(50, 121);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(475, 417);
            this.dgvClients.TabIndex = 23;
            this.dgvClients.Click += new System.EventHandler(this.dgvClients_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(349, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 41);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "BORRAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(42, 550);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(386, 50);
            this.btnPay.TabIndex = 21;
            this.btnPay.Text = "ABONAR";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClient.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchClient.Location = new System.Drawing.Point(50, 68);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(475, 30);
            this.txtSearchClient.TabIndex = 19;
            this.txtSearchClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchClient_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(227, 559);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 41);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearchClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPropiedades);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Form_Client";
            this.panelPropiedades.ResumeLayout(false);
            this.panelPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPropiedades;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
    }
}