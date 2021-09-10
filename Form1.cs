using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Windows.Input;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;

namespace Text_editor
{
    public partial class Anteckningar_Main_Form : Form
    {
        public string Current_file_name;
        public string Dragged_file_name;
        public bool Current_file_saved;
        public bool Text_changed;
        public bool action_cancelled;
        public bool file_just_loaded;
        
        
        public Anteckningar_Main_Form()
        {
            Current_file_name = "Dok1.txt";
            InitializeComponent();
            Text_changed = false;
            Current_file_saved = false;
            action_cancelled = false;
            file_just_loaded = false;
            
           
        }

        public void Oppna_Spara_eller_avsluta(int action)
        {
            action_cancelled = false;

            if (Text_changed)
            {
                Text_changed = false;

                DialogResult result;
                Modal_Dialog My_dlg = new Modal_Dialog();

                result = My_dlg.ShowDialog();

                My_dlg.Dispose();

                if (result == DialogResult.Yes)
                {
                    if (Current_file_saved)
                    {
                        Spara_Menu.PerformClick();
                    }
                    else
                    {
                        Spara_Som_Menu.PerformClick();
                    }
                }
                else if (result == DialogResult.No)
                {
                    if (action == 0)
                    {
                        this.Dispose();
                        //this.Close();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // Gör ingenting
                    Text_changed = true;
                    action_cancelled = true;
                }
            }

            if (!action_cancelled)
            {
                if (action == 0) // avsluta
                {
                    this.Dispose();
                    //this.Close();
                }

                if (action == 1) // ny
                {
                    file_just_loaded = true; 
                    Current_file_saved=false;
                    Text_changed = false;
                    Current_file_name = "Dok1.txt";
                    TextBox1.Clear();
                }

                if (action == 2) // öppna
                {
                    OpenFileDialog dlg = new OpenFileDialog();

                    dlg.Filter = ".txt file (*.txt)|*.txt";
                    dlg.CheckPathExists = true;
                    dlg.CheckFileExists = true;
                    dlg.InitialDirectory = "";// Environment.GetFolderPath( Environment.SpecialFolder.Desktop);
                    dlg.RestoreDirectory = true;

                    if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.FileName))
                    {
                        //Get the path of specified file
                        var Open_File_Path = dlg.FileName;

                        if (File.Exists(Open_File_Path))
                        {
                            var Text_Open = File.ReadAllText(@Open_File_Path);
                            file_just_loaded = true;
                            Current_file_name = Open_File_Path;
                            Current_file_saved = true;
                            TextBox1.Text = Text_Open;
                            Do_text_changed_updates();
                        }
                    }
                    else
                    {
                        action_cancelled = true;
                    }
                }
                if (action == 3)
                {
                    if (File.Exists(Dragged_file_name))
                    {
                        var Text_Open = File.ReadAllText(@Dragged_file_name);
                        file_just_loaded = true;
                        Current_file_name = Dragged_file_name;
                        Current_file_saved = true;
                        TextBox1.Text = Text_Open;
                        Do_text_changed_updates();
                    }
                }

            }
        }

        public void Do_text_changed_updates()
        {
            string star = "";

            if (Text_changed == true) 
            {
                star = "*";
             }

            this.Text = System.IO.Path.GetFileName(Current_file_name) + star + "-Anteckningar";
            //
            var Text_str = TextBox1.Text;

            Text_str = Text_str.Replace("\r\n", string.Empty);

            Label_Antal_Tecken_Med_M.Text = "Antal tecken med mellanslag: " + Text_str.Length.ToString();

            int i = 0, w_count = 0;

            Text_str = TextBox1.Text.Trim();
            Text_str = Text_str.Replace("\t", " ");
            Text_str = Text_str.Replace("\n", " ");
            Text_str = Text_str.Replace("\r", " ");

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            Text_str = regex.Replace(Text_str, " ");

            var count = Text_str.Count(c => c != ' ');

            Label_Antal_Tecken_Utan_M.Text = "Antal tecken utan mellanslag: " + count.ToString();

            int n = Text_str.Length;

            if (Text_str.Length > 0)
            {
                w_count = 1;
            }

            while (i <= n - 1)
            {
                if (Text_str[i] == ' ' || Text_str[i] == '\n' || Text_str[i] == '\t')
                {
                    w_count++;
                }
                i++;
            }

            Label_Antal_Ord.Text = "Antal ord: " + w_count.ToString();

            int n_lines = TextBox1.Lines.Count(); // med word wrap for debug

            int n_lines_2 = 1 + (from ch in TextBox1.Text where ch == '\n' select ch).Count(); // utan word wrap

            Label_Antal_Rader.Text = "Antal rader: " + n_lines_2.ToString();

        }

        public void Spara_Som_Menu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dlg = new SaveFileDialog();

            save_dlg.Filter = ".txt file (*.txt)|*.txt";
            save_dlg.CheckPathExists = true;

            save_dlg.InitialDirectory = "";// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save_dlg.FilterIndex = 1;
            save_dlg.RestoreDirectory = true;

            if (save_dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (save_dlg.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(save_dlg.OpenFile()))
                    {
                        sw.Write(TextBox1.Text);

                        Current_file_name = save_dlg.FileName;
                        this.Text = System.IO.Path.GetFileName(Current_file_name) + "-Anteckningar";
                        Text_changed = false;
                    }
                    Current_file_saved = true; 
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (file_just_loaded)
            {
                Text_changed = false;
                file_just_loaded = false;
            }
            else
            {
                Text_changed = true;
            }
            Do_text_changed_updates();
        }

        public void Spara_Menu_Click(object sender, EventArgs e)
        {
            if (!Current_file_saved)
            {
                Spara_Som_Menu.PerformClick();
            }
            else
            {
                File.WriteAllText(Current_file_name, TextBox1.Text);
                Text_changed = false;
                this.Text = System.IO.Path.GetFileName(Current_file_name) + "-Anteckningar";
            }
        }

        private void Avsluta_Menu_Click(object sender, EventArgs e)
        {
            Oppna_Spara_eller_avsluta(0);
        }

        

        private void Oppna_Menu_Click(object sender, EventArgs e)
        {
            Oppna_Spara_eller_avsluta(2);
            
        }

        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if ((FileList.Length == 1) & (FileList.Rank == 1))
            {
                string filename = Path.GetFullPath(FileList[0]);

                if (File.Exists(filename))
                {
                    if (System.IO.Path.GetExtension(filename).Equals(".txt", StringComparison.InvariantCultureIgnoreCase))
                    {
                        //file has correct extension *.txt
                        var Text_Open = File.ReadAllText(@filename);

                        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                         //   if ((e.KeyState & 4) == 4) // SHIFT - vid markören
                        {
                            var selectionIndex = TextBox1.SelectionStart;
                            TextBox1.Text = TextBox1.Text.Insert(selectionIndex, Text_Open);
                            TextBox1.SelectionStart = selectionIndex + Text_Open.Length;

                            //Current_file_saved = false;
                            Text_changed = true;
                            Do_text_changed_updates();
                        }
                        if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                        {
                            TextBox1.Text += Text_Open;
                            //Current_file_saved = false;
                            Text_changed = true;
                            Do_text_changed_updates();
                        }

                        if (e.KeyState == 0) // Inga tangenter
                        {
                            Dragged_file_name = filename;
                            Oppna_Spara_eller_avsluta(3);
                            Dragged_file_name = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Filen är inte en textfil.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Man kan bara välja en fil.");
            }          
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
        }

        private void Ny_Menu_Click(object sender, EventArgs e)
        {
            if (Current_file_saved == true & Text_changed == false)
            {
                file_just_loaded = true;
                Current_file_name = "Dok1.txt";
                Current_file_saved=false;
                TextBox1.Clear();

                Label_Antal_Tecken_Med_M.Text = "Antal tecken med mellanslag: ";
                Label_Antal_Tecken_Utan_M.Text = "Antal tecken utan mellanslag: ";
                Label_Antal_Ord.Text = "Antal ord";
                Label_Antal_Rader.Text = "Antal rader:";
            }
            else
            {
                Oppna_Spara_eller_avsluta(1);
            }
            
        }

        private void Anteckningar_Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Oppna_Spara_eller_avsluta(0);
            if (action_cancelled){
                e.Cancel = true;
            }
        }
    }
}
