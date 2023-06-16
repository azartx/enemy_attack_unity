﻿using UnityEngine;


public class SimpleTouchController : MonoBehaviour {

	// PUBLIC
	public delegate void TouchDelegate(Vector2 value);
	public event TouchDelegate TouchEvent;

	public delegate void TouchStateDelegate(bool touchPresent);
	public event TouchStateDelegate TouchStateEvent;

	// PRIVATE
	[SerializeField]
	private RectTransform joystickArea;
	private bool touchPresent = false;
	private Vector2 movementVector;


	public Vector2 GetTouchPosition => movementVector;


	public void BeginDrag()
	{
		touchPresent = true;
		TouchStateEvent?.Invoke(touchPresent);
	}

	public void EndDrag()
	{
		touchPresent = false;
		movementVector = joystickArea.anchoredPosition = Vector2.zero;

		TouchStateEvent?.Invoke(touchPresent);
	}

	public void OnValueChanged(Vector2 value)
	{
		if (!touchPresent) return;
		// convert the value between 1 0 to -1 +1
		movementVector.x = ((1 - value.x) - 0.5f) * 2f;
		movementVector.y = ((1 - value.y) - 0.5f) * 2f;

		TouchEvent?.Invoke(movementVector);
	}
}
