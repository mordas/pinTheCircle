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
    private GameObject[] _gameNeedles;
    private float _needleDistance = .5f;
    private int _needleIndex;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        GetButton();
    }
    void Start() {
CreateNeedles();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GetButton()
    {
        _shootBtn = GameObject.Find("ShootButton").GetComponent<Button>();
        _shootBtn.onClick.AddListener(() => ShootTheNeedle());
    }

    void CreateNeedles(){
_gameNeedles = new GameObject[_howManyNeedles];
Vector3 temp = transform.position;
for( int i = 0; i< _gameNeedles.Length; i++){
   _gameNeedles[i] = Instantiate(_needle, temp, Quaternion.identity) as GameObject;
    temp.y -= _needleDistance;
}
    }
    public void InstatnitateNeedle(){
    Instantiate(_needle, transform.position, Quaternion.identity);
    }

    public void ShootTheNeedle()
    {
        _gameNeedles[_needleIndex].GetComponent<NeedleMovement>().FireTheNeedle();
        _needleIndex++;
        if(_needleIndex == _gameNeedles.Length){
            Debug.Log("Finish");
            _shootBtn.onClick.RemoveAllListeners();
        }
    }
}
