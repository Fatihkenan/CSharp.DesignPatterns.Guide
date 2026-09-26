using CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactory;
using CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactoryExample;

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

IMobilyaFactory mobilyaFactory = new ModernMobilyaFactory();
IMasa masa = mobilyaFactory.CreateMasa();
IKoltuk koltuk = mobilyaFactory.CreateKoltuk();
masa.BilgiVer();
koltuk.BilgiVer();


Console.ReadLine();