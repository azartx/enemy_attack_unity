using UnityEngine;
using UnityEngine.UI;

public class InfoTouches : MonoBehaviour { // todo make debug only

	private Text text;
	
	public SimpleTouchController rightController;

	void Start()
	{
		text = gameObject.GetComponent<Text>();
	}

	void Update()
	{
		text.text = "Right Touch:\n" +
		            "x: " + rightController.GetTouchPosition.x + "\n" +
		            "y: " + rightController.GetTouchPosition.y;
	}
}
