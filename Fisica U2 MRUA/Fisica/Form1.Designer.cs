namespace Fisica
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
            this.label1 = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalx = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ylabel = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un avion que va a una velocidad de";
            // 
            // velocidad
            // 
            this.velocidad.Location = new System.Drawing.Point(208, 21);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(57, 20);
            this.velocidad.TabIndex = 1;
            this.velocidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.velocidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "m/s  tira una caja .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Que distancia recorre horizontalmente al tocar el suelo si el avion vuela";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "a una altura de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "m  ?";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(106, 63);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(60, 20);
            this.altura.TabIndex = 6;
            this.altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altura_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalx
            // 
            this.totalx.AutoSize = true;
            this.totalx.Location = new System.Drawing.Point(274, 123);
            this.totalx.Name = "totalx";
            this.totalx.Size = new System.Drawing.Size(57, 13);
            this.totalx.TabIndex = 8;
            this.totalx.Text = "___Metros";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(274, 149);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(73, 13);
            this.tiempo.TabIndex = 12;
            this.tiempo.Text = "___Segundos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(68, 299);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(13, 13);
            this.ylabel.TabIndex = 14;
            this.ylabel.Text = "h";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(216, 411);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(12, 13);
            this.xlabel.TabIndex = 15;
            this.xlabel.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 436);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.totalx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Problema MUA";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox velocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalx;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label xlabel;
    }
}

