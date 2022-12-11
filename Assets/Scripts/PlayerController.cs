using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TMP_Text countText;
    [SerializeField] private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //countText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "Your pizzas: " + (player.childCount-1).ToString();
    }
}
