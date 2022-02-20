using System;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Unoversal.MediaPlayer
{
    public partial class UnoversalMediaPlayer
    {
        MediaPlayerElement innerMediaPlayer;

        private void LoadUnderlyingPlayer()
        {
            innerMediaPlayer = new MediaPlayerElement();
            Content = innerMediaPlayer;
        }

        private void FullWindowChanged(bool fullWindow)
        {
            innerMediaPlayer.IsFullWindow = fullWindow;
        }

        private void AutoPlayChanged(bool autoPlay)
        {
            innerMediaPlayer.AutoPlay = autoPlay;
        }

        private void AreTransportControlsEnabledChanged(bool controlsEnabled)
        {
            innerMediaPlayer.AreTransportControlsEnabled = controlsEnabled;
        }

        private void SourceChanged(Uri source)
        {
            innerMediaPlayer.Source = MediaSource.CreateFromUri(source);
        }

        private void StretchChanged(Stretch stretch)
        {
            innerMediaPlayer.Stretch = stretch;
        }
    }
}