using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Ball : MonoBehaviour
{
    [SerializeField] private float distance, time;
    [SerializeField] private Rigidbody rb;
    private float speed;
    private float actualTime;
    private bool isStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            actualTime += Time.deltaTime;
            if (actualTime / time < .99f)
            {
                rb.velocity = speed * Vector2.right;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

    [Button]
    public void StartSpeed()
    {
        speed = distance / time;
        actualTime = 0;
        isStart = true;
    }
}
