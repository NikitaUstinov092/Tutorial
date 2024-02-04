using UnityEngine;
using Zenject;

public class TutorialObserversProvider : MonoBehaviour, IInitializable
{
    [SerializeField]
    private TutorialStepObserver[] _tutorialStepObservers;
    
    [SerializeField]
    private TutorialCompleteObserver[] _tutorialCompleteObservers;
    
    void IInitializable.Initialize()
    {
        foreach (var stepObserver in _tutorialStepObservers)
        {
            stepObserver.ReadyGame();
            stepObserver.StartGame();
        }
        foreach (var completeObserver in _tutorialCompleteObservers)
        {
            completeObserver.ReadyGame();
        }
    }
}
