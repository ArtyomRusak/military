using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using IContainer = MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer.IContainer;

namespace UITest
{
    public class AutofacInjectAdapter : IContainer
    {
        private readonly ContainerBuilder _builder = new ContainerBuilder();
        private Autofac.IContainer _container;

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _builder.RegisterType<TImplementation>().As<TService>();
        }

        public void Register<TService>()
        {
            _builder.RegisterType<TService>();
        }

        public void RegisterInstance<T>(T instance) where T : class
        {
            _builder.RegisterInstance(instance);
        }

        public TService Resolve<TService>()
        {
            return _container.Resolve<TService>();
        }

        public bool IsRegistered<TService>()
        {
            return _container.IsRegistered<TService>();
        }

        public void Done()
        {
            _container = _builder.Build();
        }
    }
}
