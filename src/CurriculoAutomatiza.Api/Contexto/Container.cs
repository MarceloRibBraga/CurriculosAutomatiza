using System;

namespace CurriculoAutomatiza.Api.Contexto
{
    /// <summary>Container para registro das dependências do sistema</summary>
    public class Container : IDisposable
    {
        private readonly SimpleInjector.Container _container;

        private Container()
        {
            this._container = new SimpleInjector.Container();
        }

        /// <summary>Inicializa o container</summary>
        /// <returns></returns>
        public static Container Inicializar()
        {
            return new Container();
        }

        /// <summary>Libera o cache das instâncias</summary>
        public void Dispose()
        {
            this._container.Dispose();
        }

        /// <summary>Regista uma dependência</summary>
        /// <typeparam name="TServico">Interface</typeparam>
        /// <typeparam name="TImplementacao">Implementação da interface</typeparam>
        public void Registrar<TServico, TImplementacao>() where TServico : class where TImplementacao : class, TServico
        {
            this._container.Register<TServico, TImplementacao>();
        }

        /// <summary>Regista uma dependência concreta</summary>
        /// <typeparam name="TConcreto">Tipo concreto</typeparam>
        public void Registrar<TConcreto>() where TConcreto : class
        {
            this._container.Register<TConcreto>();
        }

        /// <summary>Obtém uma instância do tipo do serviço</summary>
        /// <typeparam name="TServico">Tipo do serviço</typeparam>
        /// <returns></returns>
        public TServico ObterInstancia<TServico>() where TServico : class
        {
            return this._container.GetInstance<TServico>();
        }
    }
}
