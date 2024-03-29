﻿using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace StandScene.Tutorial.View
{
    public class TutorialStepView: MonoBehaviour, IInitializable, IDisposable
    {
        [SerializeField] private GameObject _popup;
        
        [SerializeField] private TextMeshProUGUI _description;
        
        [Inject] private INavigateStepsPM _pm;
        
        void IInitializable.Initialize()
        {
            _pm.OnModelStateChanged += Show;
        }

        void IDisposable.Dispose()
        {
            _pm.OnModelStateChanged -= Show;
        }

        private void Show()
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
            _description.text = _pm.GetStepReview();
        }
        
    }
}