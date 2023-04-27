using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float topEdge;

    private void Start() {
        topEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y + 1f;
    }

    public void Update()
    {
        transform.position += Vector3.up * GameManager.Instance.gameSpeed * Time.deltaTime;

          
    }
}
