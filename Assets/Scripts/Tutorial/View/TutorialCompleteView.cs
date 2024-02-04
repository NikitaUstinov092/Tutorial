using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace StandScene.Tutorial.View
{
    public class TutorialCompleteView: MonoBehaviour, IInitializable, IDisposable
    {
        [SerializeField] 
        private GameObject _popup;
        
        [SerializeField] 
        private TextMeshProUGUI _name;
        
        [Inject] 
        private IEndTutorialPm _pm;
        void IInitializable.Initialize()
        {
            _pm.OnModelStateChanged += Show;
        }
        void IDisposable.Dispose()
        {
            _pm.OnModelStateChanged -= Show;
        }
        public void Show()
        {
            UpdateView();
            _popup.SetActive(true);
        }
        
        public void Hide()
        {
            _popup.SetActive(false);
        }
        
        private void UpdateView()
        {
            _name.text = _pm.GetLevel();
        }
    }
}