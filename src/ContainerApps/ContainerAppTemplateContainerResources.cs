namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateContainerResources
    {
        [YamlMember(Alias = "cpu")]
        public double Cpu { get; set; } = 0.5;

        [YamlMember(Alias = "memory")]
        public string Memory { get; set; } = "1.0Gi";
    }
}
