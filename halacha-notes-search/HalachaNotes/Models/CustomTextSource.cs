using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace HalachaNotes.Models
{
    class CustomTextSource : TextSource
    {
        public CustomTextSource(double pixelsPerDip)
        {
            PixelsPerDip = pixelsPerDip;
        }

        public override TextRun GetTextRun(int textSourceCharacterIndex)
        {
            if (textSourceCharacterIndex < 0)
                throw new ArgumentOutOfRangeException("textSourceCharacterIndex", "Value must be greater than 0.");
            if (textSourceCharacterIndex >= _text.Length)
            {
                return new TextEndOfParagraph(1);
            }

            if (textSourceCharacterIndex < _text.Length)
            {
                return new TextCharacters(
                    _text,
                    textSourceCharacterIndex,
                    _text.Length - textSourceCharacterIndex,
                    new GenericTextRunProperties(_currentRendering, PixelsPerDip));
            }

            return new TextEndOfParagraph(1);
        }

        public override TextSpan<CultureSpecificCharacterBufferRange> GetPrecedingText(int textSourceCharacterIndexLimit)
        {
            CharacterBufferRange cbr = new CharacterBufferRange(_text, 0, textSourceCharacterIndexLimit);
            return new TextSpan<CultureSpecificCharacterBufferRange>(
                textSourceCharacterIndexLimit,
                new CultureSpecificCharacterBufferRange(System.Globalization.CultureInfo.CurrentCulture, cbr)
                );
        }

        public override int GetTextEffectCharacterIndexFromTextSourceCharacterIndex(int textSourceCharacterIndex)
        {
            throw new Exception("The method or operation is not implemented");
        }

        #region Properties
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public FontRendering FontRendering
        {
            get { return _currentRendering; }
            set { _currentRendering = value; }
        }

        #endregion

        #region PrivateFields
        private string _text;
        private FontRendering _currentRendering;
        #endregion
    }
}
