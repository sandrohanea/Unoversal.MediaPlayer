using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Unoversal.MediaPlayer.Sample.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new Unoversal.MediaPlayer.Sample.App(), args);
		host.Run();
	}
}
}
