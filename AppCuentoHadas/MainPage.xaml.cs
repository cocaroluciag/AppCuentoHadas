using AppCuentoHadas.Models;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace AppCuentoHadas
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<FairyTales> FairyTales { get; set; } = new ObservableCollection<FairyTales>();
		public ObservableCollection<FairyTales> FairyTales2 { get; set; } = new ObservableCollection<FairyTales>();

		public MainPage()
		{
			InitializeComponent();
			ModifySearchBar();
			InitializeTales();
			BindingContext = this;
		}

		private void InitializeTales()
		{
			FairyTales.Add(new FairyTales { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0), Image = "cinderella.jpg" });
			FairyTales.Add(new FairyTales { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.jpeg" });
			FairyTales.Add(new FairyTales { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.jpg" });
			FairyTales.Add(new FairyTales { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 30, 0), Image = "hood.jpeg" });
			FairyTales.Add(new FairyTales { Name = "Beauty and the Beast", ReadTime = new TimeSpan(0, 35, 0), Image = "beauty.jpeg" });

			FairyTales2.Add(new FairyTales { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.jpeg" });
			FairyTales2.Add(new FairyTales { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.jpg" });
			FairyTales2.Add(new FairyTales { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0), Image = "hood.jpeg" });
			FairyTales2.Add(new FairyTales { Name = "Beauty and the Beast", ReadTime = new TimeSpan(0, 35, 0), Image = "beauty.jpeg" });
			FairyTales2.Add(new FairyTales { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0), Image = "cinderella.jpg" });
		}

		private void ModifySearchBar()
		{
			SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
			{
#if ANDROID

                var context = handler.PlatformView.Context;
                var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
                if (searchIconId != 0)
                {
                    var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
                    if (searchIcon != null)
                    {
                        searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.SrcIn);
                    }
                }
#endif
			});
		}
	}
}

