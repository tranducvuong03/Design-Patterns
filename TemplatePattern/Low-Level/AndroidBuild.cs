using DesignPatterns.TemplatePattern.High_Level;

namespace DesignPatterns.TemplatePattern.Low_Level
{
    public class AndroidBuild : GameBuild
    {
        protected override void BuildAssets()
        {
            Console.WriteLine("Compress assets for mobile");
        }

        protected override void Deploy()
        {
            Console.WriteLine("Deploy to Play Store");
        }
    }
}
