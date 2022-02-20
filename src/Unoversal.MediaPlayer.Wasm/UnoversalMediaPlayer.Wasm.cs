using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unoversal.MediaPlayer.Wasm;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Unoversal.MediaPlayer
{
#pragma warning disable Uno0001 // Uno type or member is not implemented
    public partial class UnoversalMediaPlayer
    {
        private HtmlVideoJsMediaPlayer innerPlayer;

        private void LoadUnderlyingPlayer()
        {
            innerPlayer = new HtmlVideoJsMediaPlayer();
            Content = innerPlayer;
        }

        private void FullWindowChanged(bool fullWindow)
        {

        }

        private void AutoPlayChanged(bool autoPlay)
        {
        }

        private void AreTransportControlsEnabledChanged(bool controlsEnabled)
        {
            innerPlayer.SetControls(controlsEnabled);
        }

        private void SourceChanged(Uri source)
        {
            innerPlayer.SetSource(source);
        }

        private void StretchChanged(Stretch stretch)
        {
            innerPlayer.SetStretch(stretch);
        }
    }
#pragma warning restore Uno0001 // Uno type or member is not implemented

}