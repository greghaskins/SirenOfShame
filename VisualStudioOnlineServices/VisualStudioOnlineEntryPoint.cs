using System.ComponentModel.Composition;
using SirenOfShame.Lib;
using SirenOfShame.Lib.ServerConfiguration;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;

namespace VisualStudioOnlineServices
{
    [Export(typeof(ICiEntryPoint))]
    public class VisualStudioOnlineEntryPoint : ICiEntryPoint
    {
        public ConfigureServerBase CreateConfigurationWindow(SirenOfShameSettings settings, CiEntryPointSetting ciEntryPointSetting)
        {
            return new ConfigureVisualStudioOnline();
        }

        public string Name => "VisualStudioOnline";
        public string DisplayName => "Visual Studio Online";
        public WatcherBase GetWatcher(SirenOfShameSettings settings)
        {
            throw new System.NotImplementedException();
        }
    }
}