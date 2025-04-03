using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / 5;
        meshRenderer.material.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
