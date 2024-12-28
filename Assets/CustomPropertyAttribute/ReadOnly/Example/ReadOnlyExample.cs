using UnityEngine;

public class ReadOnlyExample : MonoBehaviour
{
    [ReadOnly]
    [SerializeField] bool readonlybool;

    [ReadOnlyWhenPlaying]
    [SerializeField] bool readonlywhenplayingbool;
}