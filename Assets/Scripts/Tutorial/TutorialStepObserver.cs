using System;
using UnityEngine;
using Zenject;


    public abstract class TutorialStepObserver : MonoBehaviour, IDisposable
    {
        [SerializeField] 
        private TutorialStep _step;
        
        private TutorialManager _tutorialManager;
       
        [Inject] 
        public void ConstructGame(DiContainer container)
        {
            _tutorialManager = container.Resolve<TutorialManager>();
             InitGame(container,false);
        }
        protected virtual void InitGame(DiContainer container, bool isStepPassed)
        {
            
        }
        public virtual void ReadyGame()
        {
            _tutorialManager.OnStepFinished += CheckForFinish;
            _tutorialManager.OnNextStep += CheckForStart;
        }
        public virtual void StartGame()
        {
            var stepFinished = _tutorialManager.IsStepPassed(_step);
            if (!stepFinished)
            {
                CheckForStart(_tutorialManager.CurrentStep);
            }
        }
        public virtual void FinishGame()
        {
            _tutorialManager.OnStepFinished -= CheckForFinish;
            _tutorialManager.OnNextStep -= CheckForStart;
        }

        protected virtual void OnStartStep()
        {
        }

        protected virtual void OnFinishStep()
        {
        }
        protected void FinishStep()
        {
            if (_tutorialManager.CurrentStep == _step)
            {
                _tutorialManager.FinishCurrentStep();
            }
        }
        protected void MoveNext()
        {
            if (_tutorialManager.CurrentStep == _step)
            {
                _tutorialManager.MoveToNextStep();
            }
        }
        protected void FinishStepAndMoveNext()
        {
            if (_tutorialManager.CurrentStep == _step)
            {
                _tutorialManager.FinishCurrentStep();
                _tutorialManager.MoveToNextStep();
            }
        }
        protected bool IsStepFinished()
        {
            return _tutorialManager.IsStepPassed(_step);
        }

        private void CheckForFinish(TutorialStep step)
        {
            if (_step == step)
            {
                OnFinishStep();
            }
        }

        private void CheckForStart(TutorialStep step)
        {
            if (_step == step)
            {
                OnStartStep();
            }
        }

        void IDisposable.Dispose()
        {
            FinishGame();
        }
    }
