
namespace MultiFrameworkLibrary
{
    public class Framework
    {
        public void PrintFramework() {
            Console.WriteLine(GetFramework());
        }

        private string GetFramework()
        {
#if NET8_0
            return "NET8";
#elif NET6_0_OR_GREATER
            return "NET6_OR_Greater";
#else
            return "Unknown";
#endif
        }
    }
}
