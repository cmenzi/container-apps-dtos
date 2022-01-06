namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppProperties
    {
        [YamlMember(Alias = "kubeEnvironmentId")]
        public string KubeEnvironmentId { get; set; }

        [YamlMember(Alias = "configuration")]
        public ContainerAppConfiguration Configuration { get; set; } = new ContainerAppConfiguration();

        [YamlMember(Alias = "template")]
        public ContainerAppTemplate Template { get; set; } = new ContainerAppTemplate();
    }
}
