﻿namespace kocsis
{
    partial class Autovalasztas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üzemanyagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogyasztasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.autoNeveDataGridViewTextBoxColumn,
            this.üzemanyagDataGridViewTextBoxColumn,
            this.fogyasztasDataGridViewTextBoxColumn,
            this.korDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 211);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // autoNeveDataGridViewTextBoxColumn
            // 
            this.autoNeveDataGridViewTextBoxColumn.DataPropertyName = "AutoNeve";
            this.autoNeveDataGridViewTextBoxColumn.HeaderText = "AutoNeve";
            this.autoNeveDataGridViewTextBoxColumn.Name = "autoNeveDataGridViewTextBoxColumn";
            // 
            // üzemanyagDataGridViewTextBoxColumn
            // 
            this.üzemanyagDataGridViewTextBoxColumn.DataPropertyName = "Üzemanyag";
            this.üzemanyagDataGridViewTextBoxColumn.HeaderText = "Üzemanyag";
            this.üzemanyagDataGridViewTextBoxColumn.Name = "üzemanyagDataGridViewTextBoxColumn";
            // 
            // fogyasztasDataGridViewTextBoxColumn
            // 
            this.fogyasztasDataGridViewTextBoxColumn.DataPropertyName = "Fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.HeaderText = "Fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.Name = "fogyasztasDataGridViewTextBoxColumn";
            // 
            // korDataGridViewTextBoxColumn
            // 
            this.korDataGridViewTextBoxColumn.DataPropertyName = "Kor";
            this.korDataGridViewTextBoxColumn.HeaderText = "Kor";
            this.korDataGridViewTextBoxColumn.Name = "korDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(kocsis.car);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Az autók kiírása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autó keresése";
            // 
            // Autovalasztas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Autovalasztas";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üzemanyagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fogyasztasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}