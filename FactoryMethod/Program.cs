using FactoryMethod;

WebSiteFactory factory = new WebSiteCommerceFactory();
factory.CreateWebSite().CreatePages();