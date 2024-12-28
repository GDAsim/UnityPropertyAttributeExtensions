using UnityEngine;

public class StatsBarExample : MonoBehaviour
{
    public float statMax = 100;

    [StatsBar("statMax", StatsBarColor.Red)] public float health = 25;
    [StatsBar("statMax", StatsBarColor.Blue)] public float mana = 50;
    [StatsBar("statMax", StatsBarColor.Yellow)] public float strength = 90;
}
