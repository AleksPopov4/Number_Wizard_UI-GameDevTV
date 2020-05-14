using TMPro;
using UnityEngine;

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
        guess = (max + min) / 2;

        guessText.text = guess.ToString();
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
}
