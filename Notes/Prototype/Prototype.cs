

public class LiasseViergeSingleton
{
    static LiasseViergeSingleton singleton;

    private LiasseViergeSingleton()
    {
        
    }

    public static LiasseViergeSingleton Instance()
    {
        if(singleton is null)
        {
            singleton = new LiasseViergeSingleton();
        }
        return singleton;
    }
}