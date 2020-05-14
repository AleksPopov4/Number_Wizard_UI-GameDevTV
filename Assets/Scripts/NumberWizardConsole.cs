using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class NumberWizardConsole : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] private TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        min++;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        max--;
        NextGuess();
    }
}
