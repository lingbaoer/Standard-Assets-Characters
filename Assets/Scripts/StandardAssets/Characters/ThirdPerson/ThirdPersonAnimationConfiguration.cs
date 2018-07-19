﻿using UnityEngine;

namespace StandardAssets.Characters.ThirdPerson
{
	[CreateAssetMenu(fileName = "Third Person Animation Configuration", menuName = "Standard Assets/Characters/Create Third Person Animation Configuration", order = 1)]
	public class ThirdPersonAnimationConfiguration : ScriptableObject
	{
		[SerializeField]
		protected float floatInterpolation = 0.05f;
		
		[SerializeField]
		protected string forwardSpeedParameter = "ForwardSpeed";
		
		[SerializeField]
		protected string lateralSpeedParameter = "LateralSpeed";
		
		[SerializeField]
		protected string turningSpeedParameter = "TurningSpeed";

		[SerializeField]
		protected string verticalSpeedParameter = "VerticalSpeed";
		
		[SerializeField]
		protected string groundedParameter = "Grounded";
		
		[SerializeField]
		protected string hasInputParameter = "HasInput";
		
		[SerializeField]
		protected string fallingTimeParameter = "FallTime";
		
		[SerializeField]
		protected string footednessParameter = "OnRightFoot";
		
		[SerializeField]
		protected string jumpedParameter = "Jumped";
		
		[SerializeField]
		protected string jumpedLateralSpeedParameter = "JumpedLateralSpeed";
		
		[SerializeField]
		protected string jumpedForwardSpeedParameter = "JumpedForwardSpeed";

		[SerializeField]
		protected string predictedFallDistanceParameter = "PredictedFallDistance";
		
		[SerializeField]
		protected string rapidTurnParameter = "RapidTurn";

		[SerializeField]
		protected string isStrafingParameter = "IsStrafing";
		
		[SerializeField]
		protected bool invertFootedness;

		[SerializeField]
		protected float footednessThreshold = 0.25f, footednessThresholdOffset = 0.25f;

		public float floatInterpolationTime
		{
			get { return floatInterpolation; }
		}

		public string forwardSpeedParameterName
		{
			get { return forwardSpeedParameter; }
		}

		public string lateralSpeedParameterName
		{
			get { return lateralSpeedParameter; }
		}

		public string turningSpeedParameterName
		{
			get { return turningSpeedParameter; }
		}

		public string verticalSpeedParameterName
		{
			get { return verticalSpeedParameter; }
		}

		public string groundedParameterName
		{
			get { return groundedParameter; }
		}

		public string hasInputParameterName
		{
			get { return hasInputParameter; }
		}

		public string fallingTimeParameterName
		{
			get { return fallingTimeParameter; }
		}

		public string footednessParameterName
		{
			get { return footednessParameter; }
		}

		public string jumpedParameterName
		{
			get { return jumpedParameter; }
		}

		public string jumpedLateralSpeedParameterName
		{
			get { return jumpedLateralSpeedParameter; }
		}

		public string jumpedForwardSpeedParameterName
		{
			get { return jumpedForwardSpeedParameter; }
		}

		public string predictedFallDistanceParameterName
		{
			get { return predictedFallDistanceParameter; }
		}

		public string rapidTurnParameterName
		{
			get { return rapidTurnParameter; }
		}

		public string isStrafingParameterName
		{
			get { return isStrafingParameter; }
		}

		public bool invertFoot
		{
			get { return invertFootedness; }
		}

		public float footednessThresholdValue
		{
			get { return footednessThreshold; }
		}

		public float footednessThresholdOffsetValue
		{
			get { return footednessThresholdOffset; }
		}
	}
}