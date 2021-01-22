﻿using TokenPrice.Core;
using TokenPrice.Core.Test;
using System.Numerics;
using Xunit;


namespace Aave
{
    public class GetReserveDataAsyncTest
    {
        [Fact]
        public async void TestValid()
        {
            var Reserve = new GetAave
            {
                Web3 = neth.web3
            };
            var result = await Reserve.GetReserveDataAsync("0x057835Ad21a177dbdd3090bB1CAE03EaCF78Fc6d","0xdAC17F958D2ee523a2206206994597C13D831ec7");
            Assert.NotNull(result);
        }
    }
}
