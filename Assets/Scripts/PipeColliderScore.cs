using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeColliderScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ++GameManager.Instance.Score;
        AudioManager.Instance.PlaySound("Point");
    }
}
