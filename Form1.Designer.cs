namespace GeradorMapRepository
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNameProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasDefaultValueSql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colColumnName,
            this.colColumnType,
            this.colNameProperty,
            this.colMaxLength,
            this.colHasDefaultValueSql});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colColumnName
            // 
            this.colColumnName.HeaderText = "Nome da Coluna";
            this.colColumnName.Name = "colColumnName";
            this.colColumnName.ReadOnly = true;
            // 
            // colColumnType
            // 
            this.colColumnType.HeaderText = "Tipo do Dados";
            this.colColumnType.Items.AddRange(new object[] {
            "",
            "uniqueidentifier",
            "datetime",
            "date",
            "varchar",
            "decimal(10,2)",
            "int",
            "text",
            "boolean"});
            this.colColumnType.Name = "colColumnType";
            // 
            // colNameProperty
            // 
            this.colNameProperty.HeaderText = "Property";
            this.colNameProperty.Name = "colNameProperty";
            this.colNameProperty.ReadOnly = true;
            // 
            // colMaxLength
            // 
            this.colMaxLength.HeaderText = "Max Length";
            this.colMaxLength.Name = "colMaxLength";
            // 
            // colHasDefaultValueSql
            // 
            this.colHasDefaultValueSql.HeaderText = "Valor Default SQL";
            this.colHasDefaultValueSql.Name = "colHasDefaultValueSql";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique no botão de importar para utilizar uma classe já existente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Mapping/Configuration Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colColumnName;
        private DataGridViewComboBoxColumn colColumnType;
        private DataGridViewTextBoxColumn colNameProperty;
        private DataGridViewTextBoxColumn colMaxLength;
        private DataGridViewTextBoxColumn colHasDefaultValueSql;
        private OpenFileDialog ofd1;
        private Button button1;
        private Label label1;
    }
}