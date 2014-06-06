using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using IContainer = MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer.IContainer;

namespace MilitaryFaculty.KnowledgeTest.Presentation
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer _container;

        public ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterView<TView, TImplementation>()
            where TView : IView
            where TImplementation : class, TView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        public IApplicationController RegisterInstance<TArgument>(TArgument instance) where TArgument : class
        {
            _container.RegisterInstance(instance);
            return this;
        }

        public IApplicationController RegisterService<TService, TImplementation>()
            where TService : IService
            where TImplementation : class, TService
        {
            _container.Register<TService, TImplementation>();
            return this;
        }

        public IApplicationController RegisterService<TService>() where TService : class
        {
            _container.Register<TService>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            //if (!_container.IsRegistered<TPresenter>())
            //{
            //    _container.Register<TPresenter>();
            //}

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument>(TArgument argument) where TPresenter : class, IPresenter<TArgument>
        {
            //if (!_container.IsRegistered<TPresenter>())
            //{
            //    _container.Register<TPresenter>();
            //}

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argument);
        }

        public IApplicationController DoneBuilding()
        {
            _container.Done();
            return this;
        }
    }
}
