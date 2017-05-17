﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CensusAPIService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CensusAPIService.Models;

namespace CensusAPIService.Tests
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void Address_VerifyXmlFactory_ValidXml()
        {
            // Address to compare against
            var correctAddress = new Address()
            {
                UniqueId = 1,
                Street = "667 Massachusetts Avenue",
                City = "Cambridge",
                State = "MA",
                Zip = "02139"
            };

            // Generate an address from an XML string using the factory method
            var address = Address.ParseAddressFromXml
            (
              @"<Address>
	                <UniqueId>1</UniqueId>
	                <Street>667 Massachusetts Avenue</Street>
	                <City>Cambridge</City>
	                <State>MA</State>
	                <Zip>02139</Zip>
                </Address>"
            );

            Assert.AreEqual(address.UniqueId, correctAddress.UniqueId);
            Assert.AreEqual(address.Street, correctAddress.Street);
            Assert.AreEqual(address.City, correctAddress.City);
            Assert.AreEqual(address.State, correctAddress.State);
            Assert.AreEqual(address.Zip, correctAddress.Zip);
        }

        [TestMethod]
        public void Address_VerifyXmlFactory_InvalidXml()
        {
            //var address = Address.ParseAddressFromXml("><Example>");
        }
    }
}