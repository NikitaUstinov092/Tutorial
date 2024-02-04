using UnityEngine;
using Zenject;

public class TutorialObserversProvider : MonoBehaviour
{
    [SerializeField]
    private TutorialStepObserver[] _tutorialStepObservers;
    
    [SerializeField]
    private TutorialCompleteObserver[] _tutorialCompleteObservers;
    
    public void Start()
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
