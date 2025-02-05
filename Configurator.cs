using Bindito.Core;

namespace SpeedConfig
{
    [Context("MainMenu")]
    [Context("Game")]
    internal class Configurator : IConfigurator
    {

        public void Configure(IContainerDefinition containerDefinition)
        {
            /*containerDefinition.Bind<Settings>().AsSingleton();*/
        }
    }
}
