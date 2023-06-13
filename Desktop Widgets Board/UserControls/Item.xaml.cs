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

namespace Desktop_Widgets_Board.UserControls
{
    /// <summary>
    /// Definiton of dependenciy properties for to-do widget's items 
    /// </summary>
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Item));

        public string BottomTitle
        {
            get { return (string)GetValue(BottomTitleProperty); }
            set { SetValue(BottomTitleProperty, value); }
        }

        public static readonly DependencyProperty BottomTitleProperty = DependencyProperty.Register("BottomTitle", typeof(string), typeof(Item));

        public string TextStyle
        {
            get { return (string)GetValue(TextStyleProperty); }
            set { SetValue(TextStyleProperty, value); }
        }

        public static readonly DependencyProperty TextStyleProperty = DependencyProperty.Register("TextStyle", typeof(string), typeof(Item));
    }
}
