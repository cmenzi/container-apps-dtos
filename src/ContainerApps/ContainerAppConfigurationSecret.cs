namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppConfigurationSecret
    {
        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "value")]
        public string Value { get; set; }
    }
}
