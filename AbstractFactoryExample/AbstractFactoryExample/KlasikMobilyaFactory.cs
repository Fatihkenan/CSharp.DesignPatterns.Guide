namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactoryExample
{
    public class KlasikMobilyaFactory : IMobilyaFactory
    {
        public IMasa CreateMasa()
        {
            return new KlasikMasa();
        }

        public IKoltuk CreateKoltuk()
        {
            return new KlasikKoltuk();
        }
    }
}
