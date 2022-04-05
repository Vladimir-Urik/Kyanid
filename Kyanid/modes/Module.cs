namespace Kyanid
{
    public interface Module
    {
        string Name();
        void Init();

        void Start();
        
        void Stop();
    }
}