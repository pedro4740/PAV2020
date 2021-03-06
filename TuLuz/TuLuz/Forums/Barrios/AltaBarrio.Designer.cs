﻿namespace TuLuz.Forums
{
    partial class AltaBarrio
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_Localidad = new TuLuz.Clases.ComboBox01();
            this.txt_nombreCliente = new TuLuz.Clases.TextBox01();
            this.txt_codBarrio = new TuLuz.Clases.TextBox01();
            this.cmb_Provincia = new TuLuz.Clases.ComboBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(161, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Barrio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provincia";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(749, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackgroundImage = global::TuLuz.Properties.Resources.cancel_77947;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(567, 405);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 80);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BackgroundImage = global::TuLuz.Properties.Resources.ok_accept_15562;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(174, 405);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 80);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(647, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_Localidad
            // 
            this.cmb_Localidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Localidad.FormattingEnabled = true;
            this.cmb_Localidad.Location = new System.Drawing.Point(175, 366);
            this.cmb_Localidad.Name = "cmb_Localidad";
            this.cmb_Localidad.pp_Display = null;
            this.cmb_Localidad.pp_mensaje_error = null;
            this.cmb_Localidad.pp_nombre_campo = null;
            this.cmb_Localidad.pp_nombre_tabla = null;
            this.cmb_Localidad.pp_Seleccionado = false;
            this.cmb_Localidad.pp_Tabla = null;
            this.cmb_Localidad.pp_validable = false;
            this.cmb_Localidad.pp_Value = null;
            this.cmb_Localidad.Size = new System.Drawing.Size(466, 33);
            this.cmb_Localidad.TabIndex = 10;
            this.cmb_Localidad.Click += new System.EventHandler(this.cmb_Localidad_Click);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreCliente.Location = new System.Drawing.Point(174, 247);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.pp_mensaje_error = "No se ingreso NOMBRE!!";
            this.txt_nombreCliente.pp_nombre_campo = "nombre";
            this.txt_nombreCliente.pp_nombre_tabla = "Cliente";
            this.txt_nombreCliente.pp_validable = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(466, 30);
            this.txt_nombreCliente.TabIndex = 5;
            // 
            // txt_codBarrio
            // 
            this.txt_codBarrio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codBarrio.Location = new System.Drawing.Point(174, 184);
            this.txt_codBarrio.Name = "txt_codBarrio";
            this.txt_codBarrio.pp_mensaje_error = "No se ingreso CUIT!!";
            this.txt_codBarrio.pp_nombre_campo = "codBarrio";
            this.txt_codBarrio.pp_nombre_tabla = "Cliente";
            this.txt_codBarrio.pp_validable = true;
            this.txt_codBarrio.Size = new System.Drawing.Size(466, 30);
            this.txt_codBarrio.TabIndex = 4;
            this.txt_codBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codBarrio_KeyPress);
            // 
            // cmb_Provincia
            // 
            this.cmb_Provincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Provincia.FormattingEnabled = true;
            this.cmb_Provincia.Location = new System.Drawing.Point(175, 306);
            this.cmb_Provincia.Name = "cmb_Provincia";
            this.cmb_Provincia.pp_Display = null;
            this.cmb_Provincia.pp_mensaje_error = null;
            this.cmb_Provincia.pp_nombre_campo = null;
            this.cmb_Provincia.pp_nombre_tabla = null;
            this.cmb_Provincia.pp_Seleccionado = false;
            this.cmb_Provincia.pp_Tabla = null;
            this.cmb_Provincia.pp_validable = false;
            this.cmb_Provincia.pp_Value = null;
            this.cmb_Provincia.Size = new System.Drawing.Size(466, 33);
            this.cmb_Provincia.TabIndex = 13;
            this.cmb_Provincia.SelectedIndexChanged += new System.EventHandler(this.cmb_Provincia_SelectedIndexChanged);
            this.cmb_Provincia.Click += new System.EventHandler(this.cmb_Provincia_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Localidad";
            // 
            // AltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Provincia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb_Localidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_codBarrio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_codBarrio;
        private Clases.TextBox01 txt_nombreCliente;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_Localidad;
        private System.Windows.Forms.Button button2;
        private Clases.ComboBox01 cmb_Provincia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}