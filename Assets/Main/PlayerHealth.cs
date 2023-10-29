using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;

    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        healthText.text = currentHealth.ToString();
    }

    // Update is called once per frame

    public void RemoveHealth(int value)
    {
        currentHealth-= value;
        healthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void AddHealth(int value)
    {
        currentHealth += value;
        healthText.text = currentHealth.ToString();
        if (currentHealth>health)
        {
            currentHealth = health;
        }
    }
}
