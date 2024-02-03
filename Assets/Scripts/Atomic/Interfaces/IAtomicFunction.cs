namespace Game.GameEngine
{
    public interface IAtomicFunction<in T, out R>
    {
        R Invoke(T args);
    }
}