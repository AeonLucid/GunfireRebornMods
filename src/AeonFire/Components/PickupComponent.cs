using AeonFire.Data;
using UnityEngine;

namespace AeonFire.Components;

internal class PickupComponent : MonoBehaviour
{
    private void FixedUpdate()
    {
        foreach (var pair in DropManager.AutoPickDict)
        {
            if (pair.value.IsCanOP)
            {
                if (pair.value.Shape == GunfireShape.DropCoin ||
                    pair.value.Shape == GunfireShape.DropMedic)
                {
                    pair.value.AutoPickRange = float.MaxValue;
                }
            }
        }
    }
}