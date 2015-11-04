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
        public const string SERVICE_NAME = "VisualStudioOnline";

        public ConfigureServerBase CreateConfigurationWindow(SirenOfShameSettings settings, CiEntryPointSetting ciEntryPointSetting)
        {
            // Might need something like this in the view or somewhere...
            var buildDefinition = ciEntryPointSetting.FindAddBuildDefinition(new VisualStudioOnlineBuildDefinition("1", "Build One"), SERVICE_NAME);
            buildDefinition.Active = true;
            settings.Save();
            return new ConfigureVisualStudioOnline();
        }

        public string Name => SERVICE_NAME;
        public string DisplayName => "Visual Studio Online";
        public WatcherBase GetWatcher(SirenOfShameSettings settings)
        {
            return new VisualStudioOnlineWatcher(settings);
        }
    }
}