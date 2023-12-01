using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyFireballScript : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;

    public float force;
    private float timer;
    public GameManagerScript gameManager;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        if (player.transform.position.y <= -15)
        {
            player.transform.position = new Vector2(-16.57f, -0.12f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 15)
        {
            Destroy(gameObject);
        }



    }

    private void OnTriggerEnter2D(Collider2D other) {


        if (other.gameObject.CompareTag("Player"))
        {
            
            player.transform.position = new Vector2(-16.57f, -0.12f);

        }

        if (player.transform.position.y <= -15)
        {
            player.transform.position = new Vector2(-16.57f, -0.12f);
        }



        if (player.transform.position.x >= 390)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
