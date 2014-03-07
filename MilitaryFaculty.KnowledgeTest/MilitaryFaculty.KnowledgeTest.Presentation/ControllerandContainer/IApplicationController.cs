using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;

namespace MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TView : IView
            where TImplementation : class, TView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance) where TArgument : class;

        IApplicationController RegisterService<TService, TImplementation>()
            where TService : IService
            where TImplementation : class, TService;

        IApplicationController RegisterService<TService>()
            where TService : class;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgument>(TArgument argument)
            where TPresenter : class, IPresenter<TArgument>;

        IApplicationController DoneBuilding();
    }
}
