namespace Prototype
{
    partial class Main
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
            System.Windows.Forms.Label Id_lbl;
            System.Windows.Forms.Label Name_lbl;
            System.Windows.Forms.Label SN_lbl;
            this.Add_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.Nxt_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.pro_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.protoDataSet = new Prototype.ProtoDataSet();
            this.pro_tblTableAdapter = new Prototype.ProtoDataSetTableAdapters.Pro_tblTableAdapter();
            this.tableAdapterManager = new Prototype.ProtoDataSetTableAdapters.TableAdapterManager();
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.SN_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Id_lbl = new System.Windows.Forms.Label();
            Name_lbl = new System.Windows.Forms.Label();
            SN_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Id_lbl
            // 
            Id_lbl.AutoSize = true;
            Id_lbl.Location = new System.Drawing.Point(62, 106);
            Id_lbl.Name = "Id_lbl";
            Id_lbl.Size = new System.Drawing.Size(19, 13);
            Id_lbl.TabIndex = 39;
            Id_lbl.Text = "Id:";
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Location = new System.Drawing.Point(62, 132);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new System.Drawing.Size(38, 13);
            Name_lbl.TabIndex = 41;
            Name_lbl.Text = "Name:";
            // 
            // SN_lbl
            // 
            SN_lbl.AutoSize = true;
            SN_lbl.Location = new System.Drawing.Point(62, 158);
            SN_lbl.Name = "SN_lbl";
            SN_lbl.Size = new System.Drawing.Size(52, 13);
            SN_lbl.TabIndex = 43;
            SN_lbl.Text = "Surname:";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(95, 32);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(90, 23);
            this.Add_btn.TabIndex = 39;
            this.Add_btn.Text = "+";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(14, 32);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(75, 23);
            this.prev_btn.TabIndex = 38;
            this.prev_btn.Text = "Previous";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // Nxt_btn
            // 
            this.Nxt_btn.Location = new System.Drawing.Point(191, 32);
            this.Nxt_btn.Name = "Nxt_btn";
            this.Nxt_btn.Size = new System.Drawing.Size(75, 23);
            this.Nxt_btn.TabIndex = 37;
            this.Nxt_btn.Text = "Next";
            this.Nxt_btn.UseVisualStyleBackColor = true;
            this.Nxt_btn.Click += new System.EventHandler(this.Nxt_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(191, 236);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 36;
            this.Delete_btn.Text = "Delete Record";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(13, 236);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 26;
            this.Save_btn.Text = "Save record";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // pro_tblBindingSource
            // 
            this.pro_tblBindingSource.DataMember = "Pro_tbl";
            this.pro_tblBindingSource.DataSource = this.protoDataSet;
            // 
            // protoDataSet
            // 
            this.protoDataSet.DataSetName = "ProtoDataSet";
            this.protoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_tblTableAdapter
            // 
            this.pro_tblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pro_tblTableAdapter = this.pro_tblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prototype.ProtoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Id_txt
            // 
            this.Id_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pro_tblBindingSource, "Id", true));
            this.Id_txt.Location = new System.Drawing.Point(120, 103);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(100, 20);
            this.Id_txt.TabIndex = 40;
            // 
            // Name_txt
            // 
            this.Name_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pro_tblBindingSource, "Name", true));
            this.Name_txt.Location = new System.Drawing.Point(120, 129);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 20);
            this.Name_txt.TabIndex = 42;
            // 
            // SN_txt
            // 
            this.SN_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pro_tblBindingSource, "Surname", true));
            this.SN_txt.Location = new System.Drawing.Point(120, 155);
            this.SN_txt.Name = "SN_txt";
            this.SN_txt.Size = new System.Drawing.Size(100, 20);
            this.SN_txt.TabIndex = 44;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToLoginToolStripMenuItem,
            this.dataTableViewToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // backToLoginToolStripMenuItem
            // 
            this.backToLoginToolStripMenuItem.Name = "backToLoginToolStripMenuItem";
            this.backToLoginToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.backToLoginToolStripMenuItem.Text = "Back to Login";
            this.backToLoginToolStripMenuItem.Click += new System.EventHandler(this.backToLoginToolStripMenuItem_Click_1);
            // 
            // dataTableViewToolStripMenuItem
            // 
            this.dataTableViewToolStripMenuItem.Name = "dataTableViewToolStripMenuItem";
            this.dataTableViewToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dataTableViewToolStripMenuItem.Text = "Data Table View";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(Id_lbl);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(Name_lbl);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(SN_lbl);
            this.Controls.Add(this.SN_txt);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.Nxt_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pro_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProtoDataSet protoDataSet;
        private System.Windows.Forms.BindingSource pro_tblBindingSource;
        private ProtoDataSetTableAdapters.Pro_tblTableAdapter pro_tblTableAdapter;
        private ProtoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button Nxt_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox SN_txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTableViewToolStripMenuItem;

    }
}