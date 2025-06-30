namespace DelegateInCSharp;

public abstract class Process
{
    protected static void DeleteImages(List<ImagesPath> list)
    {
    }
}


protected class GetDataBL : Process
{

    public static void DeleteImages(List<ImagesPath> list)
    {
        DeleteImages(list);
    }
}
public class Program
{
    #region Before

    #endregion


    static void Main(string[] args)
    {

    }
}