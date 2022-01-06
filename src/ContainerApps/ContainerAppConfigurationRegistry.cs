namespace ContainerApps
{
    using YamlDotNet.Serialization;

    public class ContainerAppConfigurationRegistry
    {
        [YamlMember(Alias = "server")]
        public string Server { get; set; }

        [YamlMember(Alias = "username")]
        public string Username { get; set; }

        [YamlMember(Alias = "passwordSecretRef")]
        public string PasswordSecretRef { get; set; }
    }
}
