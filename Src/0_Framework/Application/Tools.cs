﻿using System;
using System.Globalization;

namespace _0_Framework.Application
{
    public static class Tools
    {
        public static string[] MonthNames =
            {"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"};

        public static string[] DayNames = {"شنبه", "یکشنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه"};
        public static string[] DayNamesG = {"یکشنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه", "شنبه"};


        public static string ToFarsi(this DateTime? date)
        {
            try
            {
                if (date != null) return date.Value.ToFarsi();
            }
            catch (Exception)
            {
                return "";
            }

            return "";
        }

        public static string ToFarsi(this DateTime date)
        {
            if (date == new DateTime()) return "";
            var pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
        

        public static string ToDiscountFormat(this DateTime date)
        {
            if (date == new DateTime()) return "";
            return $"{date.Year}/{date.Month}/{date.Day}";
        }

        public static string GetTime(this DateTime date)
        {
            return $"_{date.Hour:00}_{date.Minute:00}_{date.Second:00}";
        }

        public static string ToFarsiFull(this DateTime date)
        {
            var pc = new PersianCalendar();
            return
                $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00} {date.Hour:00}:{date.Minute:00}:{date.Second:00}";
        }

        private static readonly string[] Pn = {"۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹"};
        private static readonly string[] En = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        public static string ToEnglishNumber(this string strNum)
        {
            var cash = strNum;
            for (var i = 0; i < 10; i++)
                cash = cash.Replace(Pn[i], En[i]);
            return cash;
        }

        public static string ToPersianNumber(this string strNum)
        {
            var chash = strNum;
            for (var i = 0; i < 10; i++)
                chash = chash.Replace(En[i], Pn[i]);
            return chash;
        }

        public static DateTime? FromFarsiDate(this string InDate)
        {
            if (string.IsNullOrEmpty(InDate))
                return null;

            var spited = InDate.Split('/');
            if (spited.Length < 3)
                return null;

            if (!int.TryParse(spited[0].ToEnglishNumber(), out var year))
                return null;

            if (!int.TryParse(spited[1].ToEnglishNumber(), out var month))
                return null;

            if (!int.TryParse(spited[2].ToEnglishNumber(), out var day))
                return null;
            var c = new PersianCalendar();
            return c.ToDateTime(year, month, day, 0, 0, 0, 0);
        }


        public static DateTime ToGeorgianDateTime(this string persianDate)
        {
            persianDate = persianDate.ToEnglishNumber();
            var year = Convert.ToInt32(persianDate.Substring(0, 4));
            var month = Convert.ToInt32(persianDate.Substring(5, 2));
            var day = Convert.ToInt32(persianDate.Substring(8, 2));
            return new DateTime(year, month, day, new PersianCalendar());
        }

        public static string ToMoney(this double myMoney)
        {
            return myMoney.ToString("N0", CultureInfo.CreateSpecificCulture("fa-ir"));
        }

        public static string StringToMoney(this string money)
        {
            if (money == null)
            {
                money = "00";
            }
            var myMoney = int.Parse(money);
            return myMoney.ToString("N0", CultureInfo.CreateSpecificCulture("fa-ir"));
        }

        public static string ToFileName(this DateTime date)
        {
            return $"{date.Year:0000}-{date.Month:00}-{date.Day:00}-{date.Hour:00}-{date.Minute:00}-{date.Second:00}";
        }

        public static string GetDay(this DateTime date)
        {
            var pc = new PersianCalendar();
            var day = pc.GetDayOfMonth(date);
            return $"{day:00}";
        }

        public static string ToPersianMonth(this DateTime date)
        {
            var pc = new PersianCalendar();
            var month = pc.GetMonth(date);

            string persianMonth = "";

            switch (month)
            {
                case 1:
                    persianMonth = "فروردین";
                    break;
                case 2:
                    persianMonth = "اردیبهشت";
                    break;
                case 3:
                    persianMonth = "خرداد";
                    break;
                case 4:
                    persianMonth = "تیر";
                    break;
                case 5:
                    persianMonth = "مرداد";
                    break;
                case 6:
                    persianMonth = "شهریور";
                    break;
                case 7:
                    persianMonth = "مهر";
                    break;
                case 8:
                    persianMonth = "آبان";
                    break;
                case 9:
                    persianMonth = "آذر";
                    break;
                case 10:
                    persianMonth = "دی";
                    break;
                case 11:
                    persianMonth = "بهمن";
                    break;
                case 12:
                    persianMonth = "اسفند";
                    break;
            }
            return persianMonth;
        }
        
        public static string CodeGenerator(int digits)
        {
            var result = string.Empty;
            for (var i = 0; i < digits; i++)
            {
                result += Random.Shared.Next(9);
            }
            return result;
        }
        public static List<string> TagSplitter(this string tags)
        {
            var tagList = new List<string>();
            if (!string.IsNullOrWhiteSpace(tags))
            {
                tagList = tags.Split(",").ToList();
            }

            return tagList;
        }
    }
}