using StandScene.Tutorial.Data;
using StandScene.Tutorial.View;
using UnityEngine;
using Zenject;

public class CompleteObserver_UIPopUp : TutorialCompleteObserver
{
    [SerializeField] private string _winInfo;
    
    private TutorialCompleteView _tutorialComplete;
    private TutorialCompleteInfo _tutorialInfo;
    
    [Inject]
    private void Construct(TutorialCompleteView tutorialComplete, TutorialCompleteInfo tutorialInfo)
    {
        _tutorialComplete = tutorialComplete;
        _tutorialInfo = tutorialInfo;
    }
    protected override void OnTutorialComplete()
    {
        _tutorialInfo.SetInfo(_winInfo);
        _tutorialComplete.Show();
    }
}
