using System;

/// <summary>
/// Program name : Update
/// </summary>
namespace Update
{
   internal class LastOpenExchangeDate
   {
	  /// <summary>
	  /// The lastopen is the last day the stock market was open
	  ///
	  /// </summary>
	  private DateTime lastopen;

	  public DateTime Lastopen
	  {
		 get { return lastopen; }
	  }

	  public LastOpenExchangeDate(DateTime current)
	  {
		 lastopen = current;
		 SetMostRecent();
	  }

	  public void SetMostRecent()
	  {
		 if (lastopen.Hour < 16)
		 {
			lastopen = lastopen.AddDays(-1);
		 }
		 while (!Open())
		 {
			lastopen = lastopen.AddDays(-1);
		 }
	  }

	  private bool Open()
	  {
		 if (lastopen.DayOfWeek == DayOfWeek.Sunday) return false;
		 if (lastopen.DayOfWeek == DayOfWeek.Saturday) return false;
		 if (isNewYears())
		 {
			return false;
		 }

		 if (isMartinKing())
		 {
			return false;
		 }

		 if (isPresidents())
		 {
			return false;
		 }

		 if (isGoodFriday())
		 {
			return false;
		 }

		 if (isMemorialDay())
		 {
			return false;
		 }

		 if (isJuly4())
		 {
			return false;
		 }

		 if (isLaborDay())
		 {
			return false;
		 }

		 if (isThanksgiving())
		 {
			return false;
		 }

		 if (isChristmas())
		 {
			return false;
		 }

		 return true;
	  }

	  private bool isChristmas()
	  {
		 if (lastopen.Month == 12)
		 {
			int date = lastopen.Day;

			if (date == 25)
			{
			   return true;
			}

			if ((date == 24) && (lastopen.DayOfWeek == DayOfWeek.Friday))
			{
			   return true;
			}

			if ((date == 26) && (lastopen.DayOfWeek == DayOfWeek.Monday))
			{
			   return true;
			}
		 }

		 return false;
	  }

	  private bool isThanksgiving()
	  {
		 if (lastopen.Month == 11)
		 {
			if (lastopen.DayOfWeek == DayOfWeek.Thursday)
			{
			   int date = lastopen.Day;

			   if ((date > 21) && (date < 29))
			   {
				  return true;
			   }
			}
		 }

		 return false;
	  }

	  private bool isLaborDay()
	  {
		 if (lastopen.Month == 9)
		 {
			if (lastopen.Day < 8)
			   if (lastopen.DayOfWeek == DayOfWeek.Monday) return true;
		 }
		 return false;
	  }

	  private bool isJuly4()
	  {
		 if (lastopen.Month == 7)
		 {
			if (lastopen.Day == 4) return true;
			if (lastopen.DayOfWeek == DayOfWeek.Monday && lastopen.Day == 5) return true;
			if (lastopen.DayOfWeek == DayOfWeek.Friday && lastopen.Day == 3) return true;
		 }
		 return false;
	  }

	  private bool isMemorialDay()
	  {
		 if (lastopen.Month == 5)
		 {
			if (lastopen.DayOfWeek == DayOfWeek.Monday)
			{
			   if (lastopen.Day > 24) return true;
			}
		 }
		 return false;
	  }

	  private bool isGoodFriday()
	  {
		 if ((lastopen.Month == 3 && lastopen.Day >= 21) || lastopen.Month == 4)
		 {
			int y = lastopen.Year;

			// trying to use Hodge's method for calculating Easter Sunday and then subtract 1 days.
			int a, b, c, d, e, f, g, h, j, k, m, n, p, dy, mth;
			a = y / 100;
			b = y % 100;
			c = (3 * (a + 25)) / 4;
			d = (3 * (a + 25)) % 4;
			e = (8 * (a + 11)) / 25;
			f = (5 * a + b) % 19;
			g = (19 * f + c - e) % 30;
			h = (f + 11 * g) / 319;
			j = (60 * (5 - d) + b) / 4;
			k = (60 * (5 - d) + b) % 4;
			m = (2 * j - k - g + h) % 7;
			n = (g - h + m + 114) / 31;
			p = (g - h + m + 114) % 31;
			dy = p + 1;
			mth = n;

			DateTime easter = new DateTime(lastopen.Year, mth, dy);
			DateTime goodFriday = easter.AddDays(-2);
			if (lastopen.Month == goodFriday.Month && lastopen.Day == goodFriday.Day) return true;

			return false;

			//  * 'Easter Sunday is g - h + m days after March 22nd
			//'(the earliest possible Easter date)
			// */
			//Console.WriteLine("{0} Easter is {1}-{2}", lastopen.Year, mth, dy);
			//Console.WriteLine("Days after 3-22: {0}", g - h + m);
		 }

		 return false;
	  }

	  private bool isPresidents()
	  {
		 if (lastopen.Month == 2)
		 {
			if (lastopen.DayOfWeek == DayOfWeek.Monday)
			{
			   int date = lastopen.Day;
			   if (date > 14 && date < 22) return true;
			}
		 }
		 return false;
	  }

	  private bool isMartinKing()
	  {
		 if (lastopen.Month == 1)
		 {
			if (lastopen.DayOfWeek == DayOfWeek.Monday)
			{
			   int date = lastopen.Day;
			   if (date > 14 && date < 22) return true;
			}
		 }
		 return false;
	  }

	  private bool isNewYears()
	  {
		 if (lastopen.Month == 1 && lastopen.Day == 1) return true;
		 return false;
	  }
   }
}