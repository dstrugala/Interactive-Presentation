using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GifAnimator : MonoBehaviour
{

    public Sprite[] sprites;
    public float speed;
    private Sprite srcImage;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().sprite = srcImage;
        srcImage = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Gif());
    }

    private IEnumerator Gif()
    {
        int i = 0;
        while(i < sprites.Length)
        {
            srcImage = sprites[0];
            yield return new WaitForSeconds(speed);
            i++;
        }

        if(i == sprites.Length)
        {
            i = 0;
        }
    }

}
