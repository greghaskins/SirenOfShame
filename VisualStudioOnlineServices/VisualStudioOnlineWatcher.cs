using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;

namespace VisualStudioOnlineServices
{
    internal class VisualStudioOnlineWatcher : WatcherBase
    {
        public VisualStudioOnlineWatcher(SirenOfShameSettings settings): base(settings)
        {
        }

        protected override IList<BuildStatus> GetBuildStatus()
        {
            var buildDefinitions = GetAllWatchedBuildDefinitions();
            return buildDefinitions.Select(definition => new BuildStatus()).ToList();
        }

        private IEnumerable<BuildDefinitionSetting> GetAllWatchedBuildDefinitions()
        {
            return CiEntryPointSetting.BuildDefinitionSettings.Where(bd => bd.Active && bd.BuildServer == VisualStudioOnlineEntryPoint.SERVICE_NAME);
        }

        public override void StopWatching()
        {
            throw new System.NotImplementedException();
        }

        public override void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}