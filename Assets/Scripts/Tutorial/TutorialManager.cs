using System;
using UnityEngine;

    public sealed class TutorialManager : MonoBehaviour
    {
        public event Action<TutorialStep> OnStepFinished;

        public event Action<TutorialStep> OnNextStep;

        public event Action OnCompleted;
        public event Action OnSetUp;

        public bool IsCompleted
        {
            get { return _isCompleted; }
        }

        public TutorialStep CurrentStep
        {
            get { return _stepList[_currentIndex]; }
        }

        public int CurrentIndex
        {
            get { return _currentIndex; }
        }
        
        public TutorialList GetTutorialList => _stepList;
        public void SetUp(TutorialList stepList, int currentStepIndex, bool complete)
        {
            _stepList = stepList;
            _currentIndex = currentStepIndex;
            _isCompleted = complete;
            OnSetUp?.Invoke();
        }
        
        [SerializeField]
        private TutorialList _stepList;
        
        private int _currentIndex;

        private bool _isCompleted;

        public void Initialize(bool isCompleted = false, int stepIndex = 0)
        {
            _isCompleted = isCompleted;
            _currentIndex = Mathf.Clamp(stepIndex, 0, _stepList.LastIndex);
        }

        public void FinishCurrentStep()
        {
            if (!_isCompleted)
            {
                OnStepFinished?.Invoke(CurrentStep);
            }
        }

        public void MoveToNextStep()
        {
            if (_isCompleted)
            {
                return;
            }

            if (_stepList.IsLast(_currentIndex))
            {
                _isCompleted = true;
                OnCompleted?.Invoke();
                return;
            }

            _currentIndex++;
            OnNextStep?.Invoke(CurrentStep);
        }

        public bool IsStepPassed(TutorialStep step)
        {
            if (_isCompleted)
            {
                return true;
            }

            return _stepList.IndexOf(step) < _currentIndex;
        }

        public int IndexOfStep(TutorialStep step)
        {
            return _stepList.IndexOf(step);
        }
    }
