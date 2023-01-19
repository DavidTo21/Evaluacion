namespace TestDevBackJr
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
            this.DGVlistado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTpaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTlogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTsueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNtop10 = new System.Windows.Forms.Button();
            this.BTNactualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLuseId = new System.Windows.Forms.Label();
            this.BTNgenerarCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlistado
            // 
            this.DGVlistado.AllowUserToDeleteRows = false;
            this.DGVlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistado.Location = new System.Drawing.Point(12, 53);
            this.DGVlistado.Name = "DGVlistado";
            this.DGVlistado.ReadOnly = true;
            this.DGVlistado.Size = new System.Drawing.Size(561, 276);
            this.DGVlistado.TabIndex = 0;
            this.DGVlistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVlistado_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // TXTnombre
            // 
            this.TXTnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTnombre.Location = new System.Drawing.Point(620, 135);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(236, 20);
            this.TXTnombre.TabIndex = 2;
            // 
            // TXTpaterno
            // 
            this.TXTpaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTpaterno.Location = new System.Drawing.Point(620, 174);
            this.TXTpaterno.Name = "TXTpaterno";
            this.TXTpaterno.Size = new System.Drawing.Size(236, 20);
            this.TXTpaterno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paterno:";
            // 
            // TXTlogin
            // 
            this.TXTlogin.Location = new System.Drawing.Point(620, 96);
            this.TXTlogin.Name = "TXTlogin";
            this.TXTlogin.Size = new System.Drawing.Size(236, 20);
            this.TXTlogin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login:";
            // 
            // TXTmaterno
            // 
            this.TXTmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTmaterno.Location = new System.Drawing.Point(620, 213);
            this.TXTmaterno.Name = "TXTmaterno";
            this.TXTmaterno.Size = new System.Drawing.Size(236, 20);
            this.TXTmaterno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materno:";
            // 
            // TXTsueldo
            // 
            this.TXTsueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTsueldo.Location = new System.Drawing.Point(620, 252);
            this.TXTsueldo.Name = "TXTsueldo";
            this.TXTsueldo.Size = new System.Drawing.Size(236, 20);
            this.TXTsueldo.TabIndex = 10;
            this.TXTsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTsueldo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sueldo:";
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(668, 287);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(75, 23);
            this.BTNagregar.TabIndex = 11;
            this.BTNagregar.Text = "Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Location = new System.Drawing.Point(749, 287);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 12;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNtop10
            // 
            this.BTNtop10.Location = new System.Drawing.Point(467, 24);
            this.BTNtop10.Name = "BTNtop10";
            this.BTNtop10.Size = new System.Drawing.Size(106, 23);
            this.BTNtop10.TabIndex = 13;
            this.BTNtop10.Text = "Consultar Top 10";
            this.BTNtop10.UseVisualStyleBackColor = true;
            this.BTNtop10.Click += new System.EventHandler(this.BTNtop10_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.Location = new System.Drawing.Point(355, 24);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(106, 23);
            this.BTNactualizar.TabIndex = 14;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = true;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "userId:";
            // 
            // LBLuseId
            // 
            this.LBLuseId.AutoSize = true;
            this.LBLuseId.Location = new System.Drawing.Point(830, 64);
            this.LBLuseId.Name = "LBLuseId";
            this.LBLuseId.Size = new System.Drawing.Size(16, 13);
            this.LBLuseId.TabIndex = 16;
            this.LBLuseId.Text = "...";
            // 
            // BTNgenerarCSV
            // 
            this.BTNgenerarCSV.Location = new System.Drawing.Point(749, 24);
            this.BTNgenerarCSV.Name = "BTNgenerarCSV";
            this.BTNgenerarCSV.Size = new System.Drawing.Size(106, 23);
            this.BTNgenerarCSV.TabIndex = 17;
            this.BTNgenerarCSV.Text = "CSV";
            this.BTNgenerarCSV.UseVisualStyleBackColor = true;
            this.BTNgenerarCSV.Click += new System.EventHandler(this.BTNgenerarCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 347);
            this.Controls.Add(this.BTNgenerarCSV);
            this.Controls.Add(this.LBLuseId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.BTNtop10);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.TXTsueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTmaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTpaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVlistado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios-Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVlistado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTpaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTsueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.Button BTNlimpiar;
        private System.Windows.Forms.Button BTNtop10;
        private System.Windows.Forms.Button BTNactualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBLuseId;
        private System.Windows.Forms.Button BTNgenerarCSV;
    }
}

