using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KryptonAccessController.Common
{
    class RegexMatch
    {
        /// <summary>  
        /// 是否为日期型字符串  
        /// </summary>  
        /// <param name="StrSource">日期字符串(2008-05-08)</param>  
        /// <returns></returns>  
        public static bool IsDate(string StrSource)
        {
            return Regex.IsMatch(
                StrSource,
                @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]" +
                @"|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|" +
                @"1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?" +
                @"2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468]" +
                @"[048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
        }

        /// <summary>  
        /// 是否为时间型字符串  
        /// </summary>  
        /// <param name="source">时间字符串(15:00:00)</param>  
        /// <returns></returns>  
        public static bool IsTime(string StrSource)
        {
            return Regex.IsMatch(
                StrSource,
                @"^((20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$");
        }

        /// <summary>  
        /// 是否为日期+时间型字符串  
        /// </summary>  
        /// <param name="source"></param>  
        /// <returns></returns>  
        public static bool IsDateTime(string StrSource)
        {
            return Regex.IsMatch(
                StrSource,
                @"^(((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?" +
                @"[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?" +
                @"[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]" +
                @"|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-" +
                @"9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[" +
                @"2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23" +
                @"|[0-1]?\d):[0-5]?\d:[0-5]?\d)$ ");
        }
        /// <summary>  
        /// 是否为管理员密码格式 
        /// </summary>  
        /// <param name="source"></param>  
        /// <returns></returns>  
        public static Boolean IsManagerPassword(string StrSource)
        {
            Match passwordValidator = Regex.Match(StrSource, @"^[a-zA-Z0-9]{1,8}$");
            return passwordValidator.Success;
        }
        /// <summary>  
        /// 是否为管理员姓名格式 
        /// </summary>  
        /// <param name="source"></param>  
        /// <returns></returns>  
        public static Boolean IsManagerName(string StrSource)
        {
            Match passwordValidator = Regex.Match(StrSource, @"^[a-zA-Z]\w{0,7}$");
            return passwordValidator.Success;
        }
    }
}
