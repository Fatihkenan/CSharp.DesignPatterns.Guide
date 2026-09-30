namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactoryExample
{
    interface IMobilyaFactory
    {
        public IMasa CreateMasa();

        public IKoltuk CreateKoltuk();

    }
}
