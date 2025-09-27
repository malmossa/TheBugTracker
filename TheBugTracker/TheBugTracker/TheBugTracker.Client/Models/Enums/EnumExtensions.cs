﻿using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Client.Models.Enums
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            string? displayName = value.GetType()
                                       .GetMember(value.ToString())
                                       .FirstOrDefault()?
                                       .GetCustomAttribute<DisplayAttribute>()?
                                       .GetName();
            if (string.IsNullOrEmpty(displayName))
            {
                return value.ToString();
            } else
            {
                return displayName;
            }
        }
    }
}
