using System;
using System.Collections;
using BepInEx;
using Photon.Pun;
using UnityEngine;


namespace FlatHead
{
	
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{

		void OnEnable()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				vrrig.headMesh.transform.localScale = new Vector3(1f, 0.5f, 1f);
			}
		}

		void OnDisable()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				vrrig.headMesh.transform.localScale = new Vector3(1f, 1f, 1f);
			}
		}

		void Update()
		{
			Flat();
		}

		public void Flat()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				vrrig.headMesh.transform.localScale = new Vector3(1f, 0.5f, 1f);
			}
		}
	}
}
