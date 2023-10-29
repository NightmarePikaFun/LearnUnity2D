using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject fireballPrefab;
    [SerializeField]
    private int speed = 20;
    [SerializeField]
    private int cd = 2;

    private bool canActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.F) && canActive)
        {
            GameObject fireball = Instantiate(fireballPrefab);
            fireball.transform.position = transform.position;
            Rigidbody2D fireballRB = fireball.GetComponent<Rigidbody2D>();
            if(x!=0)
            {
                fireballRB.AddForce(new Vector3(speed*Rough(x), 0, 0));
            }
            else if(y!=0) 
            {
                fireballRB.AddForce(new Vector3 (0,speed*Rough(y),0));
            }
            else
            {
                fireballRB.AddForce(new Vector3(0, -speed, 0));
            }
            canActive = false;
            Invoke("Recharging", cd);
        }
    }

    private void Recharging()
    {
        canActive = true;
    }

    private float Rough(float value)
    {
        float retValue = 0;
        if (value < 0)
            retValue = -1;
        else
            retValue = 1;
        return retValue;
    }
}
