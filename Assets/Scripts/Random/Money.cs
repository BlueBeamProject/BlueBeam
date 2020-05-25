using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 _movement;
    private Transform _transform;
    public static int money;
    public Text moneyText;
    public static bool die;
    // Start is called before the first frame update
    void Start()
    {
        die = false;
        _movement = new Vector3(moveSpeed, 0, 0);
        _transform = GetComponent<Transform>();
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!die)
            _transform.position += _movement * Time.deltaTime * moveSpeed;
        else
            _transform.position += _movement * Time.deltaTime * (moveSpeed / 10 * (-1));
        moneyText.text = money.ToString();
    }

    public static void Add()
    {
        money += 1;
    }

    public static void Death()
    {
        die = true;
        SaveData.Save();
    }
}
