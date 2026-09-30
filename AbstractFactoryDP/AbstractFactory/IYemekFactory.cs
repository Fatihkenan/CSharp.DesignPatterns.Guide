namespace CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory
{
    public interface IYemekFactory
    {
        IAnaYemek CreateAnaYemek();
        ISalata CreateSalata();
    }
}
