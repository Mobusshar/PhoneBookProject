using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Phonebook.Classes
{
    class Messages
    {
        static public void error(ref StackFrame file_info, string errorMassage, IWin32Window owner)
        {
            try
            {
                if (file_info.GetFileName() == null)
                    MessageBox.Show(owner, "Exception : " + errorMassage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(owner, "File : " + file_info.GetFileName() + "\nLine : " + file_info.GetFileLineNumber().ToString() + "\nException : " + errorMassage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }

        static public void successful(string title, string message)
        {
            try
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
