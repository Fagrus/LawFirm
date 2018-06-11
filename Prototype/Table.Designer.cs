namespace Prototype
{
    partial class Table
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
            this.pro_tblTableAdapter1 = new Prototype.ProtoDataSetTableAdapters.Pro_tblTableAdapter();
            this.tableAdapterManager1 = new Prototype.ProtoDataSetTableAdapters.TableAdapterManager();
            this.protoDataSet1 = new Prototype.ProtoDataSet();
            this.pro_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.protoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pro_tblTableAdapter1
            // 
            this.pro_tblTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Pro_tblTableAdapter = this.pro_tblTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Prototype.ProtoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // protoDataSet1
            // 
            this.protoDataSet1.DataSetName = "ProtoDataSet";
            this.protoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_tblBindingSource
            // 
            this.pro_tblBindingSource.DataMember = "Pro_tbl";
            this.pro_tblBindingSource.DataSource = this.protoDataSet1;
            // 
            // pro_tblDataGridView
            // 
            this.pro_tblDataGridView.AutoGenerateColumns = false;
            this.pro_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pro_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pro_tblDataGridView.DataSource = this.pro_tblBindingSource;
            this.pro_tblDataGridView.Location = new System.Drawing.Point(38, 42);
            this.pro_tblDataGridView.Name = "pro_tblDataGridView";
            this.pro_tblDataGridView.Size = new System.Drawing.Size(342, 219);
            this.pro_tblDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(13, 13);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 2;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.pro_tblDataGridView);
            this.Name = "Table";
            this.Text = "Table";
            ((System.ComponentModel.ISupportInitialize)(this.protoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProtoDataSetTableAdapters.Pro_tblTableAdapter pro_tblTableAdapter1;
        private ProtoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ProtoDataSet protoDataSet1;
        private System.Windows.Forms.BindingSource pro_tblBindingSource;
        private System.Windows.Forms.DataGridView pro_tblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button Back_btn;
    }
}