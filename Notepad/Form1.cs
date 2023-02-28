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
using System.Security.Policy;
using System.Reflection;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad
{
    public partial class NotePad : Form
    {
        public string filename;
        public bool isFileChanged;
       
        public int fontSize = 0;
        public System.Drawing.FontStyle fintFont = FontStyle.Regular;
        public System.Drawing.Color fontColor = System.Drawing.Color.Black;

        public FontSettings fontSettings1;
        public NotePad()
        {
            InitializeComponent();
            Init();
        }
        public void Init() // for initialisation  
        {
            filename = ""; // 
            isFileChanged = false;
            UpdateTextWithTitle();
            FontSettings fontSettings = new FontSettings();
         
        }
        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsaveFile();
            isFileChanged = false;
            richTextBox1.Text = "";
            filename = "";
            UpdateTextWithTitle();

        }
        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            SaveUnsaveFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    isFileChanged = false;

                }
                catch
                {
                    MessageBox.Show("I cant open this file");
                }
            }
        }
        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Unable to save file");
            }
            UpdateTextWithTitle();
        }
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);

        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " -Notepad ";
            }
            else
            {
                this.Text = "Without name - Notepad";
            }
        }
        public void SaveUnsaveFile()
        {
            if(isFileChanged)
            {
                DialogResult result = MessageBox.Show("Save changes to a file ?", "Saving a file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }
       
        private void OnFromClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsaveFile();
        }
        private  void OnFontClick(object sender, EventArgs e)
        {
          fontSettings1 = new FontSettings();
            fontSettings1.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSettings1 != null)
            {
                fontSize = fontSettings1.fontSize;
                fintFont = fontSettings1.fintFont;
                 fontColor = fontSettings1.fontColor;
                 
                 richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize , fintFont );
                 richTextBox1.Font = new Font(filename, fontSize , fintFont );
                richTextBox1.ForeColor =  fontColor;
                
                fontSettings1.Close();
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClickOnPrint(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageM;   
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Printing parameters error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void PrintPageM (object sender , PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 0, 0);
        }

        private void Copy(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0 )
            {
                richTextBox1.Copy();
            }
        }
        private void Insert(object sender , EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }
        private void Cut(object sender , EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }
       
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutForm about = new AboutForm();
            about.Show();
        }

       
    }
}
