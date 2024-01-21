namespace DI_UseAutoFac.Services
{
    public interface IMath
    {
        int Execute(int a, int b);
    }

    public class Sum : IMath
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
