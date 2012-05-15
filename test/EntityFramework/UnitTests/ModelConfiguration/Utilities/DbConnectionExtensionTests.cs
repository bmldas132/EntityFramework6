namespace System.Data.Entity.ModelConfiguration.Utilities.UnitTests
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.SqlClient;
    using Xunit;

    public sealed class DbConnectionExtensionTests
    {
        [Fact]
        public void GetProviderInvariantName_should_return_correct_name()
        {
            Assert.Equal("System.Data.SqlClient", new SqlConnection().GetProviderInvariantName());
        }

        [Fact]
        public void GetProviderInvariantName_should_return_correct_name_when_generic_provider()
        {
            Assert.Equal("My.Generic.Provider.DbProviderFactory", new GenericConnection<DbProviderFactory>().GetProviderInvariantName());
        }
    }
}