using UnityEngine;

public class AutoObjectSwitch : MonoBehaviour

{
    public GameObject[] UIObjects; // مصفوفة تحتوي على جميع الواجهات

    private void Start()
    {
        ShowUI("Magnifier"); // عرض واجهة Magnifier عند بدء التطبيق
    }

    public void ShowUI(string uiName)
    {
        foreach (GameObject uiObject in UIObjects)
        {
            // إظهار الواجهة إذا كانت تطابق الاسم المعطى وإخفاءها إذا كانت لا تطابق
            uiObject.SetActive(uiObject.name == uiName);
        }
    }

    public void OnPointerClick(string nextUI)
    {
        // عرض الواجهة التالية عندما يتم النقر عليها
        ShowUI(nextUI);
    }
}

