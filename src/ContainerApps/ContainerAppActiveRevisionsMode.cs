namespace ContainerApps
{
    using System.Runtime.Serialization;
    using YamlDotNet.Serialization;

    public enum ContainerAppActiveRevisionsMode
    {
        [YamlMember(Alias = "multiple")]
        Multiple,
        [YamlMember(Alias = "single")]
        Single,
    }
}
