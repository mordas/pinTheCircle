using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private Button _shootBtn;
    [SerializeField] private GameObject _needle;
    [SerializeField] private int _howManyNeedles;
    private GameObject[] _needles;
    private float _needleDistance = 1.5f;
    private int _needleIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
