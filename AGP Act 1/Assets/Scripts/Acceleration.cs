using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private float initialVelocity, finalVelocity, accelerationMaxSeconds;
    [SerializeField] private Rigidbody rbComponent;
    private bool flag = false;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            timer += Time.deltaTime;
            Debug.Log(timer / accelerationMaxSeconds);
            rbComponent.velocity = Vector2.Lerp(new Vector2(initialVelocity, 0), new Vector2(finalVelocity, 0), timer / accelerationMaxSeconds);
        }
        else
        {
            rbComponent.velocity = Vector2.zero;
        }
    }

    [Button]
    public void StartVelocityTravel()
    {
        flag = true;
    }

    [Button]
    public void EndVelocityTravel()
    {
        flag = false;
    }
}
