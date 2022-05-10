using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeExperience : MonoBehaviour
{
    int index = 0;

    private void Awake() {
        Experience(0);
    }

    public void Experience(int change){
        if(index == transform.childCount-1 && change == 1){
            index = 0;
        }
        else if(index == 0 && change == -1){
            index = transform.childCount -1 ;
        }
        else
        {
            index += change;
        }


        for (int i = 0; i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }
}
