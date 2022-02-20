using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Unoversal.MediaPlayer
{
    public partial class UnoversalMediaPlayer : Control
    {
        public UnoversalMediaPlayer()
        {
            DefaultStyleKey = typeof(UnoversalMediaPlayer);
            LoadUnderlyingPlayer();

        }

        public Uri Source
        {
            get => (Uri)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public static DependencyProperty SourceProperty { get; } =
            DependencyProperty.Register(
                nameof(Source),
                typeof(Uri),
                typeof(UnoversalMediaPlayer),
                new PropertyMetadata(null, OnSourceChanged));

        private static void OnSourceChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((UnoversalMediaPlayer)dependencyObject).SourceChanged((Uri)args.NewValue);
        }

        public bool AutoPlay
        {
            get { return (bool)GetValue(AutoPlayProperty); }
            set { SetValue(AutoPlayProperty, value); }
        }

        public static DependencyProperty AutoPlayProperty { get; } =
            DependencyProperty.Register(
                nameof(AutoPlay),
                typeof(bool),
                typeof(UnoversalMediaPlayer),
                new PropertyMetadata(true, OnAutoPlayChanged));

        private static void OnAutoPlayChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((UnoversalMediaPlayer)dependencyObject).AutoPlayChanged((bool)args.NewValue);
        }

        public bool IsFullWindow
        {
            get { return (bool)GetValue(IsFullWindowProperty); }
            set { SetValue(IsFullWindowProperty, value); }
        }
        public bool AreTransportControlsEnabled
        {
            get { return (bool)GetValue(AreTransportControlsEnabledProperty); }
            set { SetValue(AreTransportControlsEnabledProperty, value); }
        }

        public static DependencyProperty AreTransportControlsEnabledProperty { get; } =
            DependencyProperty.Register(
                nameof(AreTransportControlsEnabled),
                typeof(bool),
                typeof(UnoversalMediaPlayer),
                new PropertyMetadata(false, OnAreTransportControlsEnabledChanged));

        private static void OnAreTransportControlsEnabledChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((UnoversalMediaPlayer)dependencyObject).AreTransportControlsEnabledChanged((bool)args.NewValue);
        }

        public static DependencyProperty IsFullWindowProperty { get; } =
            DependencyProperty.Register(
                nameof(IsFullWindow),
                typeof(bool),
                typeof(UnoversalMediaPlayer),
                new PropertyMetadata(false, OnIsFullWindowChanged));

        private static void OnIsFullWindowChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((UnoversalMediaPlayer)dependencyObject).FullWindowChanged((bool)args.NewValue);
        }

        public FrameworkElement Content
        {
            get { return (FrameworkElement)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static DependencyProperty ContentProperty { get; } =
            DependencyProperty.Register(
                nameof(Content),
                typeof(FrameworkElement),
                typeof(UnoversalMediaPlayer),
                new PropertyMetadata(null));

        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static DependencyProperty StretchProperty { get; } =
            DependencyProperty.Register(
                nameof(Stretch),
                typeof(Stretch),
                typeof(MediaPlayerElement),
                new PropertyMetadata(Stretch.Uniform, OnStretchChanged));

        private static void OnStretchChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            ((UnoversalMediaPlayer)dependencyObject).StretchChanged((Stretch)args.NewValue);
        }
    }
}
