using UnityEngine;
using System.Text;
using TMPro;

public class InputDebugger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _debugTouchStateText;

    void Update()
    {
        StringBuilder sb = new StringBuilder(100);
        sb.Append($"Touches: {Input.touchCount}\n");
        _debugTouchStateText.text = Input.touchCount.ToString();
        
        if (Input.touchCount > 0 )
        {
            foreach (var touch in Input.touches)
                sb.Append($"{touch.fingerId}: {touch.position.x}, {touch.position.y}\n");
        }

        _debugTouchStateText.text = sb.ToString();
    }
}
