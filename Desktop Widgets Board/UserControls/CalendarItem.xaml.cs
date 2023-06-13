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
    /// Definiton of dependenciy properties for Calendar Items
    /// </summary>
    public partial class CalendarItem : UserControl
    {
        public CalendarItem()
        {
            InitializeComponent();
        }

        public string ItemTitle
        {
            get { return (string)GetValue(ItemTitleProperty); }
            set { SetValue(ItemTitleProperty, value); }
        }

        public static readonly DependencyProperty ItemTitleProperty = DependencyProperty.Register("ItemTitle", typeof(string), typeof(CalendarItem));

        public string ItemDate
        {
            get { return (string)GetValue(ItemDateProperty); }
            set { SetValue(ItemDateProperty, value); }
        }

        public static readonly DependencyProperty ItemDateProperty = DependencyProperty.Register("ItemDate", typeof(string), typeof(CalendarItem));

        public Brush ItemColor
        {
            get { return (Brush)GetValue(ItemColorProperty); }
            set { SetValue(ItemColorProperty, value); }
        }

        public static readonly DependencyProperty ItemColorProperty = DependencyProperty.Register("ItemColor", typeof(Brush), typeof(CalendarItem));
    }
}
