﻿using System.Threading.Tasks;
using eZet.EveLib.Core.RequestHandlers;
using eZet.EveLib.ZKillboardModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eZet.EveLib.Test {
    [TestClass]
    public class ZKillboard_Tests {
        public ZKillboard Api = new ZKillboard();

        public ZKillboardOptions Options = new ZKillboardOptions();

        public ZKillboard_Tests() {
            Options.Limit = 1;
            Options.WSpace = true;
            Api.RequestHandler.CacheLevel = CacheLevel.BypassCache;
        }

        [TestMethod]
        public void GetKills_ValidRequest_NoErrors() {
            var result = Api.GetKills(Options);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetLosses_ValidRequest_NoErrors() {
            var result = Api.GetLosses(Options);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAll_ValidRequest_NoErrors() {
            var result = Api.GetLosses(Options);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetStats() {
            var response = await Api.GetStatsAsync(EntityType.CorporationId, 98330748);
            Assert.IsNotNull(response);
        }
    }
}