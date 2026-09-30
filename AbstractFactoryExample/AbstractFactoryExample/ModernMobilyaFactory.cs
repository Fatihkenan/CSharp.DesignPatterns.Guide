namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactoryExample
{
    internal class ModernMobilyaFactory : IMobilyaFactory
    {
        public IMasa CreateMasa()
        {
            return new ModernMasa();
        }
        public IKoltuk CreateKoltuk()
        {
            return new ModernKoltuk();
        }
    }
}
