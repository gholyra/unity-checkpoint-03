using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform playerTransform;

    [Header("Player Variables")]
    [SerializeField] private float velocity;

    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * velocity * Time.deltaTime;
        float moveY = Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime;
        playerTransform.Translate(new Vector3(moveX, moveY));
    }

}
