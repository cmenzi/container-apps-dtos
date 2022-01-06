namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateScale
    {
        [YamlMember(Alias = "minReplicas")]
        public long MinReplicas { get; set; } = 1;

        [YamlMember(Alias = "maxReplicas")]
        public long MaxReplicas { get; set; } = 1;

        [YamlMember(Alias = "rules")]
        public ContainerAppTemplateScaleRule[] Rules { get; set; }
    }
}
