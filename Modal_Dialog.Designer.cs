namespace Text_editor
{
    partial class Modal_Dialog
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
            this.Modal_Dialog_Label = new System.Windows.Forms.Label();
            this.Button_Ja = new System.Windows.Forms.Button();
            this.Button_Nej = new System.Windows.Forms.Button();
            this.Button_Avbryt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Modal_Dialog_Label
            // 
            this.Modal_Dialog_Label.AutoSize = true;
            this.Modal_Dialog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modal_Dialog_Label.Location = new System.Drawing.Point(92, 63);
            this.Modal_Dialog_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modal_Dialog_Label.Name = "Modal_Dialog_Label";
            this.Modal_Dialog_Label.Size = new System.Drawing.Size(368, 31);
            this.Modal_Dialog_Label.TabIndex = 0;
            this.Modal_Dialog_Label.Text = "Vill du spara ändringar i filen?";
            // 
            // Button_Ja
            // 
            this.Button_Ja.Location = new System.Drawing.Point(40, 135);
            this.Button_Ja.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Ja.Name = "Button_Ja";
            this.Button_Ja.Size = new System.Drawing.Size(100, 28);
            this.Button_Ja.TabIndex = 1;
            this.Button_Ja.Text = "Ja";
            this.Button_Ja.UseVisualStyleBackColor = true;
            this.Button_Ja.Click += new System.EventHandler(this.Button_Ja_Click);
            // 
            // Button_Nej
            // 
            this.Button_Nej.Location = new System.Drawing.Point(227, 135);
            this.Button_Nej.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Nej.Name = "Button_Nej";
            this.Button_Nej.Size = new System.Drawing.Size(100, 28);
            this.Button_Nej.TabIndex = 2;
            this.Button_Nej.Text = "Nej";
            this.Button_Nej.UseVisualStyleBackColor = true;
            this.Button_Nej.Click += new System.EventHandler(this.Button_Nej_Click);
            // 
            // Button_Avbryt
            // 
            this.Button_Avbryt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Avbryt.Location = new System.Drawing.Point(413, 135);
            this.Button_Avbryt.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Avbryt.Name = "Button_Avbryt";
            this.Button_Avbryt.Size = new System.Drawing.Size(100, 28);
            this.Button_Avbryt.TabIndex = 3;
            this.Button_Avbryt.Text = "Avbryt";
            this.Button_Avbryt.UseVisualStyleBackColor = true;
            this.Button_Avbryt.Click += new System.EventHandler(this.Button_Avbryt_Click);
            // 
            // Modal_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 204);
            this.Controls.Add(this.Button_Avbryt);
            this.Controls.Add(this.Button_Nej);
            this.Controls.Add(this.Button_Ja);
            this.Controls.Add(this.Modal_Dialog_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modal_Dialog";
            this.Text = "Varning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Modal_Dialog_Label;
        private System.Windows.Forms.Button Button_Ja;
        private System.Windows.Forms.Button Button_Nej;
        private System.Windows.Forms.Button Button_Avbryt;
    }
}