using System;
using System.Collections.Generic;
using System.IO;
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
using System.Collections.ObjectModel;

namespace TakenokoMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<MediaFile> _FileList = new ObservableCollection<MediaFile>();
        private MediaFile _CurrentMediaFile = null;

        public MainWindow()
        {
            InitializeComponent();

            this.Player.LoadedBehavior = MediaState.Manual;

            this.FileListBox.MouseDoubleClick += FileListBox_MouseDoubleClick;
            this.ReloadButton.Click += ReloadButton_Click;
            this.PlayButton.Click += PlayButton_Click;
            this.PauseButton.Click += PauseButton_Click;
            this.Player.MediaEnded += Player_MediaEnded;

            this.LoadFileList();

            this.FileListBox.ItemsSource = _FileList;
        }

        private void FileListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var mediaFile = this.FileListBox.SelectedItem as MediaFile;
            this.Play(mediaFile);
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            this.LoadFileList();
        }
        private void LoadFileList()
        {
            _FileList.Clear();
            foreach (var filePath in Directory.EnumerateFiles(this.FolderPathTextbox.Text))
            {
                _FileList.Add(new MediaFile(filePath));
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            var mediaFile = this.FileListBox.SelectedItem as MediaFile;
            this.Play(mediaFile);
        }
        private void Play(MediaFile mediaFile)
        {
            var filePath = mediaFile.FilePath;
            if (this.Player.Source == null ||
                this.Player.Source.LocalPath != filePath)
            {
                this.Player.Source = new Uri(filePath);
            }
            this.Player.Play();
            _CurrentMediaFile = mediaFile;
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Player.Pause();
        }
        private void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            this.Player.Stop();

            if (this.IsContinueCheckBox.IsChecked == true)
            {
                var index = _FileList.IndexOf(_CurrentMediaFile);
                if (_FileList.Count == index + 1)
                {
                    index = -1;
                }
                var mediaFile = _FileList[index + 1];
                this.Play(mediaFile);
            }
        }
    }
}
