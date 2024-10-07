namespace CompraVenta
{
    partial class VentasForm
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
            this.productoSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.creditoSelect = new System.Windows.Forms.RadioButton();
            this.debitoSelect = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.direccionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rutInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.tablaForm = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ventasOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaForm)).BeginInit();
            this.SuspendLayout();
            // 
            // productoSelect
            // 
            this.productoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productoSelect.FormattingEnabled = true;
            this.productoSelect.Items.AddRange(new object[] {
            "Samsung A10",
            "Xiaomi Mi10T",
            "iPhone 16 Pro",
            "OnePlus 6 Pro"});
            this.productoSelect.Location = new System.Drawing.Point(329, 29);
            this.productoSelect.Name = "productoSelect";
            this.productoSelect.Size = new System.Drawing.Size(121, 24);
            this.productoSelect.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ventasOutput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.eliminarBtn);
            this.groupBox1.Controls.Add(this.editarBtn);
            this.groupBox1.Controls.Add(this.agregarBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.creditoSelect);
            this.groupBox1.Controls.Add(this.debitoSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.direccionInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rutInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombreInput);
            this.groupBox1.Controls.Add(this.productoSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(427, 112);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 29);
            this.eliminarBtn.TabIndex = 13;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(346, 112);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 29);
            this.editarBtn.TabIndex = 12;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(265, 112);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 29);
            this.agregarBtn.TabIndex = 11;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medio de pago";
            // 
            // creditoSelect
            // 
            this.creditoSelect.AutoSize = true;
            this.creditoSelect.Location = new System.Drawing.Point(440, 73);
            this.creditoSelect.Name = "creditoSelect";
            this.creditoSelect.Size = new System.Drawing.Size(71, 20);
            this.creditoSelect.TabIndex = 9;
            this.creditoSelect.TabStop = true;
            this.creditoSelect.Text = "Crédito";
            this.creditoSelect.UseVisualStyleBackColor = true;
            // 
            // debitoSelect
            // 
            this.debitoSelect.AutoSize = true;
            this.debitoSelect.Location = new System.Drawing.Point(366, 73);
            this.debitoSelect.Name = "debitoSelect";
            this.debitoSelect.Size = new System.Drawing.Size(68, 20);
            this.debitoSelect.TabIndex = 8;
            this.debitoSelect.TabStop = true;
            this.debitoSelect.Text = "Débito";
            this.debitoSelect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección";
            // 
            // direccionInput
            // 
            this.direccionInput.Location = new System.Drawing.Point(76, 112);
            this.direccionInput.Name = "direccionInput";
            this.direccionInput.Size = new System.Drawing.Size(168, 22);
            this.direccionInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "RUT";
            // 
            // rutInput
            // 
            this.rutInput.Location = new System.Drawing.Point(76, 71);
            this.rutInput.Name = "rutInput";
            this.rutInput.Size = new System.Drawing.Size(168, 22);
            this.rutInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // nombreInput
            // 
            this.nombreInput.Location = new System.Drawing.Point(76, 32);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(168, 22);
            this.nombreInput.TabIndex = 1;
            // 
            // tablaForm
            // 
            this.tablaForm.AllowUserToAddRows = false;
            this.tablaForm.AllowUserToDeleteRows = false;
            this.tablaForm.AllowUserToResizeColumns = false;
            this.tablaForm.AllowUserToResizeRows = false;
            this.tablaForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaForm.ColumnHeadersHeight = 29;
            this.tablaForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaForm.Location = new System.Drawing.Point(12, 201);
            this.tablaForm.Name = "tablaForm";
            this.tablaForm.ReadOnly = true;
            this.tablaForm.RowHeadersWidth = 51;
            this.tablaForm.RowTemplate.Height = 24;
            this.tablaForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaForm.Size = new System.Drawing.Size(776, 237);
            this.tablaForm.TabIndex = 2;
            this.tablaForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaForm_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ganancias Totales";
            // 
            // ventasOutput
            // 
            this.ventasOutput.AutoSize = true;
            this.ventasOutput.Location = new System.Drawing.Point(593, 59);
            this.ventasOutput.Name = "ventasOutput";
            this.ventasOutput.Size = new System.Drawing.Size(21, 16);
            this.ventasOutput.TabIndex = 15;
            this.ventasOutput.Text = "$0";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.tablaForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox productoSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox direccionInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rutInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton creditoSelect;
        private System.Windows.Forms.RadioButton debitoSelect;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DataGridView tablaForm;
        private System.Windows.Forms.Label ventasOutput;
        private System.Windows.Forms.Label label6;
    }
}

