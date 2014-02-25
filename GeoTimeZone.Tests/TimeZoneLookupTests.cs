﻿using NUnit.Framework;

namespace GeoTimeZone.Tests
{
    [TestFixture]
    public class TimeZoneLookupTests
    {
        [Test]
        public void Can_Lookup_Where_Two_Countries_Meet()
        {
            var france = TimeZoneLookup.GetTimeZone(47.589983, 7.587417);
            Assert.AreEqual("Europe/Paris", france.Result.IanaTimeZoneId);
            Assert.AreEqual("Europe/Zurich", france.AlternativeResults[0].IanaTimeZoneId);

            var switzerland = TimeZoneLookup.GetTimeZone(47.58735, 7.588967);
            Assert.AreEqual("Europe/Paris", switzerland.Result.IanaTimeZoneId);
            Assert.AreEqual("Europe/Zurich", switzerland.AlternativeResults[0].IanaTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_PaigntonPier()
        {
            var tz = TimeZoneLookup.GetTimeZone(50.4372, -3.5559).Result;
            Assert.AreEqual("Europe/London", tz.IanaTimeZoneId);
            Assert.AreEqual("GMT Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Phoenix()
        {
            var tz = TimeZoneLookup.GetTimeZone(33.45, -112.0667).Result;
            Assert.AreEqual("America/Phoenix", tz.IanaTimeZoneId);
            Assert.AreEqual("US Mountain Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_NewYork()
        {
            var tz = TimeZoneLookup.GetTimeZone(40.67, -73.94).Result;
            Assert.AreEqual("America/New_York", tz.IanaTimeZoneId);
            Assert.AreEqual("Eastern Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_LosAngeles()
        {
            var tz = TimeZoneLookup.GetTimeZone(34.0500, -118.25).Result;
            Assert.AreEqual("America/Los_Angeles", tz.IanaTimeZoneId);
            Assert.AreEqual("Pacific Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Honolulu()
        {
            var tz = TimeZoneLookup.GetTimeZone(21.3, -157.8167).Result;
            Assert.AreEqual("Pacific/Honolulu", tz.IanaTimeZoneId);
            Assert.AreEqual("Hawaiian Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_London()
        {
            var tz = TimeZoneLookup.GetTimeZone(51.5072, -0.1275).Result;
            Assert.AreEqual("Europe/London", tz.IanaTimeZoneId);
            Assert.AreEqual("GMT Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_SaoPaulo()
        {
            var tz = TimeZoneLookup.GetTimeZone(-23.55, -46.6333).Result;
            Assert.AreEqual("America/Sao_Paulo", tz.IanaTimeZoneId);
            Assert.AreEqual("E. South America Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_Sydney()
        {
            var tz = TimeZoneLookup.GetTimeZone(-33.86, 151.2111).Result;
            Assert.AreEqual("Australia/Sydney", tz.IanaTimeZoneId);
            Assert.AreEqual("AUS Eastern Standard Time", tz.WindowsTimeZoneId);
        }

        [Test]
        public void Can_Lookup_TimeZone_LordHoweIsland()
        {
            var tz = TimeZoneLookup.GetTimeZone(-31.55, 159.0833).Result;
            Assert.AreEqual("Australia/Lord_Howe", tz.IanaTimeZoneId);
            Assert.Null(tz.WindowsTimeZoneId); // No Windows Equivalent
        }

        [Test]
        public void Can_Lookup_TimeZone_Mazatlan()
        {
            var tz = TimeZoneLookup.GetTimeZone(23.22, -106.42).Result;
            Assert.AreEqual("America/Mazatlan", tz.IanaTimeZoneId);
            Assert.AreEqual("Mountain Standard Time (Mexico)", tz.WindowsTimeZoneId);
        }
    }
}
