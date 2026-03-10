using DesignPatterns.TemplatePattern.High_Level;

namespace DesignPatterns.TemplatePattern.Low_Level
{
    public class PCBuild : GameBuild
    {
        protected override bool ShouldRunTests()
        {
            return true;
        }

        protected override void BuildAssets()
        {
            Console.WriteLine("Build assets for PC");
        }

        protected override void Deploy()
        {
            Console.WriteLine("Deploy to Steam");
        }
    }
}
