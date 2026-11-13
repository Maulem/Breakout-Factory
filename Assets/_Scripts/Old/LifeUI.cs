using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour
{
    Text textComp;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        textComp = GetComponent<Text>();
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        textComp.text = $"Vidas: {gm.vidas}";
    }
}