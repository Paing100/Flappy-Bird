using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
