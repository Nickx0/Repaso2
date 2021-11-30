
namespace Repaso2
{
    partial class frmRepaso2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.listDesarrollo = new System.Windows.Forms.ListBox();
            this.listSoporte = new System.Windows.Forms.ListBox();
            this.txtDesarrollo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorprove = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorprove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRASLADO INTERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(289, 110);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(129, 23);
            this.txtnombre.TabIndex = 3;
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Items.AddRange(new object[] {
            "Desarrollo",
            "Soporte"});
            this.cboCarrera.Location = new System.Drawing.Point(289, 155);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(159, 23);
            this.cboCarrera.TabIndex = 4;
            // 
            // listDesarrollo
            // 
            this.listDesarrollo.FormattingEnabled = true;
            this.listDesarrollo.ItemHeight = 15;
            this.listDesarrollo.Location = new System.Drawing.Point(85, 206);
            this.listDesarrollo.Name = "listDesarrollo";
            this.listDesarrollo.Size = new System.Drawing.Size(156, 109);
            this.listDesarrollo.TabIndex = 5;
            // 
            // listSoporte
            // 
            this.listSoporte.FormattingEnabled = true;
            this.listSoporte.ItemHeight = 15;
            this.listSoporte.Location = new System.Drawing.Point(347, 206);
            this.listSoporte.Name = "listSoporte";
            this.listSoporte.Size = new System.Drawing.Size(156, 109);
            this.listSoporte.TabIndex = 6;
            // 
            // txtDesarrollo
            // 
            this.txtDesarrollo.Location = new System.Drawing.Point(132, 359);
            this.txtDesarrollo.Name = "txtDesarrollo";
            this.txtDesarrollo.Size = new System.Drawing.Size(109, 23);
            this.txtDesarrollo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // txtSoporte
            // 
            this.txtSoporte.Location = new System.Drawing.Point(408, 359);
            this.txtSoporte.Name = "txtSoporte";
            this.txtSoporte.Size = new System.Drawing.Size(109, 23);
            this.txtSoporte.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(262, 232);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(64, 25);
            this.btnMayor.TabIndex = 11;
            this.btnMayor.Text = ">>";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(262, 277);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(64, 25);
            this.btnMenor.TabIndex = 12;
            this.btnMenor.Text = "<<";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(594, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 48);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(594, 168);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 48);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(594, 232);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(155, 48);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // errorprove
            // 
            this.errorprove.ContainerControl = this;
            // 
            // frmRepaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.txtSoporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesarrollo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSoporte);
            this.Controls.Add(this.listDesarrollo);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRepaso2";
            this.Text = "REPASO 02 - ESTRUCTURA CONDICIONAL";
            ((System.ComponentModel.ISupportInitialize)(this.errorprove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.ListBox listDesarrollo;
        private System.Windows.Forms.ListBox listSoporte;
        private System.Windows.Forms.TextBox txtDesarrollo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorprove;
    }
}

