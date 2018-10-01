namespace WindowsFormsApp1
{
    partial class Form_AddClient
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(241, 542);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(131, 44);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "GUARDAR";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(213, 186);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(310, 30);
            this.dtpBirthdate.TabIndex = 3;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ItemHeight = 21;
            this.cbSex.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO",
            "OTRO"});
            this.cbSex.Location = new System.Drawing.Point(213, 248);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(310, 29);
            this.cbSex.TabIndex = 40;
            // 
            // txtObservations
            // 
            this.txtObservations.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservations.Location = new System.Drawing.Point(213, 419);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(310, 99);
            this.txtObservations.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "OBSERVACIONES";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(213, 376);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(213, 333);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 30);
            this.txtAddress.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "EMAIL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "DIRECCIÓN";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(213, 290);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "TELEFONO";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(213, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 30);
            this.txtName.TabIndex = 2;
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(213, 87);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(310, 30);
            this.txtRut.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "SEXO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(38, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "NACIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Datos Cliente";
            // 
            // Form_AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(553, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Cliente";
            this.Load += new System.EventHandler(this.Form_AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
    }
}