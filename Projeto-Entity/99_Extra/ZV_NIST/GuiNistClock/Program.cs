using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuiNistClock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new ClockForm ());
        }
    }
}


/*
    $Log: Program.cs,v $
    Revision 1.2  2009/02/13 03:20:52  Don.Cross
    I now have a working NIST clock GUI!

*/