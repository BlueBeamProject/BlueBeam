using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index = 0;
    public float typingSpeed;
    public GameObject continueButton;
    public Sprite[] head1;
    public Sprite[] head2;
    public AudioSource speak;
    private int countSentences = 0;
    private SpriteRenderer _mySpriteRenderer;
    public float animationSpeed;
    private int _countFrame = 0;
    private bool isTalking = true;
    public string Level1;
    private Transform _transform;
    private bool isFinish = false;

    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _transform = GetComponent<Transform>();
        StartCoroutine(Type());
    }

    void Update()
    {
        
            
        if ((textDisplay.text == sentences[index]) && !isFinish)
        {
            continueButton.SetActive(true);
        }

        if (((countSentences%2 != 0) && isTalking) && !isFinish)
        {
            Debug.Log("OK");
            _transform.position = new Vector3(transform.position.x - 642, transform.position.y, transform.position.z);
            StartCoroutine(Anim1());
            
        }
        else if ((((countSentences % 2 == 0) && isTalking)) && !isFinish)
        {
            _transform.position = new Vector3(transform.position.x + 642, transform.position.y, transform.position.z);
            StartCoroutine(Anim2());
            
        }
        

        /*if (Input.GetKey(KeyCode.Return))
        {
            NextSentence();
        }*/
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    IEnumerator Anim1()
    {
        
        isTalking = false;
        Debug.Log("OK2");
        _countFrame = 0;
        while (textDisplay.text != sentences[index])
        {
                if (_countFrame == head1.Length)
                    _countFrame = 0;

                _mySpriteRenderer.sprite = head1[_countFrame];
                _countFrame++;
                yield return new WaitForSeconds(animationSpeed);
            
            
        }
        


    }

    IEnumerator Anim2()
    {
        
        isTalking = false;
        _countFrame = 0;
        while (textDisplay.text != sentences[index])
        {
                if (_countFrame == head2.Length)
                    _countFrame = 0;

                _mySpriteRenderer.sprite = head2[_countFrame];
                _countFrame++;
                yield return new WaitForSeconds(animationSpeed);
           
            
        }
        


    }
    public void NextSentence()
    {
        if (index == sentences.Length - 1)
        {
            isFinish = true;
        }

        countSentences++;
        continueButton.SetActive(false);
 
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            _mySpriteRenderer.sprite = null;
            textDisplay.text = "";
            continueButton.SetActive(false);
            PassLvl();
        }
        isTalking = true;

        

    }

    public void PassLvl()
    {
        SceneManager.LoadScene(Level1);
    }
}
