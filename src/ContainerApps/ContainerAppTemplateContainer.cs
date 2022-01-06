namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateContainer
    {
        [YamlMember(Alias = "image")]
        public string Image { get; set; }

        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "command")]
        public string[] Command { get; set; }

        [YamlMember(Alias = "args")]
        public string[] Args { get; set; }

        [YamlMember(Alias = "env")]
        public ContainerAppTemplateContainerEnv[] Env { get; set; }

        [YamlMember(Alias = "resources")]
        public ContainerAppTemplateContainerResources Resources { get; set; }
    }
}
