using System;
using System.Net.Http;
using WebApi.Controllers;
using Xunit;

namespace WebApi.Tests
{
    public class ValuesControllerFixture
    {
        [Fact]
        public void Web_Api_Should_Show_Hey_On_Get_Params_Hello()
        {
            var myApi = new ValuesController();
            string expectedResult = "Hello";
            Assert.Equal(expectedResult, myApi.Get().Value);

        }
        [Fact]
        public void Web_Api_Should_Show_Hello_On_Get_Params_Hey()
        {
            var myApi = new ValuesController();
            string expectedResult = "Hello";
            string getParams = "Hey";
            Assert.Equal(expectedResult, myApi.Get(getParams).Value);
        }
        [Fact]
        public void Web_Api_Should_Show_Hello_On_No_Get_Params()
        {
            var myApi = new ValuesController();
            string expectedResult = "Hello";
            string getParams = "Hey";
            Assert.Equal(expectedResult, myApi.Get(getParams).Value);

        }
    }
}
