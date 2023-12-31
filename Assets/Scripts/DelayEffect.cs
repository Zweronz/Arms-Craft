using UnityEngine;

public class DelayEffect : MonoBehaviour
{
	public FPSController fpsController;

	public float amount = 0.02f;

	public float maxAmount = 0.03f;

	public float smooth = 3f;

	private Vector3 def;

	private void Start()
	{
		def = base.transform.localPosition;
	}

	private void Update()
	{
		float num = (0f - fpsController.InputX) * amount;
		float num2 = (0f - fpsController.InputY) * amount;
		if (num > maxAmount)
		{
			num = maxAmount;
		}
		if (num < 0f - maxAmount)
		{
			num = 0f - maxAmount;
		}
		if (num2 > maxAmount)
		{
			num2 = maxAmount;
		}
		if (num2 < 0f - maxAmount)
		{
			num2 = 0f - maxAmount;
		}
		Vector3 to = new Vector3(def.x + num, def.y + num2, def.z);
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, to, Time.deltaTime * smooth);
	}
}
