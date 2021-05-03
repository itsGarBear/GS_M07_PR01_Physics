﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterBallGame : MonoBehaviour
{
    public Transform shootAt;
    public Transform shooter0;
    public float speed = 15.0f;
    public float interval = 3.0f;
    private float nextBallTime = 0f;
    private ObjectPooler pool;
    private AudioSource soundEffect;
    private int shooterId;

    // Start is called before the first frame update
    void Start()
    {
        if (shootAt == null)
            shootAt = Camera.main.transform;

        soundEffect = GetComponent<AudioSource>();
        if (soundEffect == null)
            Debug.LogError("Requires AudioSource component");

        pool = GetComponent<ObjectPooler>();
        if (pool == null)
            Debug.LogError("Requires ObjectPooler component");

        if (shooter0 == null)
            Debug.LogError("Requires shooter transforms");

        Time.fixedDeltaTime = 0.001f;

        ShootBall(shooter0);
        nextBallTime = Time.time + interval;
    }
    void Update()
    {
        if (Time.time > nextBallTime)
        {
            ShootBall(shooter0);
            nextBallTime = Time.time + interval;
        }
    }

    private void ShootBall(Transform shooter)
    {
        GameObject ball = pool.GetPooledObject();
        if (ball != null)
        {
            ball.transform.position = shooter.position;
            ball.transform.rotation = Quaternion.identity;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.angularVelocity = Vector3.zero;
            shooter.transform.LookAt(shootAt);
            rb.velocity = shooter.forward * speed;
            ball.SetActive(true);
            soundEffect.Play();
            rb.useGravity = false;
        }
    }
}
