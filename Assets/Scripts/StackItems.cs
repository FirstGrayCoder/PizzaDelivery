using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StackItems : MonoBehaviour
{
    public GameObject pizzaBox;
    public Transform pizzaParent;
    [SerializeField] bool isEnterPizzaClient;
    float parentPos;
    int y = 0;
    // Start is called before the first frame update
    void Start()
    {
        isEnterPizzaClient = false;
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
            isEnterPizzaClient = true;
              StartCoroutine(WaitOneSecond());
            
        }  

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" )
        {
            isEnterPizzaClient = false;
            StopCoroutine(WaitOneSecond());
        }
    }

    public IEnumerator WaitOneSecond()
    {
        float temp = .1f;
         
        if (isEnterPizzaClient)
        {
            for (int i = 0; i < BanerRotation.banerCount; i++)
            {
                yield return new WaitForSeconds(0.2f);

                parentPos = pizzaParent.GetChild(pizzaParent.childCount-1).position.y; 
                Instantiate(pizzaBox, new Vector3(pizzaParent.position.x, parentPos + temp, pizzaParent.position.z), Quaternion.identity, pizzaParent);
                //temp += 0.1f;
            }
        }

    }
}
