using NUnit.Framework;
using System;

namespace HippoValidator.GooglePageSpeedClient.Tests
{
    public class GooglePageSpeedClientTest
    {
        [Test]
        public void CanValidateUrl()
        {
            var validationResult =
                new GooglePageSpeedValidator("<Insert Api Key here>").Validate(
                    new Uri("http://www.hippovalidator.com"));
            Assert.That(validationResult, Is.Not.Null);
            Assert.That(validationResult.Score, Is.Not.EqualTo(0));
        }
    }
}