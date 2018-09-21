
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;


using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace HBRS
{
	sealed class Module1
	{
		public static OleDbConnection con = new OleDbConnection("Provider=MICROSOFT.ACE.OLEDB.12.0; Data Source=|DataDirectory|/database.accdb");
		public static OleDbDataAdapter rs = new OleDbDataAdapter();
		
		static public string SafeSqlLiteral(object strValue, object intLevel)
		{
			

			if (!Information.IsDBNull(strValue))
			{
				if (System.Convert.ToInt32(intLevel) > 0 )
				{
					strValue = Strings.Replace(strValue.ToString(), "\'", "\'\'", 1, -1, (Microsoft.VisualBasic.CompareMethod) 0); // Most important one! This line alone can prevent most injection attacks
					strValue = Strings.Replace(strValue.ToString(), "--", "", 1, -1, (Microsoft.VisualBasic.CompareMethod) 0);
					strValue = Strings.Replace(strValue.ToString(), "[", "[[]", 1, -1, (Microsoft.VisualBasic.CompareMethod) 0);
					strValue = Strings.Replace(strValue.ToString(), "%", "[%]", 1, -1, (Microsoft.VisualBasic.CompareMethod) 0);
				}
				
				if (System.Convert.ToInt32(intLevel) > 1 )
				{
					Array myArray = default(Array);
					myArray = "xp_ ;update ;insert ;select ;drop ;alter ;create ;rename ;delete ;replace ".Split(';');
					int i = default(int);
					int i2 = default(int);
					int intLenghtLeft = default(int);
					for (i = 0; i <= (myArray.Length - 1); i++)
					{
						Regex rx = new Regex(System.Convert.ToString(myArray.GetValue(i)), (System.Text.RegularExpressions.RegexOptions) (RegexOptions.Compiled | RegexOptions.IgnoreCase));
						MatchCollection matches = rx.Matches(strValue.ToString());
						i2 = 0;
						foreach (Match match in matches)
						{
							GroupCollection groups = match.Groups;
							intLenghtLeft = System.Convert.ToInt32(groups[0].Index + Strings.Len(myArray.GetValue(i)) + i2);
							strValue = Strings.Left(strValue.ToString(), intLenghtLeft - 1) + "&nbsp;" + Strings.Right(strValue.ToString(), Strings.Len(strValue) - intLenghtLeft);
							i2 += 5;
						}
					}
				}
				
				//strValue = replace(strValue, ";", ";&nbsp;")
				//strValue = replace(strValue, "_", "[_]")
				
				return System.Convert.ToString( strValue);
			}
			else
			{
				return System.Convert.ToString( strValue);
			}
			
		}
		
		
	}
	
}
