using System.Linq.Expressions;

namespace AutoFixture.Customizations.Example.App.Test
{
    public class FixtureCustomization<T>
    {
        public Fixture Fixture { get; }

        public FixtureCustomization(Fixture fixture)
        {
            Fixture = fixture;
        }

        public FixtureCustomization<T> With<TProp>(Expression<Func<T, TProp>> expr, TProp value)
        {
            Fixture.Customizations.Add(new OverridePropertyBuilder<T, TProp>(expr, value));
            return this;
        }

        public T Create() => Fixture.Create<T>();
    }

    public static class CompositionExt
    {
        public static FixtureCustomization<T> For<T>(this Fixture fixture)
            => new FixtureCustomization<T>(fixture);
    }
}
