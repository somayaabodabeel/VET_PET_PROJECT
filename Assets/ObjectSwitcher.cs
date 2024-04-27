using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    public GameObject objectToHide;
    public GameObject objectToShow;
    private bool needleInPlace = true; // تعيين قيمة افتراضية لتحديد ما إذا كانت الإبرة في مكانها

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == objectToHide && needleInPlace) // التأكد من أن الكائن المتصادم هو الإبرة وأن الإبرة في مكانها
        {
            objectToHide.SetActive(false); // إخفاء الإبرة
            objectToShow.SetActive(true); // إظهار الكائن الآخر
            needleInPlace = false; // تعيين الإبرة بأنها غير في مكانها
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == objectToShow && !needleInPlace) // التأكد من أن الكائن المتصادم هو الكائن الآخر وأن الإبرة ليست في مكانها
        {
            objectToShow.SetActive(false); // إخفاء الكائن الآخر
            objectToHide.SetActive(true); // إظهار الإبرة
            needleInPlace = true; // تعيين الإبرة بأنها في مكانها
        }
    }
}
