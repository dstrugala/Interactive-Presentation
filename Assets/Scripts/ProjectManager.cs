using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _clickedAction;
    [SerializeField]
    private GameObject _otherAction2;
    [SerializeField]
    private GameObject _otherAction3;
    [SerializeField]
    private GameObject _otherAction4;
    [SerializeField]
    private GameObject _otherAction5;
    [SerializeField]
    private float distance;


    private int i;

    // Start is called before the first frame update
    void Start()
    {
        _clickedAction.SetActive(false);
        _otherAction2.SetActive(false);
        _otherAction3.SetActive(false);
        _otherAction4.SetActive(false);
        _otherAction5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClicked()
    {
        _clickedAction.SetActive(true);
        _otherAction2.SetActive(false);
        _otherAction3.SetActive(false);
        _otherAction4.SetActive(false);
        _otherAction5.SetActive(false);
    }

    public void ButtonClickedAnimation()
    {
        _clickedAction.SetActive(true);
        i++;

        switch (i){
            case 0:
                _clickedAction.transform.position = new Vector2((_clickedAction.transform.position.x - distance), _clickedAction.transform.position.y);
                Debug.Log(i);
                break;
            case 1:
                _clickedAction.transform.position = new Vector2((_clickedAction.transform.position.x + distance), _clickedAction.transform.position.y);
                Debug.Log(i);
                break;
            case 2:
                i = 0;
                _clickedAction.transform.position = new Vector2((_clickedAction.transform.position.x - distance), _clickedAction.transform.position.y);
                Debug.Log(i);
                break;
            default:
                break;
        }
            

    }
}
