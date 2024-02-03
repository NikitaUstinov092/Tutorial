using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartTutor : MonoBehaviour
{
    public void PressButton()
    {
        PlayerPrefs.SetInt("LabWork", 0);
        SceneManager.LoadSceneAsync(0);
    }
}
