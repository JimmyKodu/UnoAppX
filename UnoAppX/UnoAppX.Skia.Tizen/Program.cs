using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoAppX.Skia.Tizen
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoAppX.App());
            host.Run();
        }
    }
}
