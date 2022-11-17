namespace WindowsFormsListaSimple
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.listadatos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cursor = new System.Windows.Forms.Label();
            this.listahoras = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asignaturaprimos = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtasignaturamenor = new System.Windows.Forms.Label();
            this.txthoramenor = new System.Windows.Forms.Label();
            this.txtasignaturamayor = new System.Windows.Forms.Label();
            this.txthoramayor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblprimo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA ENLAZADA SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad Horas";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(53, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(269, 21);
            this.txtnombre.TabIndex = 1;
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(44, 149);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(136, 35);
            this.btninsertar.TabIndex = 3;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(186, 149);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(136, 35);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimero.Location = new System.Drawing.Point(44, 231);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(136, 35);
            this.btnprimero.TabIndex = 5;
            this.btnprimero.Text = "PRIMERO";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanterior.Location = new System.Drawing.Point(44, 190);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(136, 35);
            this.btnanterior.TabIndex = 6;
            this.btnanterior.Text = "ANTERIOR";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.Location = new System.Drawing.Point(186, 190);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(136, 35);
            this.btnsiguiente.TabIndex = 7;
            this.btnsiguiente.Text = "SIGUIENTE";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnultimo.Location = new System.Drawing.Point(186, 231);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(136, 35);
            this.btnultimo.TabIndex = 8;
            this.btnultimo.Text = "ULTIMO";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // txthoras
            // 
            this.txthoras.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoras.Location = new System.Drawing.Point(53, 120);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(269, 22);
            this.txthoras.TabIndex = 2;
            // 
            // listadatos
            // 
            this.listadatos.FormattingEnabled = true;
            this.listadatos.Location = new System.Drawing.Point(331, 78);
            this.listadatos.Name = "listadatos";
            this.listadatos.Size = new System.Drawing.Size(102, 147);
            this.listadatos.TabIndex = 10;
            this.listadatos.SelectedIndexChanged += new System.EventHandler(this.listadatos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cursor:";
            // 
            // cursor
            // 
            this.cursor.AutoSize = true;
            this.cursor.Location = new System.Drawing.Point(384, 231);
            this.cursor.Name = "cursor";
            this.cursor.Size = new System.Drawing.Size(36, 13);
            this.cursor.TabIndex = 11;
            this.cursor.Text = "cursor";
            // 
            // listahoras
            // 
            this.listahoras.FormattingEnabled = true;
            this.listahoras.Location = new System.Drawing.Point(439, 78);
            this.listahoras.Name = "listahoras";
            this.listahoras.Size = new System.Drawing.Size(55, 147);
            this.listahoras.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MATERIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "HORAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblprimo);
            this.groupBox1.Controls.Add(this.txthoramayor);
            this.groupBox1.Controls.Add(this.txthoramenor);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtasignaturamayor);
            this.groupBox1.Controls.Add(this.txtasignaturamenor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.asignaturaprimos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 177);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRACTICA";
            // 
            // asignaturaprimos
            // 
            this.asignaturaprimos.FormattingEnabled = true;
            this.asignaturaprimos.Location = new System.Drawing.Point(252, 27);
            this.asignaturaprimos.Name = "asignaturaprimos";
            this.asignaturaprimos.Size = new System.Drawing.Size(184, 134);
            this.asignaturaprimos.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Asignaturas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Asignatura con menor cantidad de horas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Asignatura con mayor cantidad de horas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Promedio de horas de las asignatura";
            // 
            // txtasignaturamenor
            // 
            this.txtasignaturamenor.AutoSize = true;
            this.txtasignaturamenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasignaturamenor.Location = new System.Drawing.Point(15, 49);
            this.txtasignaturamenor.Name = "txtasignaturamenor";
            this.txtasignaturamenor.Size = new System.Drawing.Size(56, 13);
            this.txtasignaturamenor.TabIndex = 11;
            this.txtasignaturamenor.Text = "asignatura";
            // 
            // txthoramenor
            // 
            this.txthoramenor.AutoSize = true;
            this.txthoramenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoramenor.Location = new System.Drawing.Point(82, 49);
            this.txthoramenor.Name = "txthoramenor";
            this.txthoramenor.Size = new System.Drawing.Size(28, 13);
            this.txthoramenor.TabIndex = 11;
            this.txthoramenor.Text = "hora";
            // 
            // txtasignaturamayor
            // 
            this.txtasignaturamayor.AutoSize = true;
            this.txtasignaturamayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasignaturamayor.Location = new System.Drawing.Point(15, 93);
            this.txtasignaturamayor.Name = "txtasignaturamayor";
            this.txtasignaturamayor.Size = new System.Drawing.Size(56, 13);
            this.txtasignaturamayor.TabIndex = 11;
            this.txtasignaturamayor.Text = "asignatura";
            // 
            // txthoramayor
            // 
            this.txthoramayor.AutoSize = true;
            this.txthoramayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoramayor.Location = new System.Drawing.Point(82, 93);
            this.txthoramayor.Name = "txthoramayor";
            this.txthoramayor.Size = new System.Drawing.Size(28, 13);
            this.txthoramayor.TabIndex = 11;
            this.txthoramayor.Text = "hora";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Promedio";
            // 
            // lblprimo
            // 
            this.lblprimo.AutoSize = true;
            this.lblprimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimo.Location = new System.Drawing.Point(82, 137);
            this.lblprimo.Name = "lblprimo";
            this.lblprimo.Size = new System.Drawing.Size(13, 13);
            this.lblprimo.TabIndex = 11;
            this.lblprimo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listahoras);
            this.Controls.Add(this.cursor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listadatos);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.ListBox listadatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cursor;
        private System.Windows.Forms.ListBox listahoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblprimo;
        private System.Windows.Forms.Label txthoramayor;
        private System.Windows.Forms.Label txthoramenor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtasignaturamayor;
        private System.Windows.Forms.Label txtasignaturamenor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox asignaturaprimos;
    }
}

