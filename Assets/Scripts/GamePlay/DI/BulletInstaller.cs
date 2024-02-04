using Zenject;

public class BulletInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<DelayDestroyer>().FromInstance(this).AsSingle();
        Container.BindInterfacesTo<MoveProvider>().FromInstance(this).AsSingle();
    }
}
