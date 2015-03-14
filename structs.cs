using System;
using System.Collections;

namespace Update
{
   public struct stockinfo
   {
	  private string _symbol;
	  private DateTime _lastupdate;
	  private int _number;

	  public string Symbol { get { return _symbol; } }
	  public DateTime LastUpdate { get { return _lastupdate; } }
	  public int Number { get { return _number; } }

	  public stockinfo(string s, DateTime d, int n)
	  {
		 _symbol = s;
		 _lastupdate = d;
		 _number = n;
	  }

   }

   public struct stockdownloaded
   {
	   
	  private string _symbol;
	  private DateTime _newlastupdate;
	  private string _data;
	  private int _number;


	  public string StockSymbol { get { return _symbol; } }
	  public DateTime NewLastUpdate { get { return _newlastupdate; } }
	  public string Data { get { return _data;}}
	  public int Number { get { return _number; } }

	  public stockdownloaded(string s, DateTime d, string data, int n)
	  {
		 _symbol = s;
		 _newlastupdate = d;
		 _data = data;
		 _number = n;
	  }
   }

   public struct toDatabase
   {
	  private DateTime _newRecentDate;
	  private Stack _myStrings;
	  private string _myStockSymbol;
	  private int _number;
	  

	  public DateTime NewRecentDate { get { return _newRecentDate; }}
	  //public string[] DBaseStrings { get { return _dbasestrings; } }
	  public Stack DBaseStrings { get { return _myStrings; } }
	  public string MyStockSymbol { get { return _myStockSymbol; } }
	  public int Number { get { return _number; } }

	  public toDatabase(int n,string symb, DateTime d, Stack s)
	  {
		 _number = n;
		 _myStockSymbol = symb;
		 _newRecentDate = d;
		 _myStrings = new Stack();
		 while (s.Count > 0)
		 {
			_myStrings.Push(s.Pop());
		 }
	  }
   }
}
