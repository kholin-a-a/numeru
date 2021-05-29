namespace Numeru.Web
{
    public interface IOpenGraph<TView>
    {
        OpenGraphViewModel Data();

        string Description();

        string Title();
    }
}
