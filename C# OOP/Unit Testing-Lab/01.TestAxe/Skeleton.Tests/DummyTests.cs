using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 5;
        private const int DummyExp = 5;
        private const int AxeAttack = 5;
        private const int AxeDurability = 5;
        private Dummy dummy;
        private Axe axe;
        [SetUp]
       public void SetUp()
        {
            dummy = new Dummy(DummyHealth, DummyExp);
            axe = new Axe(AxeAttack, AxeDurability);
        }

        [Test]
        public void When_DummyIsAttacked_ShouldLooseHealth()
        {
           dummy.TakeAttack(axe.AttackPoints);
            Assert.AreEqual(0, dummy.Health);
        }
        [Test]
        public void When_DummyIsAttacked_ButIsDead_ShouldThrowException()
        {
            dummy.TakeAttack(axe.AttackPoints);
           Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(axe.AttackPoints);
            });

           Assert.AreEqual("Dummy is dead.", ex.Message);
        }
        [Test]
        public void When_DummyIsDead_ShouldGiveXP()
        {
            dummy.TakeAttack(axe.AttackPoints);
            dummy.GiveExperience();
            

            Assert.AreEqual(DummyExp, dummy.GiveExperience());
        }
        [Test]
        public void When_DummyIsAlive_ShouldNotGiveXP()
        {
           Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });

            Assert.AreEqual("Target is not dead.", ex.Message);
        }
    }
}