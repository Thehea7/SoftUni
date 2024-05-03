using System;
using System.Security.Cryptography;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void When_Axe_Attacks_ShouldLooseDurability()
        {
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(5, 5);
            axe.Attack(dummy);

            Assert.AreEqual(4, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
        [Test]

        public void When_Axe_IsBroken_ShouldThrow_Expection()
        {
            Axe axe = new Axe(5, 0);
            Dummy dummy = new Dummy(5, 5);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}