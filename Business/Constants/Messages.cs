using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        #region Araba mesajları
        public static string CarAdded { get; } = "Araç Eklendi.";
        public static string CarDeleted { get; } = "Araç Silindi.";
        public static string CarUpdated { get; } = "Araç Güncellendi.";
        public static string CarNotFound { get; } = "Araç Bulunamadı !";

        #endregion

        #region Marka mesajları
        public static string BrandAdded { get; } = "Marka Eklendi.";
        public static string BrandDeleted { get; } = "Marka Silindi.";
        public static string BrandUpdated { get; } = "Marka Güncellendi.";
        public static string BrandNotFound { get; } = "Marka Bulunamadı !";

        #endregion

        #region Renk mesajları
        public static string ColorAdded { get; } = "Renk Eklendi.";
        public static string ColorDeleted { get; } = "Renk Silindi.";
        public static string ColorUpdated { get; } = "Renk Güncellendi.";
        public static string ColorNotFound { get; } = "Renk Bulunamadı !";

        #endregion

        #region Kullanıcı mesajları
        public static string UserAdded { get; } = "Kullanıcı Eklendi.";
        public static string UserDeleted { get; } = "Kullanıcı Silindi.";
        public static string UserUpdated { get; } = "Kullanıcı Güncellendi.";
        public static string UserNotFound { get; } = "Kullanıcı Bulunamadı !";

        #endregion

        #region Müşteri mesajları
        public static string CustomerAdded { get; } = "Müşteri Eklendi.";
        public static string CustomerDeleted { get; } = "Müşteri Silindi.";
        public static string CustomerUpdated { get; } = "Müşteri Güncellendi.";
        public static string CustomerNotFound { get; } = "Müşteri Bulunamadı !";

        #endregion

        #region Araba kiralama mesajları
        public static string RentalAdded { get; } = "Araba Kiralama Bilgileri Gönderildi.";
        public static string RentalDeleted { get; } = "Araba Kiralama Bilgileri Silindi.";
        public static string RentalUpdated { get; } = "Araba Kiralama Bilgileri Güncellendi.";
        public static string RentalNotFound { get; } = "Araba Kiralama Bilgisi Bulunamadı.";
        public static string RentalReturnDateError { get; } = "Araba Teslim Edilmemiş.";
        #endregion

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}
