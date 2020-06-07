using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HalachaNotes
{
    [XmlRoot(ElementName = "noteset")]
    public class Note
    {
        [XmlElement("introduction")]
        public Introduction Introduction { get; set; }
        [XmlElement("textblock")]
        public List<Textblock> Textblock { get; set; }
        [XmlAttribute("subject")]
        public string Subject { get; set; }
    }

    public class Introduction
    {
        [XmlElement("paragraph")]
        public NoteParagraph Paragraph { get; set; }

        public override string ToString()
        {
            return Paragraph.ParagraphText[0].Text.ToString();
        }
    }

    public class Textblock
    {
        [XmlElement("heading")]
        public Heading Heading { get; set; }
        [XmlElement("paragraph")]
        public NoteParagraph Paragraph { get; set; }
    }

    public class NoteParagraph
    {
        [XmlElement("paragraphtext")]
        public List<ParagraphText> ParagraphText { get; set; }
    }

    public class ParagraphText : BaseItem
    {
        [XmlElement("list")]
        public NoteList List { get; set; }
    }


    public class NoteList
    {
        [XmlElement("listItem")]
        public List<NoteListItem> Item { get; set; }
        [XmlElement("simpleitem")]
        public List<BaseItem> SimpleItems { get; set; }
        [XmlAttribute("type")]
        public ListType ListType { get; set; }
        [XmlAttribute("design")]
        public ListDesign ListDesign { get; set; }
    }

    public class BaseItem
    {
        [XmlText]
        public string Text { get; set; }
    }

    public class NoteListItem : BaseItem
    {
        [XmlAttribute("index")]
        public string Index { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("text")]
        public ItemText ItemText { get; set; }
    }

    public class Heading : BaseItem
    {
        [XmlAttribute("level")]
        public int Level { get; set; }
    }

    public class ItemText : BaseItem
    {
        [XmlElement("paragraph")]
        public List<NoteParagraph> Paragraph { get; set; }
    }

    public enum ListType
    {
        BULLET,
        DASH,
        NUMBER,
        LETTER
    }

    public enum ListDesign
    {
        SINGLEBRACKET,
        DOUBLEBRACKET,
        FULLSTOP
    }
}