using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetProg
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent();}
        string filePath, fileDir, fileName, fileExt, folder;
        int i = 0;
        bool cuted = false;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            i = 0;
            lblFilePath.Text = "";
            SelectFile.FilterIndex = 1;
            SelectFile.RestoreDirectory = true;
            SelectFile.Title = "Sélectionnez un fichier";
            if (SelectFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileDir = System.IO.Path.GetDirectoryName(SelectFile.FileName) + "\\";
                    fileName = System.IO.Path.GetFileNameWithoutExtension(SelectFile.FileName);
                    fileExt = System.IO.Path.GetExtension(SelectFile.FileName);
                    filePath = fileDir + fileName + fileExt;
                    ActualLabel();
                    btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnDuplicate.Enabled = btnDelete.Enabled = tbxRename.Enabled= true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string strRename = tbxRename.Text;
            if (File.Exists(filePath))
            {
                if (File.Exists(fileDir + tbxRename.Text + fileExt))
                    MessageBox.Show("A file already has the same name! \nPlease choose another one !");
                else
                {
                    File.Move(filePath, fileDir + strRename + fileExt);
                    fileName = strRename.ToString();
                    ActualLabel();
                    lblFileRenamed.Text = "The file has been renamed";
                }
            }
            else
                noFile();
        }

        private void ActualLabel()
        {
            filePath = fileDir + fileName + fileExt;
            
            lblFileSelected.Text = "File selected : " + fileName +fileExt;
            lblFilePath.Text = "File path : " + fileDir;
            i = 0;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                btnPast.Visible = true;
                lblIndication.Text = "Cuted file";
                cuted = true;
                btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnSelect.Enabled = btnDuplicate.Enabled = tbxRename.Enabled = false;
            }
            else
                noFile();
        }

        private void btnPast_Click(object sener, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folder = fbd.SelectedPath + "\\";
                if (File.Exists(filePath))
                {
                    if (folder == fileDir)
                    {
                        cuted = false;
                        lblIndication.Text = "Aborted";
                        btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnSelect.Enabled = btnDuplicate.Enabled = tbxRename.Enabled = true;
                        btnPast.Visible = false;
                    }
                    else
                    {
                        if (File.Exists(folder + fileName + fileExt))
                            MessageBox.Show("A file already has the same name! \nPlease choose another folder !");
                        else
                        {
                            File.Move(filePath, folder + fileName + fileExt);
                            lblIndication.Text = "Pasted file";
                            fileDir = folder;
                            btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnSelect.Enabled = btnDuplicate.Enabled = tbxRename.Enabled = true;
                            btnPast.Visible = false;
                            ActualLabel();
                            cuted = false;
                        }
                    }
                }
                else
                    noFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                DialogResult resDel = MessageBox.Show("Are you sure you want to delete this file:\n" + fileName + "\n\nat this path: \n" + fileDir, "Delete file",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resDel == DialogResult.Yes)
                {
                    btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnDuplicate.Enabled = btnDelete.Enabled = tbxRename.Enabled = false;
                    btnPast.Visible = false;
                    File.Delete(filePath);
                    lblIndication.Text = "Deleted file";
                    lblFileSelected.Text = lblFilePath.Text = "";
                    cuted = false;
                }
            }
            else
                noFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnDuplicate.Enabled = btnDelete.Enabled = tbxRename.Enabled = false;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (cuted == true)
            {
                DialogResult dr = MessageBox.Show("A file is currently in the clipboard.\nIf you close the program you will lose this file.\n\nAre you sure you want to close the program ? ", "Lose file", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filePath))
                {
                    folder = fbd.SelectedPath + "\\";

                    if (File.Exists(folder + fileName + fileExt))
                    {
                        i = CheckExist(folder);
                        File.Copy(filePath, folder + fileName + "(" + i + ")" + fileExt);
                    }
                    else
                    {
                        File.Copy(filePath, folder + fileName + fileExt);
                        lblIndication.Text = "Copied file";
                    }
                }
                else
                    noFile();
            }
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                i = CheckExist(fileDir);
                File.Copy(filePath, fileDir + fileName + "(" + i + ")" + fileExt);
                lblIndication.Text = "Duplicated file";
            }
            else
                noFile();
        }

        private void noFile()
        {
            MessageBox.Show("This file doesn't exist, select another file");
            btnCopy.Enabled = btnCut.Enabled = btnRename.Enabled = btnDuplicate.Enabled = btnDelete.Enabled = tbxRename.Enabled = false;
            fileDir = fileExt = fileName = "";
            ActualLabel();
        }
        private int CheckExist(string Directory)
        {
            int res = 0;
            if (File.Exists(Directory + fileName + fileExt))
            {
                do
                {
                    res++;
                } while (File.Exists(Directory + fileName + "(" + res + ")" + fileExt));
            }
            return res;
        }
    }
}
