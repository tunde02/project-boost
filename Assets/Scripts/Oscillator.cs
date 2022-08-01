using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] float period = 6f;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        const float tau = Mathf.PI * 2;
        float cycles = Time.time / period;
        float rawSinWave = Mathf.Sin(cycles * tau);
        float movementFactor = (rawSinWave + 1f) / 2f; // 0 ~ 1

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
