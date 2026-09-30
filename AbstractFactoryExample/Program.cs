
using CSharp.DesignPatterns.Guide._1_CreationalPatterns.AbstractFactoryExample;

IMobilyaFactory mobilyaFactory = new ModernMobilyaFactory();
IMasa masa = mobilyaFactory.CreateMasa();
IKoltuk koltuk = mobilyaFactory.CreateKoltuk();
masa.BilgiVer();
koltuk.BilgiVer();


Console.ReadLine();