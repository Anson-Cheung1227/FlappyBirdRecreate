using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _force = 0;
    [SerializeField] private LayerMask _pipeLayer;
    [SerializeField] private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Main"));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidbody2D.velocity = Vector2.up * _force;
            AudioManager.Instance.PlaySound("Wing");
        }

        if (_rigidbody2D.velocity.magnitude > _force)
        {
            _rigidbody2D.velocity = Vector2.ClampMagnitude(_rigidbody2D.velocity, _force);
        }
        _animator.SetFloat("Velocity", _rigidbody2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (1 << other.gameObject.layer == _pipeLayer && enabled)
        {
            GameManager.Instance.InvokeDeathState();
            this.enabled = false;
        }
    }
}
