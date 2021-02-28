using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Transform CamTransform;
    private float shakedur = 1f, shakeAmount = 0.25f, decreaseFactor = 1.5f;
    private Transform Death;
    Vector3 newpos = new Vector3(0, 29, -47);

    private Vector3 originPos;

    private void Start()
    {
        CamTransform = GetComponent<Transform>();
        originPos = CamTransform.localPosition;
        Death = GetComponent<Transform>();
    }

    private void Update()
    {
     
        if (shakedur > 0)
        {

            CamTransform.localPosition = Camera.main.transform.localPosition + Random.insideUnitSphere * shakeAmount;
            shakedur -= Time.deltaTime * decreaseFactor;
            Camera.main.transform.localPosition = Vector3.MoveTowards(Camera.main.transform.localPosition, newpos, Time.deltaTime * 60f);

        }
        else
        {
            shakedur = 0;
            CamTransform.localPosition = newpos;                     
        }
       
    }
}
