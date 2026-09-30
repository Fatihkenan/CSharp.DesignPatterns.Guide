namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    public class TurkMutfagıFactory : IYemekFactory
    {
        public IAnaYemek CreateAnaYemek()
        {
            return new TurkAnaYemek();
        }

        public ISalata CreateSalata()
        {
            return new TurkSalata();
        }
    }
}
