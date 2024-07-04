using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeController : MonoBehaviour
{
    [SerializeField] private int _minY, _maxY, _speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(9, Random.Range(_minY, _maxY));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        if (transform.position.x < -9)
        {
            Destroy(gameObject);
        }
    }
}
