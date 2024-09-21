public interface ILoader : IService
{
    void Save();

    void Load();
}


public class JsonLoader : ILoader
{
    public void Load()
    {
        throw new System.NotImplementedException();
    }

    public void Save()
    {
        throw new System.NotImplementedException();
    }
}

public class PlayerPrefsLoader : ILoader
{
    public void Load()
    {
        throw new System.NotImplementedException();
    }

    public void Save()
    {
        throw new System.NotImplementedException();
    }
}
