using GamePlay.Player;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<HitedTargetCounter>().AsSingle();
        Container.Bind<PlayerShoot>().FromComponentInHierarchy().AsSingle();
        Container.Bind<PlayerInput>().FromComponentInHierarchy().AsSingle();
        Container.Bind<Move>().FromComponentInHierarchy().AsSingle();
        Container.BindInterfacesTo<PlayerAdapter>().AsSingle();
    }
}