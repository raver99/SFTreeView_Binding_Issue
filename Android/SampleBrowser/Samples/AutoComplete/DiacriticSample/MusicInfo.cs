#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Android.Graphics;

namespace SampleBrowser
{
	public class MusicInfo
	{
		public string SongTitle { get; set; }
		public string SongAuther { get; set; }
		public string SongSize { get; set; }
		public string SongLength { get; set; }
		public string SongThumbnail { get; set; }
		public Color SongTheme { get; set; }
		public Color CurrentColor { get; set; }
	}

	public class MusicInfoRepository
	{
		#region Constructor
		List<Color> Colors = new List<Color>();
		public MusicInfoRepository()
		{
			Colors.Add(Color.LightGray);
			Colors.Add(Color.SkyBlue);
			Colors.Add(Color.Green);
			Colors.Add(Color.RosyBrown);
			Colors.Add(Color.Lime);
			Colors.Add(Color.Pink);
			Colors.Add(Color.Gold);
			Colors.Add(Color.BlueViolet);
			Colors.Add(Color.LawnGreen);
			Colors.Add(Color.Violet);
			Colors.Add(Color.Tomato);
			Colors.Add(Color.Orange);
			Colors.Add(Color.MediumVioletRed);
			Colors.Add(Color.Plum);
			Colors.Add(Color.Purple);
			Colors.Add(Color.CornflowerBlue);
			Colors.Add(Color.RosyBrown);
			Colors.Add(Color.RoyalBlue);
			Colors.Add(Color.OrangeRed);
			Colors.Add(Color.Orchid);
			Colors.Add(Color.ForestGreen);
			Colors.Add(Color.Gray);
			Colors.Add(Color.Red);
			Colors.Add(Color.Brown);
			Colors.Add(Color.Purple);
			Colors.Add(Color.CornflowerBlue);
			Colors.Add(Color.GreenYellow);
			Colors.Add(Color.RoyalBlue);
			Colors.Add(Color.OrangeRed);
			Colors.Add(Color.Orchid);
			Colors.Add(Color.ForestGreen);
			Colors.Add(Color.Gray);
			Colors.Add(Color.DeepPink);
			Colors.Add(Color.Brown);
		}

		#endregion

		#region Properties

		internal ObservableCollection<MusicInfo> GetMusicInfo()
		{
			var random = new Random();
			var musiqInfo = new ObservableCollection<MusicInfo>();

			for (int i = 0; i < SongsNames.Count(); i++)
			{
				var info = new MusicInfo()
				{
					SongTitle = SongsNames[i],
					SongAuther = SongAuthers[i],
					SongSize = random.Next(50, 600).ToString() + "." + random.Next(1, 10) / 2 + "KB",
					SongLength = "5.55",
					SongTheme = Colors[i],
					SongThumbnail = (i % 2 == 0) ? "I" : "T",
				};
				musiqInfo.Add(info);
			}

			return musiqInfo;
		}

		#endregion

		#region SongInfo

		string[] SongsNames = new string[]
		{
"Wh??t is th?? w????th??r t??d??y?",
"H??w t?? b????k my flight?",
"Wh??r?? is my l??c??ti??n?",
"Is b??nk ??p??n t??d??y?",
"Why sky is blu???",
"G??t m?? s??m??thing",
"List ??f h??lid??ys",
"Dir??ct m?? t?? h??m??",
"H??w t?? g??in w??ight?",
"H??w t?? dr??w ??n ??l??ph??nt?",
"Wh??r?? c??n I buy ?? c??m??r???",
"Guid?? m?? ??ll th?? w??y",
"H??w t?? m??k?? ?? c??k???",
"S??y, H??ll?? W??rld!",
"H??w t?? m??k?? ?? r??b??t?",
"C??nn??ct M??bil?? t?? TV?",
"Wh??t tim?? n??w in Indi???",
"Wh?? is wh?? in th?? w??rld?",
"H??w t?? dr??w ?? r??s???",
"H??w c??n I l????rn T??mil?",
"H??w c??n I l????rn J??p??n??s???",
"H??w t?? r????ch n????r??st ??irp??rt?",

		};

		string[] SongAuthers = new string[]
		{
			"Coldplay",
			"Bill Monroe",
			"Hank Williams & George Jones",
			"Barry White",
			"F. R. David",
			"Baz Luhrmann",
			"Freddy Fender",
			"Righteous Brothers",
			"Shakira",
			"Andy Williams",
			"James Newton Howard ft. Jennifer Lawrence",
			"I. Kamakawiwo'ole",
			"Enigma",
			"Dionne Warwick",
			"R. Kelly",
			"David Zowie",
			"Michael Jackson",
			"Tom Jones",
			"The Beach Boys",
			"The Brothers Four",
			"Michael Jackson",
			"Alison Krauss",
			"Norah Jones",
			"Green Day",
			"Beck",
			"Hank Williams",
		};

		#endregion
	}

}
