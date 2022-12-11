using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnstackItems : MonoBehaviour
{
    public Transform pizzaParent;
    // Start is called before the first frame update
    void Start()
    {
        pizzaParent = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == "Player")
        {
            //Destroy(pizzaParent.GetChild(3).gameObject);
            Debug.Log(ClientBannerRotation.clientBanerCount);
            //isEnterPizzaClient = true;
            StartCoroutine(WaitOneSecond());

        }

    }

    public IEnumerator WaitOneSecond()
    {
            for (int i = ClientBannerRotation.clientBanerCount; i > 0; i--)
            {
                yield return new WaitForSeconds(0.2f);
                if (pizzaParent.childCount>1)
                {
                    Destroy(pizzaParent.GetChild(pizzaParent.childCount-1).gameObject);
                    
                }
                
            }
        if (ClientBannerRotation.clientBanerCount > pizzaParent.childCount - 1)
        {
            Time.timeScale = 0;
        }
    }
}
