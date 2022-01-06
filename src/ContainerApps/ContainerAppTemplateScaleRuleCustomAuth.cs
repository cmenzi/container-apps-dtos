namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppTemplateScaleRuleCustomAuth
    {
        [YamlMember(Alias = "secretRef")]
        public string SecretRef { get; set; }

        [YamlMember(Alias = "triggerParameter")]
        public string TriggerParameter { get; set; }
    }
}
