namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    public class TurkSalata : ISalata
    {
        public void Hazırla()
        {
            Console.WriteLine("Türk Salata Hazırlandı.");
        }
    }
}
