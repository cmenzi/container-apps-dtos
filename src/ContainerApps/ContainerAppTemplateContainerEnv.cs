namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateContainerEnv
    {
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "value")]
        public string Value { get; set; }

        [YamlMember(Alias = "secretRef")]
        public string SecretRef { get; set; }
    }
}
