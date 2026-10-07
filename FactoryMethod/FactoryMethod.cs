namespace FactoryMethod
{
    public abstract class FactoryMethod
    {
        public abstract void CreatePages();
    }

    public class WebSiteCommerce : FactoryMethod
    {
        public override void CreatePages()
        {
            Console.WriteLine("Creating e-commerce pages...");
        }
    }

    public class WebSiteBlog : FactoryMethod
    {
        public override void CreatePages()
        {
            Console.WriteLine("Creating blog pages...");
        }
    }
    public abstract class WebSiteFactory
    {
        public abstract FactoryMethod CreateWebSite();
    }
    public class WebSiteCommerceFactory : WebSiteFactory
    {
        public override FactoryMethod CreateWebSite()
        {
            return new WebSiteCommerce();
        }
    }
    public class WebSiteBlogFactory : WebSiteFactory
    {
        public override FactoryMethod CreateWebSite()
        {
            return new WebSiteBlog();
        }
    }
}
