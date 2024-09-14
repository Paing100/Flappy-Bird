using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorSelector : MonoBehaviour
{
    public void SelectColor(string color)
    {
        PlayerPrefs.SetString("SelectedColor", color);
        SceneManager.LoadScene("SampleScene"); // Replace with the name of your gameplay scene
    }
}
