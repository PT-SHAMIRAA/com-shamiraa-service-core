﻿using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.Shamiraa.Service.Core.Test.Controllers.LampStandard
{
    [Collection("TestFixture Collection")]
    public class LampStandardTest
    {
        private const string URI = "v1/master/lamp-standard";

        protected TestServerFixture TestFixture { get; set; }

        protected HttpClient Client
        {
            get { return this.TestFixture.Client; }
        }

        public LampStandardTest(TestServerFixture fixture)
        {
            TestFixture = fixture;

        }

        public LampStandardViewModel GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new LampStandardViewModel()
            {
                Name = string.Format("TEST {0}", guid),
                Remark = "test"
            };
        }

        [Fact]
        public async Task Get()
        {
            var response = await this.Client.GetAsync(URI);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetById()
        {
            var response = await this.Client.GetAsync(string.Concat(URI, "/"));
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Post()
        {

            LampStandardViewModel ViewModel = GenerateTestModel();
            var response = await this.Client.PostAsync(URI, new StringContent(JsonConvert.SerializeObject(ViewModel).ToString(), Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
