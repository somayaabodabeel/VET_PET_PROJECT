using UnityEngine;

public class Consumable : MonoBehaviour
{
    [SerializeField] GameObject[] portions;
    [SerializeField] int index = 0;

    public bool IsFinished => index == portions.Length;

    void Start()
    {
        SetVisuals();
    }

    void OnValidate()
    {
        SetVisuals();
    }

    [ContextMenu("Consume")]
    public void Consume()
    {
        if (!IsFinished)
        {
            index++;
            SetVisuals();
            // يمكنك هنا إضافة أي شيء آخر ترغب في تنفيذه عند الاستهلاك
        }
    }

    void SetVisuals()
    {
        for (int i = 0; i < portions.Length; i++)
        {
            portions[i].SetActive(i == index);
        }
    }
}
