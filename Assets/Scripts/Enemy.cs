using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(){
        
            Destroy(gameObject);
        
        
    }

      protected void OnTriggerEnter2D(Collider2D collider){

         Player player = collider.GetComponent<Player>();
         if(player != null){
            Debug.Log("Golpe");
            player.Hit();
            }
    }
}
