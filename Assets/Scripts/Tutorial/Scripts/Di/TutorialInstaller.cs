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
        Container.Bind<TutorialWinInfo>().AsSingle();
        
        Container.BindInterfacesAndSelfTo<TutorialStartView>().FromComponentsInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<TutorialStepView>().FromComponentsInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<TutorialWinView>().FromComponentsInHierarchy().AsSingle();
        
       
        Container.BindInterfacesTo<NavigateStepsPm>().AsSingle();
        Container.BindInterfacesTo<StartLaboratoryWorkPm>().AsSingle();
        Container.BindInterfacesTo<WinLaboratoryWorkPM>().AsSingle();
        
        Container.BindInterfacesTo<TutorialPmAdapter>().AsSingle();
    }
}