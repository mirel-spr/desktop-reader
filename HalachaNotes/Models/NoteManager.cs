﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using HalachaNotes;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using HalachaNotes.Models;
using System.Windows.Controls;
using System.Windows.Documents;

namespace HalachaNotes
{
    class NoteManager : Page
    {
        public NoteManager(string filename)
        {
            StreamReader reader = new StreamReader("../../Data/notesShabbos.xml");
            _note = Deserialise<Note>(reader.ReadToEnd());
        }
        
        //public string LoopThrough<T>(T item)
        //{
        //    string textString = "";

        //    if (item.GetType().IsGenericType &&
        //            item.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))
        //    {
        //        textString += LoopThrough(item);
        //    }
        //    else
        //    {
        //        FormatTextItem(item);
        //    }
        //                //add returned value to returning object

        //    return textString;
        //}

        public void FormatIntroduction(Introduction item)
        {
            FormatParagraph(item.Paragraph);
            //done
        }

        public void FormatTextBlock(Textblock item)
        {
            FormatHeading(item.Heading);
            FormatParagraph(item.Paragraph);
            //done
        }

        public void FormatHeading(Heading item)
        {
            FormatText(item.Text);
            //item.Level;
            //done
        }

        public void FormatParagraph(NoteParagraph item)
        {
            FormatParagraphText(item.ParagraphText);
        }

        public void FormatParagraphText(List<ParagraphText> item)
        {
            //check what to do about lists
        }

        public void FormatBaseItem(BaseItem item)
        {
            FormatText(item.Text);
            //done
        }

        public void FormatText(string text)
        {
            //format and return line of text
        }

        public void FormatListItem(NoteListItem item)
        {
            //FormatItemText(item.ItemText);
            FormatText(item.Text);
        }

        //public void FormatItemText(ItemText item)
        //{
        //    FormatParagraph(item.Paragraph);
        //}

        public void FormatNote()
        {
            string formattedText = "";
            if (_note.Introduction != null && _note.Introduction.Paragraph != null)
                _introduction = _note.Introduction.Paragraph;
            if (_note.Textblock != null)
                _textblocks = _note.Textblock;

            if (_introduction.ParagraphText != null)
            {
                //string formattedIntroduction += LoopThrough(_introduction.ParagraphText);
                foreach (var paragraphItem in _introduction.ParagraphText)
                {
                    if (paragraphItem.GetType() == typeof(string))
                    {
                        //formattedIntroduction += FormatParagraphText(paragraphItem);
                    }
                    else
                    {

                    }
                }
            }
            

            DrawingGroup textDest = new DrawingGroup();
            DrawingContext dc = textDest.Open();

            //_textStore.Text = textToFormat.Text;
            _textStore.FontRendering = _currentRendering;

            TextFormatter formatter = TextFormatter.Create();

            //while (textStorePosition < _textStore.Text.Length)
            //{
            //    using (TextLine myTextLine = formatter.FormatLine(
            //        _textStore,
            //        textStorePosition,
            //        96*6,
            //        new GenericTextParagraphProperties(_currentRendering),
            //        null))
            //    {
            //        myTextLine.Draw(dc, linePosition, InvertAxes.None);

            //        textStorePosition += myTextLine.Length;

            //        linePosition.Y += myTextLine.Height;
            //    }
            //}

            dc.Close();

            //myDrawingBrush.Drawing = textDest;
            
            

            //return formattedNote;
        }

        public static T Deserialise<T>(string xmlString)
        {
            if (xmlString == null) return default;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xmlString);
            return (T)serializer.Deserialize(reader);
        }

        public static void Serialise()
        {

        }

        public static string GetFilepath(string filename)
        {
            var currentDir = Directory.GetCurrentDirectory();
            return Path.Combine(currentDir, filename);
        }

        #region Properties
        public Note Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public CustomTextSource TextStore
        {
            get { return _textStore; }
            set { _textStore = value; }
        }

        public FontRendering CurrentRendering
        {
            get { return _currentRendering; }
            set { _currentRendering = value; }
        }

        public NoteParagraph Introduction
        {
            get { return _introduction; }
            set { _introduction = value; }
        }

        public List<Textblock> Textblocks
        {
            get { return _textblocks; }
            set { _textblocks = value; }
        }
        #endregion

        #region PrivateFields
        private Note _note;
        private CustomTextSource _textStore;
        private FontRendering _currentRendering;
        private NoteParagraph _introduction;
        private List<Textblock> _textblocks;
        #endregion
    }
}
