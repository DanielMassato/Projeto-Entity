using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComponentes
{
    public class TextBoxEx: TextBox
    {
        private Color _backColorIn;
        private Color _backColorOut;

        public Color BackColorIn
        {
            get
            {
                return _backColorIn;
            }

            set
            {
                _backColorIn = value;
            }
        }

        public Color BackColorOut
        {
            get
            {
                return _backColorOut;
            }

            set
            {
                _backColorOut = value;
            }
        }

        public TextBoxEx()
        {
            _backColorIn = Color.White;
            _backColorIn = Color.White;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            BackColor = _backColorIn;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            BackColor = _backColorOut;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // salva a posição do cursor de texto
            int pos = this.SelectionStart;

            // Ctrl + U
            if (e.KeyCode == Keys.U && e.Control && !e.Shift)
            {
                Text = Text.ToUpper();
            }
            // Ctrl + Shift + U
            else if (e.KeyCode == Keys.U && e.Control && e.Shift)
            {
                Text = Text.ToLower();
            }
            else if (e.KeyCode == Keys.I && e.Control && !e.Shift)
            {
                string s = Text;
                string result = "";
                for (int i = 0; i < s.Length; i++)
                {
                    // se o caractere desta posição for maiúsculo
                    if (char.IsUpper(s[i])) result += s[i].ToString().ToLower();
                    // se o caractere desta posição for minúsculo
                    else if (char.IsLower(s[i])) result += s[i].ToString().ToUpper();
                    else result += s[i];
                }

                Text = result;
            }

            // restaurar a posição do cursor
            this.SelectionStart = pos;
        }

    }
}
