namespace ContainerApps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using YamlDotNet.Core;
    using YamlDotNet.Core.Events;
    using YamlDotNet.Serialization;

    internal sealed class YamlEnumConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type) => type.IsEnum;

        public object ReadYaml(IParser parser, Type type)
        {
            var parsedEnum = parser.Consume<Scalar>();

            if (Enum.TryParse(type, parsedEnum.Value, true, out var value))
            {
                return value;
            }

            var serializableValues = type.GetMembers()
                .Select(m => new KeyValuePair<string, MemberInfo>(m.GetCustomAttribute<YamlMemberAttribute>()?.Alias, m))
                .Where(pa => !string.IsNullOrEmpty(pa.Key)).ToDictionary(pa => pa.Key, pa => pa.Value);

            if (!serializableValues.ContainsKey(parsedEnum.Value))
            {
                throw new YamlException(parsedEnum.Start, parsedEnum.End, $"Value '{parsedEnum.Value}' not found in enum '{type.Name}'");
            }

            return Enum.Parse(type, serializableValues[parsedEnum.Value].Name);
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            var enumMember = type.GetMember(value.ToString()).FirstOrDefault();
            var yamlValue = enumMember?.GetCustomAttributes<YamlMemberAttribute>(true).Select(ema => ema.Alias).FirstOrDefault() ?? value.ToString();
            emitter.Emit(new Scalar(yamlValue));
        }
    }
}
