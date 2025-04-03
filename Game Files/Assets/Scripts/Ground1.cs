using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground1 : MonoBehaviour
{
    private MeshRenderer meshrend;

    private void Awake()
    {
        meshrend = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / 10;
        meshrend.material.mainTextureOffset += Vector2.left * speed * Time.deltaTime;
    }
}
