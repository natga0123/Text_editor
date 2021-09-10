using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_editor
{
    public partial class Modal_Dialog : Form
    {
        
        public Modal_Dialog()
        {
            InitializeComponent();
        }

        private void Button_Ja_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            
        }

        private void Button_Nej_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            
        }

        private void Button_Avbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void Modal_Dialog_Load(object sender, EventArgs e)
        {
            
        }

        private void Modal_Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            
        }
        
    }
}
