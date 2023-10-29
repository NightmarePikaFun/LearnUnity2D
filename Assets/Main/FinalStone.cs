using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalStone : MonoBehaviour
{
    [SerializeField]
    public GameObject winCanvas;

    private bool canInteract = false;
    private int maxCoinsOnLvl;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxCoinsOnLvl = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E)&& canInteract)
        {
            if(maxCoinsOnLvl == player.GetComponent<Player>().GetCoins())
            {
                winCanvas.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("+");
            canInteract = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canInteract = false;
        }
    }
}
