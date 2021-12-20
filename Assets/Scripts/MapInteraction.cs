using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInteraction : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _maps;
    [SerializeField]
    private GameObject _plusButton;
    [SerializeField]
    private GameObject _minusButton;


    public int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        _maps[0].SetActive(true);
        _plusButton.SetActive(true);
        _minusButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (i)
        {
            case 0:
                _maps[0].SetActive(true);
                _maps[1].SetActive(false);
                _maps[2].SetActive(false);
                _plusButton.SetActive(true);
                _minusButton.SetActive(false);
                break;
            case 1:
                _maps[1].SetActive(true);
                _maps[0].SetActive(false);
                _maps[2].SetActive(false);
                _plusButton.SetActive(true);
                _minusButton.SetActive(true);
                break;
            case 2:
                _maps[2].SetActive(true);
                _maps[0].SetActive(false);
                _maps[1].SetActive(false);
                _plusButton.SetActive(false);
                _minusButton.SetActive(true);
                break;
            default:
                break;
        }
    }

    public void Plus()
    {
        i++;
        Debug.Log(i);
    }

    public void Minus()
    {
        i--;
        Debug.Log(i);
    }
}
