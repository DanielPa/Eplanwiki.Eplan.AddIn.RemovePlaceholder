/* 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */
 
 
using System;
using System.Collections.Generic;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.DataModel.Graphics;
using Eplan.EplApi.HEServices;

namespace Eplanwiki.Eplan.AddIn.RemovePlaceholder
{
	/// <summary>
	/// Actionname: RemovePlaceholderWithRecord
	/// Parameters: recordname
	/// Description: Removes all placeholder containing the given recordname from active project
	/// </summary>
	public class RemovePlaceholderWithRecord : IEplAction
	{
		public RemovePlaceholderWithRecord()
		{
		}
		
		public bool OnRegister(ref string Name, ref int Ordinal)
		{
			Name  = "RemovePlaceholderWithRecord";
            Ordinal     = 20;
            return true;

		}
		
		public bool Execute(ActionCallingContext oActionCallingContext)
		{		
			String recordName=null;
			oActionCallingContext.GetParameter("recordname", ref recordName);
			
			SelectionSet selectionSet = new SelectionSet();
			Project oProject = selectionSet.GetCurrentProject(true);
			oProject.LockObject();
			List<PlaceHolder> pList = new List<PlaceHolder>();
			
			
			
			foreach (Page page in oProject.Pages) {
				foreach (Placement gp in page.AllPlacements) {
					if (gp is PlaceHolder) {
						pList.Add((PlaceHolder)gp);
					}
				}
			} 
			//System.Windows.Forms.MessageBox.Show(pList.Count.ToString());
			foreach (PlaceHolder plh in pList) {
				if(plh.GetRecordNames().Contains(recordName))
				{
					plh.Remove();
				}
			}
            return true;
		}
		
		public void GetActionProperties(ref ActionProperties actionProperties)
		{
			actionProperties.Description = "Löscht alle EEC Platzhalter";
			ActionParameterProperties recordName= new ActionParameterProperties();
			recordName.Set("recordname");
        	actionProperties.AddParameter(recordName);
		}
	}
}
