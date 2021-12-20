using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<Image> images;
    Color c;
    public int length;
    public Text tekst;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Image image in images)
        {
            image.GetComponent<Image>().color = c;
            c.r = 255f;
            c.g = 255f;
            c.b = 255f;
            c.a = 0;
            image.GetComponent<Image>().color = c;
            
        }

        tekst.GetComponent<Text>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (Image image in images)
        {
            image.GetComponent<Image>().color = c;
            c.a = 1;
            image.GetComponent<Image>().color = c;
        }

        tekst.GetComponent<Text>().color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        foreach (Image image in images)
        {
            image.GetComponent<Image>().color = c;
            c.a = 0;
            image.GetComponent<Image>().color = c;
        }

        tekst.GetComponent<Text>().color = Color.black;
    }

}