using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareX.Forms
{
    public partial class ChangeFileNameForm : Form
    {
        private TaskInfo Info { get; set; }
        public ChangeFileNameForm(TaskInfo task)
        {
            Info = task;
            InitializeComponent();
            if (Info != null)
            {
                txtOldFileName.Text = Path.GetFileNameWithoutExtension(Info.FilePath);
                lbExtension.Text = Path.GetExtension(Info.FilePath);
                lbExtension_.Text = lbExtension.Text;
            }
        }

        private void btnFileNameSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewFileName.Text))
            {
                errorProvider.SetError(txtNewFileName, "新名称不可为空");
                return;
            }
            File.Move(Info.FilePath, string.Format("{0}/{1}{2}", Path.GetDirectoryName(Info.FilePath), txtNewFileName.Text, lbExtension_.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
