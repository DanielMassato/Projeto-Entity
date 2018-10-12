using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComponentes
{
    public class Turbina: Control
    {
        private bool _turbineActive;
        private Color _turbineColorOn;
        private Color _turbineColorOff;
        private Color _turbinePenColor;
        private byte _turbinePenWidth;

        public bool TurbineActive
        {
            get
            {
                return _turbineActive;
            }

            set
            {
                _turbineActive = value;
                // forçar o redesenho do componente
                Invalidate();
            }
        }

        public Color TurbineColorOn
        {
            get
            {
                return _turbineColorOn;
            }

            set
            {
                _turbineColorOn = value;
                Invalidate();
            }
        }

        public Color TurbineColorOff
        {
            get
            {
                return _turbineColorOff;
            }

            set
            {
                _turbineColorOff = value;
                Invalidate();
            }
        }

        public Color TurbinePenColor
        {
            get
            {
                return _turbinePenColor;
            }

            set
            {
                _turbinePenColor = value;
                Invalidate();
            }
        }

        public byte TurbinePenWidth
        {
            get
            {
                return _turbinePenWidth;
            }

            set
            {
                _turbinePenWidth = value;
                Invalidate();
            }
        }

        public Turbina()
        {
            _turbineActive = false;
            _turbineColorOff = Color.Gray;
            _turbineColorOn = Color.Red;
            _turbinePenColor = Color.Black;
            _turbinePenWidth = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // cor de preenchimento
            Brush br = new SolidBrush(_turbineActive ? _turbineColorOn : _turbineColorOff);
            // linha de borda
            Pen linha = new Pen(_turbinePenColor, _turbinePenWidth);
            // array de pontos que formam o polígono
            Point[] pts =
            {
                 new Point(0, Height/4),
                 new Point(Width, 0),
                 new Point(Width, Height),
                 new Point(0, 3 * Height / 4)
            };
            // desenhar o preenchimento da figura
            e.Graphics.FillPolygon(br, pts);
            // desenhar a linha de borda
            e.Graphics.DrawPolygon(linha, pts);
            // tamanho do texto contido na propriedade Text
            SizeF tam = e.Graphics.MeasureString(Text, Font);
            // desenhar o texto no centro vertical e horizontal
            e.Graphics.DrawString(Text, Font,
                new SolidBrush(ForeColor), // cor da letra
                (Width - tam.Width) / 2, // posição X
                (Height - tam.Height) / 2 // posição Y
                );

        }

    }
}
