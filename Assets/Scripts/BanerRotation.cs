using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BanerRotation : MonoBehaviour
{
    [SerializeField] private TMP_Text bannerText;
    public static int banerCount;

    // Start is called before the first frame update
    void Start()
    {
        banerCount = Random.Range(0, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, 1f, 0f);
        bannerText.text = banerCount.ToString();
    }
}
