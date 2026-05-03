using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRB;
    private GameObject player;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        enemyRB.AddForce( (player.transform.position - transform.position).normalized * speed );
    }
}