namespace ComputerWorld.Win
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.listadeVentasPorProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listadeVentasPorProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProductoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeVentasPorProductoBindingSource
            // 
            this.listadeVentasPorProductoBindingSource.DataSource = typeof(ComputerWorld.BL.ReporteVentasPorProducto);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // listadeVentasPorProductoDataGridView
            // 
            this.listadeVentasPorProductoDataGridView.AutoGenerateColumns = false;
            this.listadeVentasPorProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeVentasPorProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.listadeVentasPorProductoDataGridView.DataSource = this.listadeVentasPorProductoBindingSource;
            this.listadeVentasPorProductoDataGridView.Location = new System.Drawing.Point(59, 74);
            this.listadeVentasPorProductoDataGridView.Name = "listadeVentasPorProductoDataGridView";
            this.listadeVentasPorProductoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.listadeVentasPorProductoDataGridView.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(405, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listadeVentasPorProductoDataGridView);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeVentasPorProductoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteDeVentasPorProductoBLBindingSource;
        private System.Windows.Forms.DataGridView reporteDeVentasPorProductoBLDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource listadeVentasPorProductoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView listadeVentasPorProductoDataGridView;
        private System.Windows.Forms.Button button2;
    }
}