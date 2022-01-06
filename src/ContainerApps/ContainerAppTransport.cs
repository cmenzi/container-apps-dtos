namespace ContainerApps
{
    using System.Runtime.Serialization;
    using YamlDotNet.Serialization;

    public enum ContainerAppTransport
    {
        [YamlMember(Alias = "auto")]
        Auto,
        [YamlMember(Alias = "http")]
        http,
        [YamlMember(Alias = "http2")]
        http2,
    }
}
