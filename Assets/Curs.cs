using System.Collections;       
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curs : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Image image;
    int curs=100;


    public void PressButton() {
        bool UpOrDown;
        int _curs = Random.Range(0, 21);
        text.text = _curs.ToString();
        if (Random.Range(0, 2) == 1)
        {
            UpOrDown = true;
            curs += _curs;
            
        }
        else {
            UpOrDown = false;
            curs -= _curs;
            
        }
        if (UpOrDown)
        {
            image.gameObject.SetActive(true);
            image.rectTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
            image.color = Color.green;

        }
        else {
            image.gameObject.SetActive(true);
            image.rectTransform.rotation = Quaternion.Euler(0f, 0f, 180f);
            image.color = Color.red;
        }
        if (_curs==0) { 
        image.gameObject.SetActive(false);
        }

        text2.text = "1 : "+curs.ToString();
    }
  
}
