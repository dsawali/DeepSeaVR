using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TorpedoFireButton : MonoBehaviour, IPointerDownHandler {

    public SubmarineController subController;

    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData pointerData) {
        subController.FireTorpedo();
    }

}
