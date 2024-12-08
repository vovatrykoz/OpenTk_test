using System.Numerics;

Animation<OpenTK.Mathematics.Vector2> animation = new(OpenTK.Mathematics.Vector2.One, OpenTK.Mathematics.Vector2.One);

animation.Update();

class Animation<T>(T value, T update) where T : IAdditionOperators<T, T, T>
{
    public T Update()
    {
        value += update;
        return value;
    }
}
