using TMPro;
using UnityEngine;
using Zenject;

namespace StandScene.Tutorial.View
{
    public class TutorialStepView: MonoBehaviour, ITutorialView
    {
        [SerializeField] private GameObject _popup;
        
        [SerializeField] private TextMeshProUGUI _description;
        
        [Inject] private INavigateStepsPM _pm;
        
        void ITutorialView.Start()
        {
            _pm.OnModelStateChanged += Show;
        }

        void ITutorialView.Stop()
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