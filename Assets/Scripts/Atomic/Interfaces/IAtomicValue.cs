namespace Game.GameEngine
{
    public interface IAtomicValue<out T>
    {
        T Value { get; }
    }
}