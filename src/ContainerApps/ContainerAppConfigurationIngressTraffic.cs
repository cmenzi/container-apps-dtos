namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppConfigurationIngressTraffic
    {
        [YamlMember(Alias = "latestRevision")]
        public bool LatestRevision { get; set; }

        [YamlMember(Alias = "revisionName")]
        public string RevisionName { get; set; }

        [YamlMember(Alias = "weight")]
        public long Weight { get; set; }
    }
}
