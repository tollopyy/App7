using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        
     public MainPage()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
            new Label
            {
                Text = "Заголовок",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            },
            new Rectangle(70, 50, 150, 60)
            );
            absoluteLayout.Children.Add(
            new Label
            {
                Text = "Основное содержание текста",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            },
            new Point(30, 110)
            );

            Content = absoluteLayout;
        }
    }
}

