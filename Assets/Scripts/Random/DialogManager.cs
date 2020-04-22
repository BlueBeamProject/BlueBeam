using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    private GameObject pauseUI;
    private PauseMenu _pauseMenu;

    void Start()
    {
        _pauseMenu = pauseUI.GetComponent<PauseMenu>();
        PauseMenu.gameIsPaused = false;
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {
        PauseMenu.gameIsPaused = false;
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
