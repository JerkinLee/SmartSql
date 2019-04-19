﻿using SmartSql.Test.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SmartSql.Test.Unit.Tags
{
    [Collection("GlobalSmartSql")]
    public class SetTest 
    {
        protected ISqlMapper SqlMapper { get; }

        public SetTest(SmartSqlFixture smartSqlFixture)
        {
            SqlMapper = smartSqlFixture.SqlMapper;
        }
        [Fact]
        public void Set_Test()
        {
            var user = SqlMapper.QuerySingle<User>(new RequestContext
            {
                Scope = nameof(SetTest),
                SqlId = "UpdateUser",
                Request = new { UserName = "SmartSql",Status=1,Id=1 }
            });
            Assert.True(true);
        }

    }
}
