namespace ContainerApps
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using YamlDotNet.Serialization;
    using YamlDotNet.Serialization.NamingConventions;

    public class ContainerAppTemplateRoot
    {
        [YamlMember(Alias = "kind")]
        public string Kind { get; } = "containerapp";

        [YamlMember(Alias = "location")]
        public string Location { get; set; }

        [YamlMember(Alias = "name")]
        public string Name { get; set; }

        [YamlMember(Alias = "resourceGroup")]
        public string ResourceGroup { get; set; }

        [YamlMember(Alias = "type")]
        public string Type { get; } = "Microsoft.Web/containerApps";

        [YamlMember(Alias = "tags")]
        public Dictionary<string, string> Tags { get; } = new Dictionary<string, string>();

        [YamlMember(Alias = "properties")]
        public ContainerAppProperties Properties { get; set; } = new ContainerAppProperties();

        public void Save(string path)
        {
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .WithTypeConverter(new YamlEnumConverter())
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .IgnoreFields()
                .Build();

            using var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, this);

            File.WriteAllText(path, stringWriter.ToString(), Encoding.UTF8);
        }
    }
}
