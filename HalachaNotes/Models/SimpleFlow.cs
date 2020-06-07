using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xml;

namespace HalachaNotes.Models
{
    public partial class SimpleFlow : Page
    {

            //        <paragraph
            //    context = "introduction"

            //    index="a" [list]
            ///>

            //<heading
            //    level = "1"

            //    index="8"
            //	index="a"
            ///>

            //<list
            //    type = "LETTER"

            //    type="NUMBER"
            //	design="FULLSTOP"
            //	design="DOUBLEBRACKET"
            ///>

        public SimpleFlow(XmlDocument note)
        {
            FlowDocument flowDocument = new FlowDocument();
            List list = new List();
            Paragraph paragraph;

            foreach (XmlNode node in note.ChildNodes)
            {
                XmlAttributeCollection attribs = node.Attributes;

                if (attribs != null)
                {
                    string attribName = ""; //= attribs.Name;
                    switch (attribName)
                    {
                        case "paragraph":
                            paragraph = formatParagraph();
                            flowDocument.Blocks.Add(paragraph);
                            break;
                        case "heading":
                            formatHeading();
                            break;
                        case "list":
                            formatList();
                            break;
                        default:
                            break;
                    }

                    foreach (XmlAttribute attrib in attribs)
                    {
                        if (attrib.ToString() == "paragraph")
                            formatParagraph()
                        //paragraph = new Paragraph(new Run(attrib.ToString()));
                        //list.ListItems.Add(new ListItem(paragraph));
                    }
                }
                else
                {
                    paragraph = new Paragraph(new Run("this is a new run"));
                    list.ListItems.Add(new ListItem(paragraph));
                }
            }

            //Paragraph paragraph = new Paragraph();
            //paragraph.Inlines.Add(new Bold(new Run("Some bold text")));                      

            
            //flowDocument.Blocks.Add(paragraph);
            flowDocument.Blocks.Add(list);

            FlowDocumentReader flowDocumentReader = new FlowDocumentReader();
            flowDocumentReader.Document = flowDocument;

            this.Content = flowDocumentReader;
        }

        public Paragraph formatParagraph()
        {
            Paragraph paragraph = new Paragraph();

            return paragraph;
        }

        public void formatHeading()
        {

        }

        public void formatList()
        {

        }
    }
}
