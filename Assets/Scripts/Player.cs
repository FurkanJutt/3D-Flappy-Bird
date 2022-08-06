using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private Gamemanager gamemanager;
    [SerializeField] AudioClip deathSound, flapSound;

    private Rigidbody _rigidbody;
    private Animator _animator;
    private AudioSource _audioSource;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidbody.velocity = Vector3.up * jumpForce;
            _animator.SetBool("Flying", true);
            _audioSource.clip = flapSound;
            _audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gamemanager.GameOver();
        _audioSource.clip = deathSound;
        _audioSource.Play();
    }
}
