using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClientBannerRotation : MonoBehaviour
{
    [SerializeField] private TMP_Text bannerText;
    public static int clientBanerCount;

    // Start is called before the first frame update
    void Start()
    {
        clientBanerCount = Random.Range(0, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, 1f, 0f);
        bannerText.text = clientBanerCount.ToString();
    }
}

