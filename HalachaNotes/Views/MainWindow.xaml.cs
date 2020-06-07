using HalachaNotes.Models;
using HalachaNotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HalachaNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
        }

        public void LoadText(object note)
        {            
            if (note != null)
                txtTextPanel.Text = note.ToString();
            else
                txtTextPanel.Text = "was empty";
        }

        protected override void OnDpiChanged(DpiScale oldDpiScaleInfo, DpiScale newDpiScaleInfo)
        {
            _pixelsPerDip = newDpiScaleInfo.PixelsPerDip;
            UpdateFormattedText(_pixelsPerDip);
        }

        private void Window_Loaded(object sender, EventArgs e)
        {
            //dc = new DelegateCommandViewModel(Instantiate());

        }

        private void FontSizeChangedEventHandler(object sender, SelectionChangedEventArgs e)
        {
            if (!_UILoaded)
                return;
            //if (_currentRendering.FontSize != (double)fontSizeCB.SelectedItem)
            //{
            //    _currentRendering.FontSize = (double)fontSizeCB.SelectedItem;
            //    UpdateFormattedText(_pixelsPerDip);
            //}
        }

        public void FontFamilyChangedEventHandler(object sender, SelectionChangedEventArgs e)
        {
            if (!_UILoaded)
                return;
            //if (_currentRendering.Typeface.FontFamily.Source != (string)fontFamilyCB.SelectedItem)
            {
                Typeface oldFace = _currentRendering.Typeface;
                //Typeface newFace = new Typeface(
                    //new System.Windows.Media.FontFamily((string)fontFamilyCB.SelectedItem),
                    //oldFace.Style, oldFace.Weight, oldFace.Stretch);

                //_currentRendering.Typeface = newFace;
                UpdateFormattedText(_pixelsPerDip);
            }
        }

        private void UpdateFormattedText(double pixelsPerDip)
        {
            if (!_UILoaded)
                return;
            _textStore = new CustomTextSource(_pixelsPerDip);

            int textStorePosition = 0;
            System.Windows.Point linePosition = new System.Windows.Point(0, 0);
            DrawingGroup textDest = new DrawingGroup();
            DrawingContext dc = textDest.Open();
            //_textStore.Text = textToFormat.Text();
            
        }

        public static double[] CommonFontSizes = new double[]
        {3.0d, 4.0d, 5.0d, 6.0d, 6.5d, 7.0d, 7.5d, 8.0d, 8.5d, 9.0d,
         9.5d, 10.0d, 10.5d, 11.0d, 11.5d, 12.0d, 12.5d, 13.0d, 13.5d, 14.0d,
         15.0d, 16.0d, 17.0d, 18.0d, 19.0d, 20.0d, 22.0d, 24.0d, 26.0d, 28.0d,
         30.0d, 32.0d, 34.0d, 36.0d, 38.0d, 40.0d, 44.0d, 48.0d, 52.0d, 56.0d,
         60.0d, 64.0d, 68.0d, 72.0d, 76.0d, 80.0d, 88.0d, 96.0d, 104.0d, 112.0d,
         120.0d, 128.0d, 136.0d, 144.0d, 152.0d, 160.0d,  176.0d,  192.0d,  208.0d,
         224.0d, 240.0d, 256.0d, 272.0d, 288.0d, 304.0d, 320.0d, 352.0d, 384.0d,
         416.0d, 448.0d, 480.0d, 512.0d, 544.0d, 576.0d, 608.0d, 640.0d};
        private FontRendering _currentRendering;
        private CustomTextSource _textStore;
        private bool _UILoaded = false;
        private double _pixelsPerDip;

    }
}
