using SirenOfShame.Lib.Settings;

namespace VisualStudioOnlineServices
{
    internal class VisualStudioOnlineBuildDefinition : MyBuildDefinition
    {
        public VisualStudioOnlineBuildDefinition(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string Id { get; }

        public override string Name { get; }
    }
}