
namespace SimpleTextEditor
{
    partial class TextEditorScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.newButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.openButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.saveButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.saveAsButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.italicsButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.underLineButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.fontSizeStripTop = new System.Windows.Forms.ToolStripComboBox();
            this.aboutButtonStripTop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userNameStripTop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLeft = new System.Windows.Forms.ToolStrip();
            this.cutButtonStripLeft = new System.Windows.Forms.ToolStripButton();
            this.copyButtonStripLeft = new System.Windows.Forms.ToolStripButton();
            this.pasteButtonStripLeft = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.toolStripLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1274, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.CheckOnClick = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::SimpleTextEditor.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.ToolTipText = "New (Ctrl+N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.ToolTipText = "Open (Ctrl+O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save (Ctrl+S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.ToolTipText = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.ToolTipText = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.ToolTipText = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.ToolTipText = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.ToolTipText = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripTop
            // 
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButtonStripTop,
            this.openButtonStripTop,
            this.saveButtonStripTop,
            this.saveAsButtonStripTop,
            this.toolStripSeparator1,
            this.boldButtonStripTop,
            this.italicsButtonStripTop,
            this.underLineButtonStripTop,
            this.fontSizeStripTop,
            this.aboutButtonStripTop,
            this.toolStripSeparator2,
            this.userNameStripTop});
            this.toolStripTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripTop.Location = new System.Drawing.Point(0, 28);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(1274, 29);
            this.toolStripTop.TabIndex = 1;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // newButtonStripTop
            // 
            this.newButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("newButtonStripTop.Image")));
            this.newButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButtonStripTop.Name = "newButtonStripTop";
            this.newButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.newButtonStripTop.Text = "toolStripButton1";
            this.newButtonStripTop.ToolTipText = "New (Ctrl+N)";
            this.newButtonStripTop.Click += new System.EventHandler(this.newButtonStripTop_Click);
            // 
            // openButtonStripTop
            // 
            this.openButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("openButtonStripTop.Image")));
            this.openButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButtonStripTop.Name = "openButtonStripTop";
            this.openButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.openButtonStripTop.Text = "toolStripButton1";
            this.openButtonStripTop.ToolTipText = "Open (Ctrl+O)";
            this.openButtonStripTop.Click += new System.EventHandler(this.openButtonStripTop_Click);
            // 
            // saveButtonStripTop
            // 
            this.saveButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("saveButtonStripTop.Image")));
            this.saveButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButtonStripTop.Name = "saveButtonStripTop";
            this.saveButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.saveButtonStripTop.Text = "toolStripButton1";
            this.saveButtonStripTop.ToolTipText = "Save (Ctrl+S)";
            this.saveButtonStripTop.Click += new System.EventHandler(this.saveButtonStripTop_Click);
            // 
            // saveAsButtonStripTop
            // 
            this.saveAsButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButtonStripTop.Image")));
            this.saveAsButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButtonStripTop.Name = "saveAsButtonStripTop";
            this.saveAsButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.saveAsButtonStripTop.Text = "toolStripButton1";
            this.saveAsButtonStripTop.ToolTipText = "Save As";
            this.saveAsButtonStripTop.Click += new System.EventHandler(this.saveAsButtonStripTop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // boldButtonStripTop
            // 
            this.boldButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("boldButtonStripTop.Image")));
            this.boldButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButtonStripTop.Name = "boldButtonStripTop";
            this.boldButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.boldButtonStripTop.Text = "toolStripButton1";
            this.boldButtonStripTop.ToolTipText = "Bold";
            this.boldButtonStripTop.Click += new System.EventHandler(this.boldButtonStripTop_Click);
            // 
            // italicsButtonStripTop
            // 
            this.italicsButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicsButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("italicsButtonStripTop.Image")));
            this.italicsButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicsButtonStripTop.Name = "italicsButtonStripTop";
            this.italicsButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.italicsButtonStripTop.Text = "toolStripButton1";
            this.italicsButtonStripTop.ToolTipText = "Italics";
            this.italicsButtonStripTop.Click += new System.EventHandler(this.italicsButtonStripTop_Click);
            // 
            // underLineButtonStripTop
            // 
            this.underLineButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underLineButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("underLineButtonStripTop.Image")));
            this.underLineButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underLineButtonStripTop.Name = "underLineButtonStripTop";
            this.underLineButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.underLineButtonStripTop.Text = "toolStripButton2";
            this.underLineButtonStripTop.ToolTipText = "Underline";
            this.underLineButtonStripTop.Click += new System.EventHandler(this.underLineButtonStripTop_Click);
            // 
            // fontSizeStripTop
            // 
            this.fontSizeStripTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeStripTop.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.fontSizeStripTop.Name = "fontSizeStripTop";
            this.fontSizeStripTop.Size = new System.Drawing.Size(121, 29);
            this.fontSizeStripTop.ToolTipText = "Font Size";
            this.fontSizeStripTop.Click += new System.EventHandler(this.fontSizeStripTop_Click);
            // 
            // aboutButtonStripTop
            // 
            this.aboutButtonStripTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutButtonStripTop.Image = ((System.Drawing.Image)(resources.GetObject("aboutButtonStripTop.Image")));
            this.aboutButtonStripTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButtonStripTop.Name = "aboutButtonStripTop";
            this.aboutButtonStripTop.Size = new System.Drawing.Size(29, 26);
            this.aboutButtonStripTop.Text = "toolStripButton1";
            this.aboutButtonStripTop.ToolTipText = "About";
            this.aboutButtonStripTop.Click += new System.EventHandler(this.helpButtonStripTop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // userNameStripTop
            // 
            this.userNameStripTop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameStripTop.Name = "userNameStripTop";
            this.userNameStripTop.Size = new System.Drawing.Size(89, 26);
            this.userNameStripTop.Text = "User Name: ";
            // 
            // toolStripLeft
            // 
            this.toolStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripLeft.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutButtonStripLeft,
            this.copyButtonStripLeft,
            this.pasteButtonStripLeft});
            this.toolStripLeft.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripLeft.Location = new System.Drawing.Point(0, 57);
            this.toolStripLeft.Name = "toolStripLeft";
            this.toolStripLeft.Size = new System.Drawing.Size(30, 568);
            this.toolStripLeft.TabIndex = 2;
            this.toolStripLeft.Text = "toolStrip2";
            // 
            // cutButtonStripLeft
            // 
            this.cutButtonStripLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButtonStripLeft.Image = ((System.Drawing.Image)(resources.GetObject("cutButtonStripLeft.Image")));
            this.cutButtonStripLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButtonStripLeft.Name = "cutButtonStripLeft";
            this.cutButtonStripLeft.Size = new System.Drawing.Size(27, 26);
            this.cutButtonStripLeft.Text = "toolStripButton1";
            this.cutButtonStripLeft.ToolTipText = "Cut";
            this.cutButtonStripLeft.Click += new System.EventHandler(this.cutButtonStripLeft_Click);
            // 
            // copyButtonStripLeft
            // 
            this.copyButtonStripLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButtonStripLeft.Image = ((System.Drawing.Image)(resources.GetObject("copyButtonStripLeft.Image")));
            this.copyButtonStripLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButtonStripLeft.Name = "copyButtonStripLeft";
            this.copyButtonStripLeft.Size = new System.Drawing.Size(27, 26);
            this.copyButtonStripLeft.Text = "toolStripButton2";
            this.copyButtonStripLeft.ToolTipText = "Copy";
            this.copyButtonStripLeft.Click += new System.EventHandler(this.copyButtonStripLeft_Click);
            // 
            // pasteButtonStripLeft
            // 
            this.pasteButtonStripLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButtonStripLeft.Image = ((System.Drawing.Image)(resources.GetObject("pasteButtonStripLeft.Image")));
            this.pasteButtonStripLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButtonStripLeft.Name = "pasteButtonStripLeft";
            this.pasteButtonStripLeft.Size = new System.Drawing.Size(27, 26);
            this.pasteButtonStripLeft.Text = "toolStripButton3";
            this.pasteButtonStripLeft.ToolTipText = "Paste";
            this.pasteButtonStripLeft.Click += new System.EventHandler(this.pasteButtonStripLeft_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(33, 56);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1229, 557);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = " ";
            // 
            // TextEditorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 625);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStripLeft);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleTextEditor - Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditorScreen_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.toolStripLeft.ResumeLayout(false);
            this.toolStripLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton newButtonStripTop;
        private System.Windows.Forms.ToolStrip toolStripLeft;
        private System.Windows.Forms.ToolStripButton openButtonStripTop;
        private System.Windows.Forms.ToolStripButton saveButtonStripTop;
        private System.Windows.Forms.ToolStripButton saveAsButtonStripTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldButtonStripTop;
        private System.Windows.Forms.ToolStripButton italicsButtonStripTop;
        private System.Windows.Forms.ToolStripButton underLineButtonStripTop;
        private System.Windows.Forms.ToolStripComboBox fontSizeStripTop;
        private System.Windows.Forms.ToolStripButton aboutButtonStripTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel userNameStripTop;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripButton cutButtonStripLeft;
        private System.Windows.Forms.ToolStripButton copyButtonStripLeft;
        private System.Windows.Forms.ToolStripButton pasteButtonStripLeft;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}