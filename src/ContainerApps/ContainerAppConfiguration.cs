namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppConfiguration
    {
        [YamlMember(Alias = "activeRevisionsMode")]
        public ContainerAppActiveRevisionsMode ActiveRevisionsMode { get; set; } = ContainerAppActiveRevisionsMode.Multiple;

        [YamlMember(Alias = "secrets")]
        public ContainerAppConfigurationSecret[] Secrets { get; set; }

        [YamlMember(Alias = "ingress")]
        public ContainerAppConfigurationIngress Ingress { get; set; }

        [YamlMember(Alias = "registries")]
        public ContainerAppConfigurationRegistry[] Registries { get; set; }
    }
}
