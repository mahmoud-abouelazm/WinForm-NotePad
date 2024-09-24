namespace WinFormsNotepad
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
            components = new System.ComponentModel.Container();
            btnColor = new Button();
            btnFont = new Button();
            btnExternal = new Button();
            dlgColor = new ColorDialog();
            dlgFont = new FontDialog();
            dlgOpen = new OpenFileDialog();
            dlgSave = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            txtForm = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnColor.Font = new Font("Segoe UI", 12F);
            btnColor.Location = new Point(12, 498);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 40);
            btnColor.TabIndex = 3;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom;
            btnFont.Font = new Font("Segoe UI", 12F);
            btnFont.Location = new Point(248, 498);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 40);
            btnFont.TabIndex = 4;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnExternal
            // 
            btnExternal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExternal.Font = new Font("Segoe UI", 12F);
            btnExternal.Location = new Point(482, 498);
            btnExternal.Name = "btnExternal";
            btnExternal.Size = new Size(106, 40);
            btnExternal.TabIndex = 5;
            btnExternal.Text = "External Text";
            btnExternal.UseVisualStyleBackColor = true;
            btnExternal.Click += btnExternal_Click;
            // 
            // dlgOpen
            // 
            dlgOpen.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(600, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // txtForm
            // 
            txtForm.Location = new Point(12, 27);
            txtForm.Name = "txtForm";
            txtForm.Size = new Size(576, 465);
            txtForm.TabIndex = 8;
            txtForm.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 550);
            Controls.Add(txtForm);
            Controls.Add(btnExternal);
            Controls.Add(btnFont);
            Controls.Add(btnColor);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(450, 504);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Your Notepad";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnColor;
        private Button btnFont;
        private Button btnExternal;
        private ColorDialog dlgColor;
        private FontDialog dlgFont;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox txtForm;
    }
}
