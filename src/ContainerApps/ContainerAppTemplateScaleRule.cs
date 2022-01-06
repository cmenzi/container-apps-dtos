namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateScaleRule
    {
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "custom")]
        public ContainerAppTemplateScaleRuleCustom Custom { get; set; }
    }
}
