using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi."; 
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarsListed="Araçlar listelendi.";
        public static string CarUpdated="Araç güncellendi.";
        public static string CarDeleted="Araç silindi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";

        public static string CustomerAdded = "Müsteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string RentalAdded = "Kiralama eklendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentListed = "Kiralamalar listelendi.";
        public static string RentGet = "Kiralama getirildi.";
        public static string RentalError = "Bir hata oluştu.";
        public static string ReturnDateNull = "Bırakma tarihi boş geçilemez.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncelendi.";
        public static string ColorsListed = "Renkler listelendi.";
        
        public static string CarImageAdded="Araba resmi eklendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImagesCantAdded = "Resim Eklenemedi.";
        public static string ImageLimitFull="Araba resim ekleme limiti doldu.";

        public static string UserAlreadyExists="Kullanıcı zaten mevcut.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string PasswordError="Şifre hatası.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi.";
        public static string AllUserListed="Tüm kullanıcılar listelenmiştir.";       
        public static string UserOperationAdded="Kullanıcı operasyonu eklendi.";
        public static string UserOperationDeleted="Kullanıcı operasyonu silindi.";
        public static string UserOperationUpdated="Kullanıcı operasyonu silindi.";

        public static string MaintenanceTime="Sistem bakım zamanı.";
        public static string TransactionTested = "Transaction test edildi.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string AccessTokenCreated="Giriş Tokeni Oluşturuldu.";

        public static string OperationUpdated="Operasyon güncellendi";
        public static string OperationDeleted="Operasyon silindi.";
        public static string OperationAdded="Operasyon Eklendi.";
    }
}
