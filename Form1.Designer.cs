namespace Text_editor
{
    partial class Anteckningar_Main_Form
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
            this.Anteckningar_Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ny_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Oppna_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Spara_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Spara_Som_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Avsluta_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label_Antal_Tecken_Med_M = new System.Windows.Forms.Label();
            this.Label_Antal_Tecken_Utan_M = new System.Windows.Forms.Label();
            this.Label_Antal_Ord = new System.Windows.Forms.Label();
            this.Label_Antal_Rader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Anteckningar_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anteckningar_Menu
            // 
            this.Anteckningar_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Anteckningar_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Anteckningar_Menu.Location = new System.Drawing.Point(0, 0);
            this.Anteckningar_Menu.Name = "Anteckningar_Menu";
            this.Anteckningar_Menu.Size = new System.Drawing.Size(815, 28);
            this.Anteckningar_Menu.TabIndex = 0;
            this.Anteckningar_Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ny_Menu,
            this.Oppna_Menu,
            this.Spara_Menu,
            this.Spara_Som_Menu,
            this.Avsluta_Menu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.fileToolStripMenuItem.Text = "Arkiv";
            // 
            // Ny_Menu
            // 
            this.Ny_Menu.Name = "Ny_Menu";
            this.Ny_Menu.Size = new System.Drawing.Size(162, 26);
            this.Ny_Menu.Text = "Ny";
            this.Ny_Menu.Click += new System.EventHandler(this.Ny_Menu_Click);
            // 
            // Oppna_Menu
            // 
            this.Oppna_Menu.Name = "Oppna_Menu";
            this.Oppna_Menu.Size = new System.Drawing.Size(162, 26);
            this.Oppna_Menu.Text = "Öppna";
            this.Oppna_Menu.Click += new System.EventHandler(this.Oppna_Menu_Click);
            // 
            // Spara_Menu
            // 
            this.Spara_Menu.Name = "Spara_Menu";
            this.Spara_Menu.Size = new System.Drawing.Size(162, 26);
            this.Spara_Menu.Text = "Spara";
            this.Spara_Menu.Click += new System.EventHandler(this.Spara_Menu_Click);
            // 
            // Spara_Som_Menu
            // 
            this.Spara_Som_Menu.Name = "Spara_Som_Menu";
            this.Spara_Som_Menu.Size = new System.Drawing.Size(162, 26);
            this.Spara_Som_Menu.Text = "Spara som";
            this.Spara_Som_Menu.Click += new System.EventHandler(this.Spara_Som_Menu_Click);
            // 
            // Avsluta_Menu
            // 
            this.Avsluta_Menu.Name = "Avsluta_Menu";
            this.Avsluta_Menu.Size = new System.Drawing.Size(162, 26);
            this.Avsluta_Menu.Text = "Avsluta";
            this.Avsluta_Menu.Click += new System.EventHandler(this.Avsluta_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.TextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 223);
            this.panel1.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.AllowDrop = true;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(815, 223);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            // 
            // Label_Antal_Tecken_Med_M
            // 
            this.Label_Antal_Tecken_Med_M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Antal_Tecken_Med_M.AutoSize = true;
            this.Label_Antal_Tecken_Med_M.Location = new System.Drawing.Point(13, 274);
            this.Label_Antal_Tecken_Med_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Antal_Tecken_Med_M.Name = "Label_Antal_Tecken_Med_M";
            this.Label_Antal_Tecken_Med_M.Size = new System.Drawing.Size(192, 17);
            this.Label_Antal_Tecken_Med_M.TabIndex = 2;
            this.Label_Antal_Tecken_Med_M.Text = "Antal tecken med mellanslag:";
            // 
            // Label_Antal_Tecken_Utan_M
            // 
            this.Label_Antal_Tecken_Utan_M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Antal_Tecken_Utan_M.AutoSize = true;
            this.Label_Antal_Tecken_Utan_M.Location = new System.Drawing.Point(13, 298);
            this.Label_Antal_Tecken_Utan_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Antal_Tecken_Utan_M.Name = "Label_Antal_Tecken_Utan_M";
            this.Label_Antal_Tecken_Utan_M.Size = new System.Drawing.Size(193, 17);
            this.Label_Antal_Tecken_Utan_M.TabIndex = 3;
            this.Label_Antal_Tecken_Utan_M.Text = "Antal tecken utan mellanslag:";
            // 
            // Label_Antal_Ord
            // 
            this.Label_Antal_Ord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Antal_Ord.AutoSize = true;
            this.Label_Antal_Ord.Location = new System.Drawing.Point(13, 322);
            this.Label_Antal_Ord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Antal_Ord.Name = "Label_Antal_Ord";
            this.Label_Antal_Ord.Size = new System.Drawing.Size(69, 17);
            this.Label_Antal_Ord.TabIndex = 4;
            this.Label_Antal_Ord.Text = "Antal ord:";
            // 
            // Label_Antal_Rader
            // 
            this.Label_Antal_Rader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Antal_Rader.AutoSize = true;
            this.Label_Antal_Rader.Location = new System.Drawing.Point(13, 347);
            this.Label_Antal_Rader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Antal_Rader.Name = "Label_Antal_Rader";
            this.Label_Antal_Rader.Size = new System.Drawing.Size(82, 17);
            this.Label_Antal_Rader.TabIndex = 5;
            this.Label_Antal_Rader.Text = "Antal rader:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 110);
            this.panel2.TabIndex = 6;
            // 
            // Anteckningar_Main_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 374);
            this.Controls.Add(this.Label_Antal_Rader);
            this.Controls.Add(this.Label_Antal_Ord);
            this.Controls.Add(this.Label_Antal_Tecken_Utan_M);
            this.Controls.Add(this.Label_Antal_Tecken_Med_M);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Anteckningar_Menu);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(461, 297);
            this.Name = "Anteckningar_Main_Form";
            this.Text = "Dok1.txt-Anteckningar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anteckningar_Main_Form_FormClosing);
            this.Anteckningar_Menu.ResumeLayout(false);
            this.Anteckningar_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Anteckningar_Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ny_Menu;
        private System.Windows.Forms.ToolStripMenuItem Spara_Menu;
        private System.Windows.Forms.ToolStripMenuItem Spara_Som_Menu;
        private System.Windows.Forms.ToolStripMenuItem Avsluta_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStripMenuItem Oppna_Menu;
        private System.Windows.Forms.Label Label_Antal_Tecken_Med_M;
        private System.Windows.Forms.Label Label_Antal_Tecken_Utan_M;
        private System.Windows.Forms.Label Label_Antal_Ord;
        private System.Windows.Forms.Label Label_Antal_Rader;
        private System.Windows.Forms.Panel panel2;
    }
}

