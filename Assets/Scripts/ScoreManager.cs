using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private Text _scoreText;
    private int _score = 0;
    // Start is called before the first frame update
    void Awake()
    {
       _scoreText = GameObject.Find("ScoreText").GetComponent<Text>() ;
       if(instance == null){
           instance = this;
       }
    }
    public void SetScore(){
        _score++;
        _scoreText.text = _score.ToString();
    }

}
