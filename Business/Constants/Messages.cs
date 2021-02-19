using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded { get; } = "Araç Eklendi.";
        public static string CarDeleted { get; } = "Araç Silindi.";
        public static string CarUpdated { get; } = "Araç Güncellendi.";
        public static string CarNotFound  { get; } = "Araç Bulunamadı.";

        public static string BrandAdded { get; } = "Marka Eklendi.";
        public static string BrandDeleted { get; } = "Marka Silindi.";
        public static string BrandUpdated { get; } = "Marka Güncellendi.";
        public static string BrandNotFound { get; } = "Marka Bulunamadı.";

        public static string ColorAdded { get; } = "Renk Eklendi.";
        public static string ColorDeleted { get; } = "Renk Silindi.";
        public static string ColorUpdated { get; } = "Renk Güncellendi.";
        public static string ColorNotFound { get; } = "Renk Bulunamadı.";
    }
}
