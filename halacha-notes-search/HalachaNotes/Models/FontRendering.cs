using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace HalachaNotes.Models
{
    class FontRendering
    {
        #region Constructors
        public FontRendering(
            double emSize,
            TextAlignment alignment,
            TextDecorationCollection decorations,
            Brush textColour,
            Typeface face)
        {
            _fontSize = emSize;
            _alignment = alignment;
            _textDecorations = decorations;
            _textColour = textColour;
            _typeface = face;
        }

        public FontRendering()
        {
            _fontSize = 12.0f;
            _alignment = TextAlignment.Left;
            _textDecorations = new TextDecorationCollection();
            _textColour = Brushes.Black;
            _typeface = new Typeface(new FontFamily("Arial"),
                FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        }
        #endregion

        #region Properties
        public double FontSize
        { 
            get { return _fontSize; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "Parameter Must Be Greater Than Zero.");
                if (double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("value", "Parameter Cannot Be NaN.");
                _fontSize = value;
            }
        }

        public TextAlignment TextAlignment
        {
            get { return _alignment; }
            set { _alignment = value; }
        }

        public TextDecorationCollection TextDecorations
        {
            get { return _textDecorations; }
            set { _textDecorations = value; }
        }

        public Brush TextColour
        {
            get { return _textColour; }
            set { _textColour = value; }
        }

        public Typeface Typeface
        {
            get { return _typeface; }
            set { _typeface = value; }
        }
        #endregion

        #region Private Fields
        private double _fontSize;
        private TextAlignment _alignment;
        private TextDecorationCollection _textDecorations;
        private Brush _textColour;
        private Typeface _typeface;
        #endregion
    }
}
