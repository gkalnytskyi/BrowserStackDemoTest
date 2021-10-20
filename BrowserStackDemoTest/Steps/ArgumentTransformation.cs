using BrowserStackDemoTest.Support;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BrowserStackDemoTest.Steps
{
    [Binding]
    public class ArgumentTransformation
    {
        [StepArgumentTransformation]
        public ShippingDetails ToShippingDetails(Table table)
        {
            return table.CreateInstance<ShippingDetails>();
        }
    }
}
