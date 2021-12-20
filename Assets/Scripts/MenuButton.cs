using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    [SerializeField]
    private GameObject _menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        _menuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuButtonClicked()
    {
        if (_menuPanel.active == true)
        {
            _menuPanel.SetActive(false);
        }
        else
        {
            _menuPanel.SetActive(true);
        }

    }

}
