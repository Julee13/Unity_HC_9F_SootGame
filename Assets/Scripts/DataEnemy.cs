using UnityEngine;

namespace Julee
{
    [CreateAssetMenu(menuName = "Julee/Data Enemy")]
    public class DataEnemy : DataBasic
    {
        [Header("金幣預置物")]
        public GameObject prefabCoin;
        [Header("掉落數量"), Range(1, 100)]
        public int coinDropCount = 10;
        [Header("掉落機率"), Range(0, 1)]
        public float coinProbability = 0.8f;
    }
}