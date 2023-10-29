using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;
    [SerializeField]
    private Text text;

    private int coins = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
    }

    public void AddCoin()
    {
        text.text = coins.ToString();
    }

    public int GetCoins()
    {
        return coins;
    }
}
