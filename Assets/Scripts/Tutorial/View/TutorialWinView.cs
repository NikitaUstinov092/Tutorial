using TMPro;
using UnityEngine;
using Zenject;

namespace StandScene.Tutorial.View
{
    public class TutorialWinView: MonoBehaviour, ITutorialView
    {
        [SerializeField] private GameObject _popup;
        
        [SerializeField] private TextMeshProUGUI _name;
        
        [Inject] private IWinLaboratoryWorkPm _pm;
        void ITutorialView.Start()
        {
            _pm.OnModelStateChanged += Show;
        }

        void ITutorialView.Stop()
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