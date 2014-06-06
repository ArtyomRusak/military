using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace MilitaryFaculty.KnowledgeTest.Presentation
{
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        public TView View { get; set; }
        public IApplicationController Controller { get; set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public void Run()
        {
            View.Show();
        }
    }
}
