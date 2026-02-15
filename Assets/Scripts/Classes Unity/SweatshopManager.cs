using System.Collections;
using UnityEngine;

namespace Override
{
    public class SweatshopManager : MonoBehaviour
    {
        private Sweatshop sweatshop;

        private void Start()
        {
            sweatshop = new Sweatshop();
        }

        public IEnumerator MoneyCycle()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                foreach (Puppet puppet in sweatshop.Puppets)
                {
                    sweatshop.Money += puppet.MoneyPerSec;
                }
            }
        }
    }
}