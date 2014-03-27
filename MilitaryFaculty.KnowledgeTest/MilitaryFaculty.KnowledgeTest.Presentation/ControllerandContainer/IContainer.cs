namespace MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer
{
    public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService>();
        void RegisterInstance<T>(T instance) where T : class;
        TService Resolve<TService>();
        bool IsRegistered<TService>();
        void Done();
    }
}
