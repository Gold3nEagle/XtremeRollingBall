using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float collectibleXRotation, collectibleYRotation, collectibleZRotation;
    ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        gameObject.transform.Rotate(new Vector3(collectibleXRotation, collectibleYRotation, collectibleZRotation));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            scoreManager.CollectCollectible();
        }
    }


}
