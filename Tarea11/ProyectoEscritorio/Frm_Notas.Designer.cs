namespace ProyectoEscritorio
{
    partial class Frm_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notas));
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBox4 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            txtNotaSeleccionada = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            txtNota = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtNotaSeleccionada);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNota);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(32, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(488, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Notas";
            // 
            // textBox4
            // 
            textBox4.BackColor = System.Drawing.SystemColors.Info;
            textBox4.Enabled = false;
            textBox4.Location = new System.Drawing.Point(10, 269);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(300, 61);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(198, 233);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 29);
            button4.TabIndex = 1;
            button4.Text = "Ver Resultado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(23, 183);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(218, 29);
            button3.TabIndex = 7;
            button3.Text = "Limpiar Lista de Notas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnLimpiar;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(21, 148);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(220, 29);
            button2.TabIndex = 6;
            button2.Text = "Eliminar Seleccionado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtNotaSeleccionada
            // 
            txtNotaSeleccionada.Location = new System.Drawing.Point(229, 96);
            txtNotaSeleccionada.Name = "txtNotaSeleccionada";
            txtNotaSeleccionada.Size = new System.Drawing.Size(94, 27);
            txtNotaSeleccionada.TabIndex = 5;
            txtNotaSeleccionada.TextChanged += txtNotaSeleccionada_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 20);
            label2.TabIndex = 4;
            label2.Text = "Nota Seleccionada";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new System.Drawing.Point(328, 42);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(153, 287);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(229, 40);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNota
            // 
            txtNota.Location = new System.Drawing.Point(127, 42);
            txtNota.Name = "txtNota";
            txtNota.Size = new System.Drawing.Size(85, 27);
            txtNota.TabIndex = 1;
            txtNota.TextChanged += txtNota_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite la nota";
            // 
            // Frm_Notas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(532, 403);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Notas";
            Text = "Registro de Notas";
            Load += Frm_Notas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNotaSeleccionada;
        private System.Windows.Forms.Label label2;
    }
}