using HalachaNotes.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace HalachaNotes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            MainWindow mainWindow = new MainWindow();

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;

            try { doc.Load("notesShabbos.xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "<books xmlns=\"http://www.contoso.com/books\"> \n" +
                "  <book genre=\"novel\" ISBN=\"1-861001-57-8\" publicationdate=\"1823-01-28\"> \n" +
                "    <title>Pride And Prejudice</title> \n" +
                "    <price>24.95</price> \n" +
                "  </book> \n" +
                "  <book genre=\"novel\" ISBN=\"1-861002-30-1\" publicationdate=\"1985-01-01\"> \n" +
                "    <title>The Handmaid's Tale</title> \n" +
                "    <price>29.95</price> \n" +
                "  </book> \n" +
                "</books>");
            }

            SimpleFlow simpleFlow = new SimpleFlow(doc);
            //parse simpleflow and display
            mainWindow.LoadText(simpleFlow.Content);
            
            new Application().Run(mainWindow);
        }
    }
}
