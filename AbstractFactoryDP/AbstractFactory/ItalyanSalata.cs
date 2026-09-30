namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    public class ItalyanSalata : ISalata
    {
        public void Hazırla()
        {
            Console.WriteLine("Italyan Salata Hazırlandı.");
        }
    }
}
