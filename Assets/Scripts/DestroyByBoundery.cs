using UnityEngine;

public class DestroyByBoundery : MonoBehaviour {

    void OnTriggerExit(Collider other) {
        Destroy(other.gameObject);
    }

}
