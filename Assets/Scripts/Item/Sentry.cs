﻿using UnityEngine;
using UnityEngine.Events;

namespace Gashapon.Item
{
    public class Sentry : MonoBehaviour
    {
        public void Start()
        {
            GetComponent<Interractible>().SetCallback(new UnityAction(Fire));
        }

        private void Fire()
        {
            Debug.Log("Firing");
        }
    }
}
