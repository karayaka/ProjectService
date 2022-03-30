
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Açıklama:";
            // 
            // txtCategoriName
            // 
            this.txtCategoriName.Location = new System.Drawing.Point(219, 12);
            this.txtCategoriName.Name = "txtCategoriName";
            this.txtCategoriName.Size = new System.Drawing.Size(225, 31);
            this.txtCategoriName.TabIndex = 2;
            // 
            // txtCategoriDesc
            // 
            this.txtCategoriDesc.Location = new System.Drawing.Point(219, 48);
            this.txtCategoriDesc.Name = "txtCategoriDesc";
            this.txtCategoriDesc.Size = new System.Drawing.Size(225, 31);
            this.txtCategoriDesc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 562);
            this.Controls.Add(this.txtCategoriDesc);
            this.Controls.Add(this.txtCategoriName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Categoriler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoriName;
        private System.Windows.Forms.TextBox txtCategoriDesc;
    }
}

