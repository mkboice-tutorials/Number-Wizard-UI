using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{

    public Text guessText;
    int max;
    int min;
    int guess;
    public int maxGuessesAllowed;

    public Text text;


    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        maxGuessesAllowed = 10;

        max = max + 1;
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessCorrect()
    {
        SceneManager.LoadScene("Win");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
