using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unoversal.MediaPlayer
{
    public partial class UnoversalMediaPlayer : Control
	{
		public UnoversalMediaPlayer()
        {
			DefaultStyleKey = typeof(UnoversalMediaPlayer);
        }

		public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(nameof(Source), typeof(object), typeof(UnoversalMediaPlayer), new PropertyMetadata(null));

		public object Source
        {
			 get => GetValue(SourceProperty);
			 set => SetValue(SourceProperty, value);
        }
	}
}
