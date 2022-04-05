namespace Kyanid.managers
{
    public interface Manager
    {
        
        void Init(Kyanid kyanid);
       
        void Start(Kyanid kyanid);
        
        void Stop(Kyanid kyanid);

    }
}