using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score { get; private set; }
    [Header("UI")]
    public TextMeshProUGUI scoreText;

    void Awake()
    {

    }

    private void Update()
    {

    }
}
