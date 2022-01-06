namespace ContainerApps
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Example
    {
        public static void Main()
        {
            var templateRoot = new ContainerAppTemplateRoot
            {
                ResourceGroup = "my-resource-group",
                Properties = new ContainerAppProperties
                {
                    // ...
                }
                // ...
            };

            templateRoot.Save("./deployment.yml");

            // call az containerapps create --yaml <file> ...
        }
    }
}
