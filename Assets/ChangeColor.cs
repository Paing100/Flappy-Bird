using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Bird bird;
    private Sprite blueBird, redBird, yellowBird;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird")?.GetComponent<Bird>();

        blueBird = Resources.Load<Sprite>("blue-bird"); // Assuming bluebird.png is in Resources folder
        redBird = Resources.Load<Sprite>("red-bird");   // Assuming redbird.png is in Resources folder
        yellowBird = Resources.Load<Sprite>("yellow-bird"); // Assuming yellowbird.png is in Resources folder

        SetBirdColor();
    }

    void SetBirdColor()
    {
        string selectedColor = PlayerPrefs.GetString("SelectedColor", "yellow"); // Default to yellow

        switch (selectedColor)
        {
            case "Blue":
                bird.spriteR.sprite = blueBird;
                break;
            case "Red":
                bird.spriteR.sprite = redBird;
                break;
            case "Yellow":
                bird.spriteR.sprite = yellowBird;
                break;
            default:
                bird.spriteR.sprite = yellowBird;
                break;
        }
    }
}
