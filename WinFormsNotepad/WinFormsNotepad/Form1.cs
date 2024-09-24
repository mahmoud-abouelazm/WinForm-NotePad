using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsNotepad
{
    public partial class Form1 : Form
    {   
            
        ExternalText externalText = new ExternalText();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Sure you want to exit?" // message
                , "Exit" // form title
                , MessageBoxButtons.YesNo // form buttons
                , MessageBoxIcon.Warning // type of form
                , MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Rich file|*.rtf|Text file|*.txt";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtForm.LoadFile(dlgOpen.FileName, (RichTextBoxStreamType)(dlgOpen.FilterIndex - 1));
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Rich file|*.rtf|Text file|*.txt";

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                txtForm.SaveFile(dlgSave.FileName, (RichTextBoxStreamType)(dlgSave.FilterIndex - 1));

            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = txtForm.SelectionFont;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtForm.SelectionFont = dlgFont.Font;
            }
        }

        private void btnExternal_Click(object sender, EventArgs e)
        {
            if(externalText.ShowDialog() == DialogResult.OK)
            {
                txtForm.Text = externalText.getString();
            }
        }
    }
}
