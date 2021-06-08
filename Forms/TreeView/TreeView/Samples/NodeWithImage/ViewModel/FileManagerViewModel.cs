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
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfTreeView
{
    [Preserve(AllMembers = true)]
    public class FileManagerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> checkedItems;
        private ObservableCollection<Folder> folders;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<object> CheckedItems
        {
            get { return checkedItems; }
            set { this.checkedItems = value; }
        }

        public ObservableCollection<Folder> Folders
        {
            get => folders; set
            {
                folders = value;
                OnPropertyChanged(nameof(Folders));
            }
        }

        private bool isCheckboxVisible = false;
        public bool IsCheckboxVisible
        {
            get { return isCheckboxVisible; }
            set
            {
                isCheckboxVisible = value;
                OnPropertyChanged("IsCheckboxVisible");
            }
        }

        public ObservableCollection<File> Files { get; set; }

        public ObservableCollection<SubFile> SubFiles { get; set; }

        public ICommand RefreshCommand { get; set; }


        public FileManagerViewModel()
        {
            this.Folders = GetFiles();

            RefreshCommand = new Command(() =>
            {
                IsCheckboxVisible = true;
            });
        }

        private ObservableCollection<Folder> GetFiles()
        {
            var nodeImageInfo = new ObservableCollection<Folder>();
            Assembly assembly = typeof(NodeWithImage).GetTypeInfo().Assembly;

            var doc = new Folder() { FileName = "Documents", ImageIcon = "Doc.png" };
            var download = new Folder() { FileName = "Downloads", ImageIcon = "Doc.png" };
            var mp3 = new Folder() { FileName = "Music", ImageIcon = "Doc.png" };
            var pictures = new Folder() { FileName = "Pictures", ImageIcon = "Doc.png" };
            var video = new Folder() { FileName = "Videos", ImageIcon = "Doc.png" };

            var pollution = new File() { FileName = "Environmental Pollution.docx", ImageIcon = "Word.png" };
            var globalWarming = new File() { FileName = "Global Warming.ppt", ImageIcon = "PP.png" };
            var sanitation = new File() { FileName = "Sanitation.docx", ImageIcon = "Word.png" };
            var socialNetwork = new File() { FileName = "Social Network.pdf", ImageIcon = "PDF_Icon.png" };
            var youthEmpower = new File() { FileName = "Youth Empowerment.pdf", ImageIcon = "PDF_Icon.png" };

            var games = new File() { FileName = "Game.exe", ImageIcon = "EXE.png" };
            var tutorials = new File() { FileName = "Tutorials.zip", ImageIcon = "Zip.png" };
            var typeScript = new File() { FileName = "TypeScript.7z", ImageIcon = "Zip.png" };
            var uiGuide = new File() { FileName = "UI-Guide.pdf", ImageIcon = "PDF_Icon.png" };

            var song = new File() { FileName = "Gouttes", ImageIcon = "Audio.png" };

            var camera = new File() { FileName = "Camera Roll", ImageIcon = "Doc.png" };
            var stone = new File() { FileName = "Stone.jpg", ImageIcon = "Png.png" };
            var wind = new File() { FileName = "Wind.jpg", ImageIcon = "Png.png" };

            var img0 = new SubFile() { FileName = "WIN_20160726_094117.JPG", ImageIcon = "People_Circle6.png" };
            var img1 = new SubFile() { FileName = "WIN_20160726_094118.JPG", ImageIcon = "People_Circle5.png" };

            var video1 = new File() { FileName = "Naturals.mp4", ImageIcon = "Video.png" };
            var video2 = new File() { FileName = "Wild.mpeg", ImageIcon = "Video.png" };

            doc.Files = new ObservableCollection<File>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.Files = new ObservableCollection<File>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.Files = new ObservableCollection<File>
            {
                song
            };

            pictures.Files = new ObservableCollection<File>
            {
                camera,
                stone,
                wind
            };
            camera.SubFiles = new ObservableCollection<SubFile>
            {
                img0,
                img1
            };

            video.Files = new ObservableCollection<File>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);

            checkedItems = new ObservableCollection<object>();
            checkedItems.Add(pollution);
            checkedItems.Add(sanitation);
            checkedItems.Add(youthEmpower);
            checkedItems.Add(camera);
            checkedItems.Add(video1);
            checkedItems.Add(video1);
            checkedItems.Add(typeScript);
            checkedItems.Add(typeScript);

            return nodeImageInfo;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = @"")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}