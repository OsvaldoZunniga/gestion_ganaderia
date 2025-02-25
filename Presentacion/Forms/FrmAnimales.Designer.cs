namespace Presentacion.Forms
{
    partial class FrmAnimales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimales));
            this.dtg_Animales = new System.Windows.Forms.DataGridView();
            this.txt_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Padre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_Madre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtp_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Animales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Animales
            // 
            this.dtg_Animales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Animales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Animales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_Nombre,
            this.txt_Numero,
            this.txt_Raza,
            this.cmb_Padre,
            this.txt_Madre,
            this.dtp_Fecha});
            this.dtg_Animales.Location = new System.Drawing.Point(12, 25);
            this.dtg_Animales.Name = "dtg_Animales";
            this.dtg_Animales.Size = new System.Drawing.Size(776, 394);
            this.dtg_Animales.TabIndex = 0;
            this.dtg_Animales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Animales_CellDoubleClick);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Nombre.HeaderText = "Nombre";
            this.txt_Nombre.Name = "txt_Nombre";
            // 
            // txt_Numero
            // 
            this.txt_Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Numero.HeaderText = "Numero";
            this.txt_Numero.Name = "txt_Numero";
            // 
            // txt_Raza
            // 
            this.txt_Raza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Raza.HeaderText = "Raza";
            this.txt_Raza.Name = "txt_Raza";
            // 
            // cmb_Padre
            // 
            this.cmb_Padre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmb_Padre.HeaderText = "Padre";
            this.cmb_Padre.Name = "cmb_Padre";
            // 
            // txt_Madre
            // 
            this.txt_Madre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_Madre.HeaderText = "Madre";
            this.txt_Madre.Name = "txt_Madre";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.HeaderText = "Fecha ingreso";
            this.dtp_Fecha.Name = "dtp_Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_Animales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAnimales";
            this.Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Animales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Animales;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Raza;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmb_Padre;
        private System.Windows.Forms.DataGridViewComboBoxColumn txt_Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtp_Fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}