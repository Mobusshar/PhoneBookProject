using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Phonebook.Classes
{
    class Variables
    {
        static public string DBFile = Application.StartupPath + "\\database";
        static public XDocument xDocument;
        static public string CurrentUserID = "";
        static public string CurrentUserName = "";
        static public string Caption = "Phonebook --> " ;
    }
}
