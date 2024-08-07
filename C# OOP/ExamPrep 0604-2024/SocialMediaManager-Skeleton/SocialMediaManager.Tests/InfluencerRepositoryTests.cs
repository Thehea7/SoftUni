using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaManager.Tests
{
    public class Tests
    {
        private InfluencerRepository _influencerRepository;

        [SetUp]
        public void Setup()
        {
            _influencerRepository = new();


        }

        [Test]
        public void NewInfluencerRepository_ShouldInitializeInfluencersCollectionCorrectly()
        {
            Assert.NotNull(_influencerRepository);
            Assert.AreEqual(0, _influencerRepository.Influencers.Count);
        }

        [Test]
        public void RegisterInfluencer_shouldThrowArgumentNullException_WhenIsNull()
        {
           Assert.Throws<ArgumentNullException>(() => _ = _influencerRepository.RegisterInfluencer(null));
        }

        [Test]
        public void RegisterInfluencer_shouldThrowInvalidOperationException_WhenAlreadyRegistered()
        {
            Influencer influencer = new("Gosho", 123);

            _ = _influencerRepository.RegisterInfluencer(influencer);

            Assert.Throws<InvalidOperationException>((() => _ = _influencerRepository.RegisterInfluencer(influencer)));
        }
        
        [Test]
        public void RegisterInfluencer_ShouldRegisterInfluencer()
        {
            Influencer influencer = new("Gosho", 123);

            string message = _influencerRepository.RegisterInfluencer(influencer);

            Assert.AreEqual($"Successfully added influencer {influencer.Username} with {influencer.Followers}", message);
            Assert.AreEqual(1, _influencerRepository.Influencers.Count);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("     ")]
        [TestCase(null)]
        public void RemoveInfluencer_ShouldThrowArgumentNullException_WhenusernameIsNullOrWhitespace(string name)
        {
            Assert.Throws<ArgumentNullException>(() => _ = _influencerRepository.RemoveInfluencer(name));
        }

        [Test]
        public void RemoveInfluencer_ShouldReturnTrue_IfItIsSuccesfullyRemoved()
        {
            Influencer influencer = new Influencer("Gosho", 123);
           _ = _influencerRepository.RegisterInfluencer(influencer);
           bool removed = _influencerRepository.RemoveInfluencer(influencer.Username);
            Assert.AreEqual(true, removed);
            Assert.That(removed, Is.EqualTo(true));
        }

        [Test]
        public void RemoveInfluencer_ShouldReturnFalse_IfItIsNotSuccesfullyRemoved()
        {
            Influencer influencer = new Influencer("Gosho", 123);
            bool removed = _influencerRepository.RemoveInfluencer(influencer.Username);

            Assert.AreEqual(false, removed);
            Assert.IsFalse(removed);
        }

        [Test]

        public void GetInfluencerWithmostfolowers_ShouldWorkCorrectly()
        {
            Influencer asen = new Influencer("asen", 123);
            Influencer lubo = new Influencer("lubo", 13);
            Influencer gosho = new Influencer("Gosho", 23);
            Influencer tedo = new Influencer("Tedo", 1223);
            Influencer bobo = new Influencer("bobo", 1323);

            _ = _influencerRepository.RegisterInfluencer(asen);
            _ = _influencerRepository.RegisterInfluencer(lubo);
            _ = _influencerRepository.RegisterInfluencer(gosho);
            _ = _influencerRepository.RegisterInfluencer(tedo);
            _ = _influencerRepository.RegisterInfluencer(bobo);

            Influencer actual = _influencerRepository.GetInfluencerWithMostFollowers();

            Assert.AreEqual(bobo, actual);
        }
        [TestCase("asen")]
        [TestCase("bobo")]
        [TestCase("Tedo")]
        public void GetInfluencer_ShouldWork(string username)
        {
            Influencer asen = new Influencer("asen", 123);
            Influencer lubo = new Influencer("lubo", 13);
            Influencer gosho = new Influencer("Gosho", 23);
            Influencer tedo = new Influencer("Tedo", 1223);
            Influencer bobo = new Influencer("bobo", 1323);

            _ = _influencerRepository.RegisterInfluencer(asen);
            _ = _influencerRepository.RegisterInfluencer(lubo);
            _ = _influencerRepository.RegisterInfluencer(gosho);
            _ = _influencerRepository.RegisterInfluencer(tedo);
            _ = _influencerRepository.RegisterInfluencer(bobo);

            Influencer influencer = _influencerRepository.GetInfluencer(username);

            Assert.AreEqual(username, influencer.Username);
        }
        [TestCase("null")]
        [TestCase("Stamo")]
        [TestCase("Doncho")]
        public void GetInfluencer_ShouldReturnNull(string username)
        {
            Influencer asen = new Influencer("asen", 123);
            Influencer lubo = new Influencer("lubo", 13);
            Influencer gosho = new Influencer("Gosho", 23);
            Influencer tedo = new Influencer("Tedo", 1223);
            Influencer bobo = new Influencer("bobo", 1323);

            _ = _influencerRepository.RegisterInfluencer(asen);
            _ = _influencerRepository.RegisterInfluencer(lubo);
            _ = _influencerRepository.RegisterInfluencer(gosho);
            _ = _influencerRepository.RegisterInfluencer(tedo);
            _ = _influencerRepository.RegisterInfluencer(bobo);

            Influencer influencer = _influencerRepository.GetInfluencer(username);

            Assert.IsNull(influencer);
        }
    }
}