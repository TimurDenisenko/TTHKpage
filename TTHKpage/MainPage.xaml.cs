using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TTHKpage
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            CreatePage("Noorem tarkvaraarendaja", "https://www.tthk.ee/opetatavad_erialad/noorem-tarkvaraarendaja/", Properties.Resources.tarkvaraarendaja);
            CreatePage("Logistika IT-süsteemide nooremspetsialist", "https://www.tthk.ee/opetatavad_erialad/logistika-it-susteemide-nooremspetsialist/", Properties.Resources.logistik);
            CreatePage("Mehhatroonik", "https://www.tthk.ee/opetatavad_erialad/mehhatroonik/", Properties.Resources.mehhatroonik);
            CreatePage("Tööstusinformaatik", "https://www.tthk.ee/opetatavad_erialad/toostusinformaatik/", Properties.Resources.toostusinformaatik);
            CreatePage("Juuksur", "https://www.tthk.ee/opetatavad_erialad/juuksur/", Properties.Resources.juuksur);
            CreatePage("Robotitehnik", "https://www.tthk.ee/opetatavad_erialad/robotitehnik/", Properties.Resources.robotitehnik);
        }

        private void CreatePage(string name, string url, byte[] image)
        {
            ImageButton btn = new ImageButton
            {
                HeightRequest = 200,
                WidthRequest = 200,
                Source =  ImageSource.FromStream(() => new MemoryStream(image)),
                BackgroundColor = Color.Transparent,
            };
            btn.Clicked += async (sender, e) =>
                await Browser.OpenAsync(url);
            ContentPage page = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = name,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        btn
                    },
                    VerticalOptions = LayoutOptions.CenterAndExpand
                }
            };
            Children.Add(page);
        }
    }
}
