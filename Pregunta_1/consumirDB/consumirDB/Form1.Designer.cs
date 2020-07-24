namespace consumirDB
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ci_e = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefono_s = new System.Windows.Forms.Label();
            this.materno_s = new System.Windows.Forms.Label();
            this.paterno_s = new System.Windows.Forms.Label();
            this.nombre_s = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "introducir Ci:";
            // 
            // ci_e
            // 
            this.ci_e.Location = new System.Drawing.Point(88, 10);
            this.ci_e.Name = "ci_e";
            this.ci_e.Size = new System.Drawing.Size(100, 20);
            this.ci_e.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // telefono_s
            // 
            this.telefono_s.AutoSize = true;
            this.telefono_s.Location = new System.Drawing.Point(96, 191);
            this.telefono_s.Name = "telefono_s";
            this.telefono_s.Size = new System.Drawing.Size(0, 13);
            this.telefono_s.TabIndex = 10;
            // 
            // materno_s
            // 
            this.materno_s.AutoSize = true;
            this.materno_s.Location = new System.Drawing.Point(97, 156);
            this.materno_s.Name = "materno_s";
            this.materno_s.Size = new System.Drawing.Size(0, 13);
            this.materno_s.TabIndex = 9;
            // 
            // paterno_s
            // 
            this.paterno_s.AutoSize = true;
            this.paterno_s.Location = new System.Drawing.Point(97, 123);
            this.paterno_s.Name = "paterno_s";
            this.paterno_s.Size = new System.Drawing.Size(0, 13);
            this.paterno_s.TabIndex = 8;
            // 
            // nombre_s
            // 
            this.nombre_s.AutoSize = true;
            this.nombre_s.Location = new System.Drawing.Point(97, 88);
            this.nombre_s.Name = "nombre_s";
            this.nombre_s.Size = new System.Drawing.Size(0, 13);
            this.nombre_s.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 273);
            this.Controls.Add(this.telefono_s);
            this.Controls.Add(this.materno_s);
            this.Controls.Add(this.paterno_s);
            this.Controls.Add(this.nombre_s);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ci_e);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ci_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label telefono_s;
        private System.Windows.Forms.Label materno_s;
        private System.Windows.Forms.Label paterno_s;
        private System.Windows.Forms.Label nombre_s;
    }
}

