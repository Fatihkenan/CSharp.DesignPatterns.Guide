namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    internal class TurkAnaYemek : IAnaYemek
    {
        public void Hazırla()
        {
            Console.WriteLine("Türk Ana Yemek Hazırlandı.");
        }
    }
}
