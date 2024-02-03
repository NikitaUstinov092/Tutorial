using System;
using UnityEngine;
using Zenject;

public abstract class TutorialCompleteObserver : MonoBehaviour, IDisposable
    {
        [Inject]
        private TutorialManager tutorialManager;

        public virtual void ReadyGame()
        {
            tutorialManager.OnCompleted += OnTutorialComplete;
        }

        public virtual void FinishGame()
        {
            tutorialManager.OnCompleted -= OnTutorialComplete;
        }
        
        protected virtual void OnTutorialComplete()
        {
        }

        public bool IsCompleted()
        {
            return tutorialManager.IsCompleted;
        }

        public void Dispose()
        {
            FinishGame();
        }
    }
