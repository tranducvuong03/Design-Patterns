namespace DesignPatterns.TemplatePattern.High_Level
{
    public abstract class GameBuild
    {
        public void Build()
        {
            CompileCode();
            BuildAssets();
            PackageGame();
            Deploy();
        }

        protected void CompileCode()
        {
            Console.WriteLine("Compile source code");
        }

        protected abstract void BuildAssets();

        protected void PackageGame()
        {
            Console.WriteLine("Packaging game");
        }

        protected abstract void Deploy();
    }
}
