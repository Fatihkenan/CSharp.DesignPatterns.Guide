namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    public class ItalyanMutfagıFactory : IYemekFactory
    {
        public IAnaYemek CreateAnaYemek()
        {
            return new ItalyanAnaYemek();
        }

        public ISalata CreateSalata()
        {
            return new ItalyanSalata();
        }
    }
}
