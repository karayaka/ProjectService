
namespace ServicesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoriName = new System.Windows.Forms.TextBox();
            this.txtCategoriDesc = new System.Windows.Forms.TextBox();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnFormReset = new System.Windows.Forms.Button();
            this.btnRefres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Açıklama:";
            // 
            // txtCategoriName
            // 
            this.txtCategoriName.Location = new System.Drawing.Point(119, 88);
            this.txtCategoriName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoriName.Name = "txtCategoriName";
            this.txtCategoriName.Size = new System.Drawing.Size(159, 23);
            this.txtCategoriName.TabIndex = 2;
            // 
            // txtCategoriDesc
            // 
            this.txtCategoriDesc.Location = new System.Drawing.Point(119, 121);
            this.txtCategoriDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoriDesc.Name = "txtCategoriDesc";
            this.txtCategoriDesc.Size = new System.Drawing.Size(159, 23);
            this.txtCategoriDesc.TabIndex = 3;
            // 
            // grdCategory
            // 
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Description});
            this.grdCategory.Location = new System.Drawing.Point(302, 88);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RowTemplate.Height = 25;
            this.grdCategory.Size = new System.Drawing.Size(425, 246);
            this.grdCategory.TabIndex = 4;
            this.grdCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategory_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Kategori Adı";
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Kategori Açıklama";
            this.Description.Name = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntDelete.Location = new System.Drawing.Point(116, 168);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 6;
            this.bntDelete.Text = "Sil";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnFormReset
            // 
            this.btnFormReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFormReset.Location = new System.Drawing.Point(197, 168);
            this.btnFormReset.Name = "btnFormReset";
            this.btnFormReset.Size = new System.Drawing.Size(75, 23);
            this.btnFormReset.TabIndex = 7;
            this.btnFormReset.Text = "Temizle";
            this.btnFormReset.UseVisualStyleBackColor = true;
            this.btnFormReset.Click += new System.EventHandler(this.btnFormReset_Click);
            // 
            // btnRefres
            // 
            this.btnRefres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefres.Location = new System.Drawing.Point(652, 59);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(75, 23);
            this.btnRefres.TabIndex = 8;
            this.btnRefres.Text = "Yenile";
            this.btnRefres.UseVisualStyleBackColor = true;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 337);
            this.Controls.Add(this.btnRefres);
            this.Controls.Add(this.btnFormReset);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.txtCategoriDesc);
            this.Controls.Add(this.txtCategoriName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "Form1";
            this.Text = "Categoriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoriName;
        private System.Windows.Forms.TextBox txtCategoriDesc;
        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnFormReset;
        private System.Windows.Forms.Button btnRefres;
    }
}

