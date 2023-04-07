namespace Homework.Providers
{
    public interface IProvider
    {
        int Speed { get; }
        void Request();
    }
}

