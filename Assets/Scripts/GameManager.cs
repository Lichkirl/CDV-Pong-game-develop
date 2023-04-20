using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Camera m_Camera;
    [SerializeField]private Color[] color;
    int rand;
    //simple background changer
    // Start is called before the first frame update
    void Start()
    {
        m_Camera = Camera.main;
        RandomDefiner();
        
            }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RandomDefiner()
    {
        rand = Random.Range(0, color.Length);
        m_Camera.backgroundColor = color[rand];
    }

}
