using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XmlCompare
{
    public partial class EditorGrid : Form
    {
        public delegate void ChangeXmlValueHandler(string value,int colIndex,int rowIndex);
        public ChangeXmlValueHandler ChangedXml;
        private int ColIndex;
        private int RowIndex;
        public EditorGrid(int colIndex,int rowIndex,string oldValue)
        {
            InitializeComponent();
            this.ColIndex = colIndex;
            this.RowIndex = rowIndex;
            this.EditorRichTextBox.Text = oldValue;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if(ChangedXml != null)
            this.ChangedXml(this.EditorRichTextBox.Text,this.ColIndex,this.RowIndex);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            string ss = "SSSFFFFFFFFFF";
            string tt = "中文";
            EditorRichTextBox.Rtf =@"{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\froman\fprq2\fcharset0   Times   New   Roman;}{\f1\fnil\fprq2\fcharset134   \ 'cb\ 'ce\ 'cc\ 'e5;}{\f2\fnil\fcharset134   \ 'cb\ 'ce\ 'cc\ 'e5;}} 
            {\colortbl   ;\red255\green0\blue0;\red0\green255\blue0;\red0\green0\blue255;} 
\viewkind4\uc1\pard\nowidctlpar\qj\cf1\kerning2\12" + ss + tt +  "} ";
           // this.Close();
        }

    }
}
