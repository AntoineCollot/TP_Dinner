using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    ParticleSystem particles;
    GameManager gameManager;
    [Min(0)] public int pointsOnGoal = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        particles = GetComponentInChildren<ParticleSystem>();
    }
}
