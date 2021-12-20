using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject _clickedAction;
    [SerializeField]
    private GameObject[] _otherActions;
    [SerializeField]
    private GameObject _menuPanel;


    // Start is called before the first frame update
    void Start()
    {
        _clickedAction.SetActive(false);
        foreach (GameObject _otherObject in _otherActions)
        {
            _otherObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buttonClicked()
    {
        _menuPanel.SetActive(false);

        _clickedAction.SetActive(true);
        foreach (GameObject _otherObject in _otherActions)
        {
            _otherObject.SetActive(false);
        }
        Debug.Log("Klikniête");
    }
}
