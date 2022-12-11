using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    [SerializeField] private float _speed;
    private MovingCar _movingCar;
    // Start is called before the first frame update
    void Start()
    {
        _movingCar = GetComponent<MovingCar>();
        _speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        _speed = Random.Range(1, 6);
        _movingCar.transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
