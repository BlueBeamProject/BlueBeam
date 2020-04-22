using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagAnim : MonoBehaviour
{
    public Sprite[] frames;
    public GameObject level;
    private Transform _myTransform;
    private Transform _transformLevel;
    private SpriteRenderer _mySpriteRenderer;
    private int _countFrame;
    private bool _activated;
    private bool _down;

    // Start is called before the first frame update
    void Start()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        _myTransform = GetComponent<Transform>();
        _transformLevel = level.GetComponent<Transform>();

        if (SaveData.ReadValueInt("Checkpoint1") == 0)
        {
          _activated = false;
          _countFrame = 0;

        }
        else
        {
          _activated = true;
          _countFrame = 4;
          _transformLevel.position = _myTransform.position + new Vector3(15, 15, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _mySpriteRenderer.sprite = frames[_countFrame];
        if (_countFrame < 4 && _activated)
          _countFrame++;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          SaveData.WriteValueInt("Checkpoint1", 1);
          _activated = true;
        }
    }
}
