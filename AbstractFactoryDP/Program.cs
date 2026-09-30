using CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory;

IYemekFactory factory = new TurkMutfagıFactory();
IAnaYemek anaYemek = factory.CreateAnaYemek();
ISalata salata = factory.CreateSalata();
anaYemek.Hazırla();
salata.Hazırla();

IYemekFactory italyanFactory = new ItalyanMutfagıFactory();
IAnaYemek italyanAnaYemek = italyanFactory.CreateAnaYemek();
ISalata italyanSalata = italyanFactory.CreateSalata();
italyanAnaYemek.Hazırla();
italyanSalata.Hazırla();


Console.ReadLine();