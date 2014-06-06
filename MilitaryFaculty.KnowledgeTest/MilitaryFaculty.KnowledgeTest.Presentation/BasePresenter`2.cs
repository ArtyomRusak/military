using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace MilitaryFaculty.KnowledgeTest.Presentation
{
    public abstract class BasePresenter<TView, TArg> : BasePresenter<TView>, IPresenter<TArg> where TView : IView
    {
        protected BasePresenter(IApplicationController controller, TView view)
            : base(controller, view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg arg);
    }
}
