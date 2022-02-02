using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifAnimator : MonoBehaviour
{

    public Sprite[] sprites;
    public float speed = 2f;
    public int i;
    public bool isEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(isEnabled == false)
        {
            StartCoroutine(Gif());
        }

        
    }

    private IEnumerator Gif()
    {
        Debug.Log("odpalam!");
        i = 0;

        isEnabled = true;

        while(i < sprites.Length)
        {
            this.GetComponent<Image>().sprite = sprites[i];
            yield return new WaitForSeconds(speed);
            Debug.Log(i);
            i++;
        }

        isEnabled = false;





        /*
        for(i = 0; i < sprites.Length; i++)
        {
            this.GetComponent<Image>().sprite = sprites[i];
            yield return new WaitForSeconds(speed);
            Debug.Log(i);
        }

        i = 0;*/


    }

}
