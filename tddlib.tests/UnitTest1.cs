using System;
using Xunit;

namespace tddlib.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        public void DivisableBy400AreLeapYear(int year)
        {
            var sut = new LeapYear();
            var actual = sut.IsLeapYear(year);
            Assert.True(actual);
        }

        [Theory]
        [InlineData(900)]
        [InlineData(100)]
        public void DivisableNotLeapYear(int year)
        {
            var sut = new LeapYear();
            var actual = sut.IsLeapYear(year);
            Assert.False(actual);
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void DivisableBy100ButNot400AreNotLeapYear(int year)
        {
            var sut = new LeapYear();
            var actual = sut.IsLeapYear(year);
            Assert.False(actual);
        }

        [Theory]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        public void DivisableBy4ButNot100AreLeapYear(int year)
        {
            var sut = new LeapYear();
            var actual = sut.IsLeapYear(year);
            Assert.True(actual);
        }

        [Theory]
        [InlineData(2017)]
        [InlineData(2018)]
        [InlineData(2019)]
        public void DivisableBy4AreNotLeapYear(int year)
        {
            var sut = new LeapYear();
            var actual = sut.IsLeapYear(year);
            Assert.False(actual);
        }




    }
}
