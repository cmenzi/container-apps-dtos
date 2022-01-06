namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplate
    {
        [YamlMember(Alias = "revisionSuffix")]
        public string RevisionSuffix { get; set; }

        [YamlMember(Alias = "containers")]
        public ContainerAppTemplateContainer[] Containers { get; set; }

        [YamlMember(Alias = "scale")]
        public ContainerAppTemplateScale Scale { get; set; }
    }
}
