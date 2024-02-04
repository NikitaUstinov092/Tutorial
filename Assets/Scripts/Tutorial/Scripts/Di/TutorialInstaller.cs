using StandScene.Tutorial.Controllers;
using StandScene.Tutorial.Data;
using StandScene.Tutorial.PM;
using StandScene.Tutorial.View;
using Zenject;

public class TutorialInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<TutorialManager>().FromComponentsInHierarchy().AsSingle();
        
        Container.Bind<TutorialStartInfo>().AsSingle();
        Container.Bind<TutorialStepInfo>().AsSingle();
        Container.Bind<TutorialCompleteInfo>().AsSingle();
        
        Container.BindInterfacesAndSelfTo<TutorialStartView>().FromComponentsInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<TutorialStepView>().FromComponentsInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<TutorialCompleteView>().FromComponentsInHierarchy().AsSingle();
        
        Container.BindInterfacesTo<NavigateStepsPm>().AsSingle();
        Container.BindInterfacesTo<StartTutorialPm>().AsSingle();
        Container.BindInterfacesTo<WinTutorialPM>().AsSingle();
        
        Container.BindInterfacesTo<TutorialPmAdapter>().AsSingle();
        Container.BindInterfacesTo<TutorialObserversProvider>().FromComponentsInHierarchy().AsSingle();
    }
}