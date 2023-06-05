namespace CapaPresentacion
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            groupBox1 = new System.Windows.Forms.GroupBox();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox7 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtDirección = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtApellidos_Cliente = new System.Windows.Forms.TextBox();
            txtNombre_Cliente = new System.Windows.Forms.TextBox();
            txtID_Cliente = new System.Windows.Forms.TextBox();
            txtCodigo = new System.Windows.Forms.TextBox();
            ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDirección);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtApellidos_Cliente);
            groupBox1.Controls.Add(txtNombre_Cliente);
            groupBox1.Controls.Add(txtID_Cliente);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Location = new System.Drawing.Point(35, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(729, 424);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button5
            // 
            button5.Image = (System.Drawing.Image)resources.GetObject("button5.Image");
            button5.Location = new System.Drawing.Point(439, 333);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(116, 85);
            button5.TabIndex = 19;
            button5.Text = "Guardar";
            button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button4.Location = new System.Drawing.Point(575, 333);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(108, 85);
            button4.TabIndex = 18;
            button4.Text = "Salir";
            button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button3.Location = new System.Drawing.Point(311, 333);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(108, 85);
            button3.TabIndex = 17;
            button3.Text = "Buscar";
            button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.Location = new System.Drawing.Point(176, 333);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 85);
            button2.TabIndex = 16;
            button2.Text = "Eliminar";
            button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button1.Location = new System.Drawing.Point(42, 333);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(114, 85);
            button1.TabIndex = 15;
            button1.Text = "Nuevo";
            button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION });
            dataGridView1.Location = new System.Drawing.Point(16, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(699, 86);
            dataGridView1.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            textBox7.Enabled = false;
            textBox7.Location = new System.Drawing.Point(562, 23);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(153, 92);
            textBox7.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(22, 207);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(119, 20);
            label6.TabIndex = 12;
            label6.Text = "Dirección Exacta";
            // 
            // txtDirección
            // 
            txtDirección.Location = new System.Drawing.Point(16, 128);
            txtDirección.Multiline = true;
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new System.Drawing.Size(699, 76);
            txtDirección.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(185, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(157, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(125, 27);
            txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(370, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(186, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "Identificación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Código";
            // 
            // txtApellidos_Cliente
            // 
            txtApellidos_Cliente.Location = new System.Drawing.Point(288, 26);
            txtApellidos_Cliente.Name = "txtApellidos_Cliente";
            txtApellidos_Cliente.Size = new System.Drawing.Size(263, 27);
            txtApellidos_Cliente.TabIndex = 3;
            // 
            // txtNombre_Cliente
            // 
            txtNombre_Cliente.Location = new System.Drawing.Point(157, 26);
            txtNombre_Cliente.Name = "txtNombre_Cliente";
            txtNombre_Cliente.Size = new System.Drawing.Size(125, 27);
            txtNombre_Cliente.TabIndex = 2;
            // 
            // txtID_Cliente
            // 
            txtID_Cliente.Location = new System.Drawing.Point(16, 26);
            txtID_Cliente.Name = "txtID_Cliente";
            txtID_Cliente.Size = new System.Drawing.Size(125, 27);
            txtID_Cliente.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.SystemColors.Info;
            txtCodigo.Location = new System.Drawing.Point(16, 78);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new System.Drawing.Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // ID_CLIENTE
            // 
            ID_CLIENTE.HeaderText = "ID_CLIENTE";
            ID_CLIENTE.MinimumWidth = 6;
            ID_CLIENTE.Name = "ID_CLIENTE";
            ID_CLIENTE.Width = 207;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 500;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 200;
            // 
            // DIRECCION
            // 
            DIRECCION.HeaderText = "DIRECCION";
            DIRECCION.MinimumWidth = 6;
            DIRECCION.Name = "DIRECCION";
            DIRECCION.Visible = false;
            DIRECCION.Width = 125;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmClientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID_Cliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtApellidos_Cliente;
        private System.Windows.Forms.TextBox txtNombre_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    }
}