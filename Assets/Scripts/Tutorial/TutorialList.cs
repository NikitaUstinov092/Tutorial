using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(
        fileName = "TutorialList",
        menuName = "Tutorial/New TutorialList"
    )]
    public sealed class TutorialList : ScriptableObject
    {
        public int LastIndex
        {
            get { return _steps.Count - 1; }
        }

        public TutorialStep this[int index]
        {
            get { return _steps[index]; }
        }
        
        public int IndexOf(TutorialStep step)
        {
            return _steps.IndexOf(step);
        }

        public bool IsLast(int index)
        {
            return index >= _steps.Count - 1;
        }
        
        [SerializeField] private List<TutorialStep> _steps = new();
    }
