/* 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */


using System;
using Eplan.EplApi.ApplicationFramework;

namespace Eplanwiki.Eplan.AddIn.RemovePlaceholder
{
	/// <summary>
	/// Class for managing the add-in
	/// </summary>
	public class AddInModule : IEplAddIn
	{
		public bool OnRegister(ref System.Boolean bLoadOnStart)
		{
			bLoadOnStart = true;
			return true;
		}
		
		public bool OnUnregister()
		{
			return true;
		}
		
		public bool OnInit()
		{
			return true;
		}
		
		public bool OnInitGui()
		{
			return true;			
		}
		
		public bool OnExit()
		{
			return true;
		}
	}
}