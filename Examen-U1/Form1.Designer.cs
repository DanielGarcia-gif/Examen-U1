namespace Examen_U1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            butAbrir = new Button();
            openFileDialogAbrir = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewDatos, 0, 0);
            tableLayoutPanel1.Controls.Add(butAbrir, 0, 1);
            tableLayoutPanel1.Location = new Point(22, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.Size = new Size(388, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewDatos.Dock = DockStyle.Fill;
            dataGridViewDatos.Location = new Point(3, 3);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(382, 258);
            dataGridViewDatos.TabIndex = 0;
            dataGridViewDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "CURP";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Promedio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 90;
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 90;
            // 
            // butAbrir
            // 
            butAbrir.Anchor = AnchorStyles.None;
            butAbrir.Location = new Point(156, 270);
            butAbrir.Name = "butAbrir";
            butAbrir.Size = new Size(75, 23);
            butAbrir.TabIndex = 1;
            butAbrir.Text = "Abrir";
            butAbrir.UseVisualStyleBackColor = true;
            butAbrir.Click += butAbrir_Click;
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.FileName = "openFileDialog1";
            openFileDialogAbrir.Filter = "Archivo CSV | *.csv";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 342);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewDatos;
        private Button butAbrir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private OpenFileDialog openFileDialogAbrir;
    }
}
