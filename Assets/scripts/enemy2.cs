using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float contador;
    public float limite;
    public float max;
    public float min;
    void Awake()
    {
       
    }

    void Update()
    {
        if( contador > limite)
        {  
            float position = Random.Range(min, max);
            Instantiate(prefabEnemy, new Vector2(position,transform.position.y), transform.rotation);
            contador = 0;
            
        }
        contador = contador + Time.deltaTime;
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
