using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public TMP_Text gameOverText;
    public void Setup(string text)
    {
        gameObject.SetActive(true);
        gameOverText.text = text;
    }
}
