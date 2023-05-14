using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadFinal
{
    public partial class NoteTaker : Form
    {
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog parth = new OpenFileDialog();
            parth.Title = "Open";
            parth.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if(parth.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(parth.FileName,RichTextBoxStreamType.PlainText);
            this.Text = parth.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog parth = new SaveFileDialog();
            parth.Title = "Save";
            parth.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (parth.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(parth.FileName, RichTextBoxStreamType.PlainText);
            this.Text = parth.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = color.Color;
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {

        }
    }
}
