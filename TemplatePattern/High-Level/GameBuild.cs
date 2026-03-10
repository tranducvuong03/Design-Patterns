using DesignPatterns.SingletonPattern.NoMultithread;

namespace DesignPatterns.TemplatePattern.High_Level
{
    public abstract class GameBuild
    {
        public void Build()
        {
            CompileCode();

            if (ShouldRunTests())
            {
                RunTests();
            }

            BuildAssets();
            PackageGame();
            Deploy();
        }

        protected void CompileCode()
        {
            Console.WriteLine("Compile source code");
        }

        protected void RunTests()
        {
            Console.WriteLine("Running automated tests");
        }

        protected abstract void BuildAssets();

        protected void PackageGame()
        {
            Console.WriteLine("Packaging game");
        }

        protected abstract void Deploy();

        // HOOK
        // hook là method có implementation mặc định nhưng subclass có thể override hoặc không
        protected virtual bool ShouldRunTests()
        {
            return false;
        }
    }
}
