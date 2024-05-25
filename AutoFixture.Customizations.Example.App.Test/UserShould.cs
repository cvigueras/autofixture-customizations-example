using AutoFixture;

namespace AutoFixture.Customizations.Example.App.Test
{
    public class UserShould
    {
        private Fixture fixture;

        [SetUp]
        public void Setup()
        {
            fixture = new Fixture();
        }

        [Test]
        public void get_user_successfully_when_create_with_autofixture()
        {
            var user = fixture.Create<User>();

            Assert.IsNotNull(user);
        }
    }
}