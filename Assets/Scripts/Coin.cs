using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 100 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            PlayerManager.numberOfFruits +=1; 
            ScoreManager.collectedFruitsCount+=1;
            Destroy(gameObject);
        }
        
    }

}
