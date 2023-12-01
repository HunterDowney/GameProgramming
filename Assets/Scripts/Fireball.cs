using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public GameObject fireball;
    public Transform fireballPos;

    private float timer;
    private GameObject player;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < 40)
        {
            timer += Time.deltaTime;
            if (timer > 5)
            {
                timer = 0;
                
                shoot();
            }
        }

    }

    void shoot()
    {
        Instantiate(fireball, fireballPos.position, fireballPos.rotation);
    }
}
