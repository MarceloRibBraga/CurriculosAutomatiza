using CurriculoAutomatiza.Domain.Interfaces.Services;
using CurriculoAutomatiza.Domain.Services;


namespace CurriculoAutomatiza.Api.Contexto
{
    public static class IoC
    {
        public static Container ObterContainer()
        {
            var container = Container.Inicializar();

            container.Registrar<IProfissionalService,ProfissionalService>();

            return container;
        }
    }
}
