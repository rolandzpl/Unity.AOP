using NUnit.Framework;
using Unity;

namespace Lithium.Unity.AOP
{
    public class BasicInterceptorTests
    {
        [Test]
        public void Test1()
        {
            var container = new UnityContainer();
            container.AddExtension(new AOPExtension());
            Assert.Pass();
        }
    }
}