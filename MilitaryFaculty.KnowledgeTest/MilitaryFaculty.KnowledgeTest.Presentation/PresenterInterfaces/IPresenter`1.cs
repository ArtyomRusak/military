namespace MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces
{
    public interface IPresenter<in TArg>
    {
        void Run(TArg arg);
    }
}
