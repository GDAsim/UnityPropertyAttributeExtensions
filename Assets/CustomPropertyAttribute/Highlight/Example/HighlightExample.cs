using UnityEngine;

public partial class HighlightExample : MonoBehaviour
{
    [Highlight(HighlightColor.Red)]
    [SerializeField] int a;

    [Highlight(HighlightColor.Green, "isNegativeb")]
    [SerializeField] int b;
}


#if UNITY_EDITOR
public partial class HighlightExample
{
    bool isNegativeb(object _)
    {
        return b > 0;
    }
}
#endif