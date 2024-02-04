using Zenject;

public class BulletInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<DelayDestroyer>().FromComponentInHierarchy().AsSingle();
        Container.BindInterfacesTo<MoveProvider>().FromComponentInHierarchy().AsSingle();
    }
}
