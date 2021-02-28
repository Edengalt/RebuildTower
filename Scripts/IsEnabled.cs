using UnityEngine;

public class IsEnabled : MonoBehaviour
{
    public int needToUnlock;
    public Material blackMAt;

    private void Start()
    {
        if (PlayerPrefs.GetInt("score") < needToUnlock)
            GetComponent<MeshRenderer>().material = blackMAt;
    }

}
