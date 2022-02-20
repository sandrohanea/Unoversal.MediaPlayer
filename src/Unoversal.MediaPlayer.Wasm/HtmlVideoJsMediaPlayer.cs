using System;
using Uno.Foundation;
using Uno.UI.Runtime.WebAssembly;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Unoversal.MediaPlayer.Wasm
{
    [HtmlElement("video")]
    public sealed partial class HtmlVideoJsMediaPlayer : Border
    {

        public HtmlVideoJsMediaPlayer()
        {
            Background = new SolidColorBrush(Colors.Transparent);
            this.SetCssClass("video-js");

            //TODO: Find some solution to not set the height here
            // If it's left 0, the video won't be visible as this height will be set on the element style and the class will be ignored.
            Height = 1000;
            SetStretch(Stretch.Uniform);
        }

        public void SetSource(Uri source)
        {
            var encodedSource = WebAssemblyRuntime.EscapeJs(source.ToString());
            
            var js = $"umpSetSource(element, '{encodedSource}', 'application/x-mpegURL')";
            this.ExecuteJavascript(js);
        }

        public void SetControls(bool enabled)
        {
            var js = $"element.controls = {enabled.ToString().ToLower()};";
            this.ExecuteJavascript(js);
        }

        internal void SetStretch(Stretch stretch)
        {
            //TODO: set the correct class and unset the old one.
            this.SetCssClass("ump-strech-uniform");
        }
    }
}
