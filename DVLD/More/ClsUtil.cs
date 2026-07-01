using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.More
{
    static public class ClsUtil
    {

        public static Guna2HtmlToolTip ttMessage = new Guna2HtmlToolTip();

        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static void txtPassword_KeyPress(UserControl Uc,object sender, KeyPressEventArgs e)
        {
            if (!ClsValidation.IsLetterOrControlOrNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (((Guna2TextBox)sender).Text.Length == 15 && !ClsValidation.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                Uc.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        public static void txtPassword_KeyPress(Form frm, object sender, KeyPressEventArgs e)
        {
            if (!ClsValidation.IsLetterOrControlOrNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (((Guna2TextBox)sender).Text.Length == 15 && !ClsValidation.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                frm.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        public static void CheckTheButton(Guna2GradientButton b)
        {
            b.FillColor = ClsSettings.GrayMainColor;
            b.FillColor2 = ClsSettings.BlueMainColor;
        }

        public static void txtNewUserName_KeyPress(ContainerControl This ,object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = (Guna2TextBox)sender;
            if (!ClsValidation.IsLetterOrControlOrNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (ClsValidation.IsNumber(e.KeyChar) && txt.Text.Length == 0)
            {
                e.Handled = true;
            }
            if (txt.Text.Length == 50 && !ClsValidation.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                This.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            
            //string DestinationFolder = @"C:\DVLD-People-Images\";
            string DestinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PeoplePhotos\\");
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }

        static public void btnSwitchFillColor(object sender, EventArgs e)
        {
            Guna2GradientButton b = (Guna2GradientButton)sender;
            Color t = b.FillColor;
            b.FillColor = b.FillColor2;
            b.FillColor2 = t;
        }

        public static void ttMessageForTxtPassword(object sender, CancelEventArgs e)
        {
            Guna2TextBox t = (Guna2TextBox)sender;
            string s = t.Text.Trim();
            if (string.IsNullOrEmpty(t.Text.Trim()))
            {
                e.Cancel = true;
                ttMessage.Show("it is Can't be empty .", t, 0, t.Height, 10000);
            }
            else if (t.Text.Length < 8 || !s.Any(char.IsUpper) || !s.Any(char.IsLower) || !s.Any(char.IsNumber))
            {
                e.Cancel = true;
                ttMessage.Show("Password Must be more than 7 Chars and Contains a Capital Letter ,a Small Letter and A number .", t, 0, t.Height, 10000);
            }
        }

        public static void ttMessageCantBeEmpty(object sender, CancelEventArgs e)
        {
            Guna2TextBox t = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(t.Text.Trim()))
            {
                e.Cancel = true;
                ttMessage.Show("it is Can't be empty .", t, 0, t.Height, 10000);
            }
        }

    }
}
