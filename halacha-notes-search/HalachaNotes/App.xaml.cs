using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
            //var application = new App();
            //application.InitializeComponent();
            MainWindow mainWindow = new MainWindow();
            Note shabbos = NoteManager.GetNote("notesShabbos.xml");
            mainWindow.LoadText(shabbos);
            new Application().Run(mainWindow);
        }
    }
}
