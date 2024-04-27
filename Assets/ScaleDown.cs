using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDown : MonoBehaviour
{
    // Start is called before the first frame update
    void ScaleToExample()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0f, "y", 0f, "z", 0f, "time", 20f));
    }

    // Update is called once per frame
    void Update()
    {
        ScaleToExample();
    }
}
