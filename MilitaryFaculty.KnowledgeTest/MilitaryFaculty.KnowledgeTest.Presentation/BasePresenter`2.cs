using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;

namespace MilitaryFaculty.KnowledgeTest.Presentation
{
    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        public TView View { get; set; }
        public IApplicationController Controller { get; set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg arg);
    }
}
