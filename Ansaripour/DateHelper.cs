//----------------------------------------------------------------------------------------
//	Copyright © 2003 - 2020 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	The methods in this class replicate the behavior of IsDate and DateDiff.
//----------------------------------------------------------------------------------------
using System;
using System.Globalization;

public static class DateHelper
{
	public static bool IsDate(object expression)
	{
		if (expression == null)
			return false;

		DateTime testDate;
		return DateTime.TryParse(expression.ToString(), out testDate);
	}

	public enum DateInterval
	{
		Day,
		DayOfYear,
		Hour,
		Minute,
		Month,
		Quarter,
		Second,
		Weekday,
		WeekOfYear,
		Year
	}

	public static long DateDiff(DateInterval intervalType, DateTime dateOne, DateTime dateTwo)
	{
		switch (intervalType)
		{
			case DateInterval.Day:
			case DateInterval.DayOfYear:
				TimeSpan spanForDays = dateTwo - dateOne;
				return (long)spanForDays.TotalDays;
			case DateInterval.Hour:
				TimeSpan spanForHours = dateTwo - dateOne;
				return (long)spanForHours.TotalHours;
			case DateInterval.Minute:
				TimeSpan spanForMinutes = dateTwo - dateOne;
				return (long)spanForMinutes.TotalMinutes;
			case DateInterval.Month:
				return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
			case DateInterval.Quarter:
				long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
				long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
				return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
			case DateInterval.Second:
				TimeSpan spanForSeconds = dateTwo - dateOne;
				return (long)spanForSeconds.TotalSeconds;
			case DateInterval.Weekday:
				TimeSpan spanForWeekdays = dateTwo - dateOne;
				return (long)(spanForWeekdays.TotalDays / 7.0);
			case DateInterval.WeekOfYear:
				DateTime dateOneModified = dateOne;
				DateTime dateTwoModified = dateTwo;
				while (dateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
				{
					dateTwoModified = dateTwoModified.AddDays(-1);
				}
				while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
				{
					dateOneModified = dateOneModified.AddDays(-1);
				}
				TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
				return (long)(spanForWeekOfYear.TotalDays / 7.0);
			case DateInterval.Year:
				return dateTwo.Year - dateOne.Year;
			default:
				return 0;
		}
	}
}