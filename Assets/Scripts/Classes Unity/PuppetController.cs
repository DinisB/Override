using UnityEngine;

namespace Override
{
    public class PuppetController : MonoBehaviour
    {
        [SerializeField] private string puppetName;
        [SerializeField] private int cost;
        [SerializeField] private int moneyPerSec;
        private Puppet puppet;
        private void Awake()
        {
        }
    }
}