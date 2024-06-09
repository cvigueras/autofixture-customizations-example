using AutoFixture;

namespace AutoFixture.Customizations.Example.App.Test
{
    public class UserShould
    {
        private Home home;
        private Fixture fixture;

        [SetUp]
        public void Setup()
        {
            home = new Home();
            fixture = new Fixture();
        }

        [Test]
        public void get_user_successfully_when_create_with_autofixture()
        {
            var user = fixture.Create<User>();

            Assert.IsNotNull(user);
        }

        [Test]
        public void get_message_under_eighteen_years()
        {
            var givenUserUnderEighteen =
              new Fixture()
                .For<User>()
                .With(x => x.Age, 16)
                .Create();

            var message = home.Access(givenUserUnderEighteen);

            Assert.IsTrue(string.Equals(message,
                "Aplicación web solo para personas mayores de edad", StringComparison.OrdinalIgnoreCase));
        }
    }
}