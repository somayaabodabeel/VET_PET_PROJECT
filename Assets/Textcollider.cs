using UnityEngine;
using UnityEngine.UI;

public class ProximityText : MonoBehaviour
{
    public Transform Player; // تعريف المتغير Player
    public GameObject panel;
    public Text displayText;
    public float proximityDistance = 5f;

    void Start()
    {
        // تأكد من أن اللوحة معطلة عند بداية اللعبة
        panel.SetActive(false);
    }

    void Update()
    {
        // احصل على المسافة بين الكائن الحالي واللاعب أو أي شيء آخر
        float distance = Vector3.Distance(transform.position, Player.position);

        // اختبر إذا كان اللاعب قريبًا بما يكفي
        if (distance < proximityDistance)
        {
            // قم بتفعيل اللوحة وعرض النص
            panel.SetActive(true);
            displayText.enabled = true;
        }
        else
        {
            // قم بتعطيل اللوحة وإخفاء النص
            panel.SetActive(false);
            displayText.enabled = false;
        }
    }
}
