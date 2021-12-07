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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bindings
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            var colors = new List<Color> {
                Colors.AliceBlue,
                Colors.Red,
                Colors.Green,
                Colors.Yellow,
                Colors.Magenta
            };
            var fontSize = new List<int>
            {
                10,11,12,13,15,17,20,25,30,40,50
            };

            var fontStyle = new List<FontStyle>
            {
               FontStyles.Normal,FontStyles.Italic,FontStyles.Oblique
            };
            var fontWeight = new List<FontWeight>
            {
                FontWeights.Normal,
                FontWeights.Bold,
                FontWeights.ExtraBold,
                FontWeights.ExtraBlack,
                FontWeights.ExtraLight
            };
            Select_Color_Background.ItemsSource = colors;
            Select_Color_Foreground.ItemsSource = colors;
            Font_Size.ItemsSource = fontSize;
            Font_Style.ItemsSource = fontStyle;
            Font_Weight.ItemsSource = fontWeight;
        }

        private void Change_Color_Foreground(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;
            Color color = (Color)selectedItem;
            Test_Text.Foreground = new SolidColorBrush(color);
        }

        private void Change_Color_Background(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;
            Color color = (Color)selectedItem;
            Grid_Base.Background = new SolidColorBrush(color);
        }

        private void Font_Size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;
            Test_Text.FontSize = Convert.ToInt32(selectedItem);
        }

        private void Font_Style_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;
            Test_Text.FontStyle = (FontStyle)selectedItem;
            // Test_Text.FontStyle = (FontStyle)((ComboBox)sender).SelectedItem;
        }

        private void Font_Weight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = ((ComboBox)sender).SelectedItem;
            Test_Text.FontWeight = (FontWeight)selectedItem;
        }
    }
}
