using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ControlClone
{
    public class TextBoxClone: TextBox
    {
        // declara dunção API do Windows para enviar mensagens
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private TextBoxClone _clone;

        public TextBoxClone Clone
        {
            get { return _clone; }
            set { _clone = value; }
        }

        protected override void WndProc(ref Message m)
        {
            if (_clone != null && this.Focused)
            {               
                SendMessage(_clone.Handle, (uint)m.Msg, (IntPtr)m.WParam, (IntPtr)m.LParam);
            }
            base.WndProc(ref m);
        }
    }
}
