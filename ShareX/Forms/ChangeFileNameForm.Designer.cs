namespace ShareX.Forms
{
    partial class ChangeFileNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldFileName = new System.Windows.Forms.TextBox();
            this.btnFileNameSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.lbExtension = new System.Windows.Forms.Label();
            this.lbExtension_ = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原名称";
            // 
            // txtOldFileName
            // 
            this.txtOldFileName.Location = new System.Drawing.Point(112, 25);
            this.txtOldFileName.Name = "txtOldFileName";
            this.txtOldFileName.Size = new System.Drawing.Size(456, 25);
            this.txtOldFileName.TabIndex = 1;
            // 
            // btnFileNameSave
            // 
            this.btnFileNameSave.Location = new System.Drawing.Point(295, 105);
            this.btnFileNameSave.Name = "btnFileNameSave";
            this.btnFileNameSave.Size = new System.Drawing.Size(75, 23);
            this.btnFileNameSave.TabIndex = 2;
            this.btnFileNameSave.Text = "保存";
            this.btnFileNameSave.UseVisualStyleBackColor = true;
            this.btnFileNameSave.Click += new System.EventHandler(this.btnFileNameSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "新名称";
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(112, 63);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(456, 25);
            this.txtNewFileName.TabIndex = 1;
            // 
            // lbExtension
            // 
            this.lbExtension.AutoSize = true;
            this.lbExtension.Location = new System.Drawing.Point(574, 35);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(55, 15);
            this.lbExtension.TabIndex = 3;
            this.lbExtension.Text = "label3";
            // 
            // lbExtension_
            // 
            this.lbExtension_.AutoSize = true;
            this.lbExtension_.Location = new System.Drawing.Point(574, 73);
            this.lbExtension_.Name = "lbExtension_";
            this.lbExtension_.Size = new System.Drawing.Size(55, 15);
            this.lbExtension_.TabIndex = 3;
            this.lbExtension_.Text = "label3";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ChangeFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 138);
            this.Controls.Add(this.lbExtension_);
            this.Controls.Add(this.lbExtension);
            this.Controls.Add(this.btnFileNameSave);
            this.Controls.Add(this.txtNewFileName);
            this.Controls.Add(this.txtOldFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改文件名称";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldFileName;
        private System.Windows.Forms.Button btnFileNameSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Label lbExtension;
        private System.Windows.Forms.Label lbExtension_;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}