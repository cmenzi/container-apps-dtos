namespace ContainerApps
{
    using System.Collections.Generic;
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateScaleRuleCustom
    {
        [YamlMember(Alias = "type")]
        public string Type { get; set; }

        [YamlMember(Alias = "metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [YamlMember(Alias = "auth")]
        public ContainerAppTemplateScaleRuleCustomAuth[] Auth { get; set; }
    }
}
