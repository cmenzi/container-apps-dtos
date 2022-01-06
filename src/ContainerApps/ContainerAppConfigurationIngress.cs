namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppConfigurationIngress
    {
        [YamlMember(Alias = "external")]
        public bool External { get; set; }

        [YamlMember(Alias = "allowInsecure")]
        public bool AllowInsecure { get; set; }

        [YamlMember(Alias = "targetPort")]
        public long TargetPort { get; set; }

        [YamlMember(Alias = "traffic")]
        public ContainerAppConfigurationIngressTraffic[] Traffic { get; set; }

        [YamlMember(Alias = "transport")]
        public ContainerAppTransport Transport { get; set; } = ContainerAppTransport.Auto;
    }
}
