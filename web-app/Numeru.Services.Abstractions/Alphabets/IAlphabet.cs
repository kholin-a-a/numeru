namespace Numeru.Services
{
    public interface IAlphabet
    {
        int NumberOf(string letter);

        bool Contains(string letter);
    }
}
