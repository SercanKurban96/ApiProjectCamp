#  API PROJE KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu API Proje Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde sıfırdan API anlatılmaktadır.
<hr>

## 🖥️ #1 Api Proje Kampı - Giriş Projeye Genel Bakış
### 📆 Tarih: 3 Şubat 2025
<br>
📍 Kullanılacak template: https://themewagon.com/themes/yummy-red/

## Projeye ait içerikler;<br>
📌 Bu projemizde sıfırdan API anlatılmaktadır.<br>
📌 Single page bir tema üzerinde sıfırdan bütünüyle API üstünden ayağa kaldırdığımız bir uygulama geliştireceğiz.<br>
📌 2 katmandan oluşan bir proje olacaktır. Birinci katman uygulamanın API katmanı, ikinci katman uygulamanın UI katmanı olacaktır.<br>
📌 API katmanında testlerimizi yaptıktan sonra UI katmanında bu API'leri Consume ediyor olacağız.<br>
📌 Admin tarafı olacaktır.<br>
📌 ASP.NET Core 6.0 kullanılmıştır.<br>
📌 Veri tabanı olarak MSSQL kullanılmıştır.<br>
📌 ORM aracı olarak Entity Framework, geliştirme yaklaşımı olarak Code First kullanılmıştır.<br>

## 🖥️ #2 Api Proje Kampı - Projenin Oluşturulması
### 📆 Tarih: 3 Şubat 2025
<br>

Proje oluşturmak için ilk olarak Blank Solution oluşturuyoruz ve ismini ApiProjectCamp olarak belirliyoruz. Burada istediğiniz ismi verebilirsiniz.

![image](https://github.com/user-attachments/assets/7557d2ec-002d-4b4a-a121-949cc150a66c)

Oluşturduğumuz Solution'a sağ tıklayıp Add kısmından New Project diyoruz.

![image](https://github.com/user-attachments/assets/90443d98-6a1f-4837-baf0-0daeec4c020b)

Buradan seçeceğimiz proje ASP.NET Core Web API olacaktır.

![image](https://github.com/user-attachments/assets/8ea1535f-cb8b-4a89-a796-f4e8d3af7380)

Burada ismini ApiProjectCamp.WebApi olarak belirledim.

![image](https://github.com/user-attachments/assets/32c05c86-0c44-4b71-ab5f-6736a80cbfdb)

Burada kullanacağımız sürüm .NET 6.0 olacaktır. Sürümü seçtikten sonra Create diyoruz.

![image](https://github.com/user-attachments/assets/5c0ff9da-ab27-4dba-b80e-ba9084da1df3)

API projemiz hazır. API projelerinde bir arayüz bulunmamaktadır. Uygulamayı çalıştırmak için CTRL + F5 tuşuna basıyoruz.

![image](https://github.com/user-attachments/assets/046fd5c4-0b54-4b80-97f2-90a6f68b4846)

API projesini çalıştırdığımız zaman karşımıza bu şekilde çıkacaktır.

![image](https://github.com/user-attachments/assets/18bfeb24-1454-43c9-8a7d-2a8376283159)

Projemizde başlangıç olarak bize Controller klasöründe yer alan WeatherForecastController ve en altta yer alan WeatherForecast.cs sınıfı yer almaktadır. Bu projeyi her şeyi kendimize uyarlayacağımız için bunların ikisini siliyoruz.

![image](https://github.com/user-attachments/assets/01bc9744-80d7-4416-8604-14a11b33ff0c)

Projeyi tekrar çalıştırdığımızda karşımıza bu şekilde çıkacaktır. Bu bir API test aracıdır. Swagger üzerinden API'lerimizi test ediyor olacağız.
<br><br>
## ⚙️ API Nedir?

API (Application Programming Interface – Uygulama Programlama Arayüzü), farklı yazılımların birbiriyle iletişim kurmasını sağlayan bir ara yüzdür. API'ler, belirli işlevleri yerine getirmek için diğer yazılımlara veya sistemlere nasıl erişileceğini tanımlayan kurallar ve protokoller içerir.

### 📌 API'nin Temel Çalışma Mantığı
1. İstemci (Client): API'yi çağıran sistem veya uygulamadır.<br>
2. İstek (Request): API’ye belirli bir işlem yapmasını söyleyen komuttur.<br>
3. Sunucu (Server): API isteğini işler ve yanıtı döndürür.<br>
4. Yanıt (Response): Sunucudan dönen sonuçtur.<br>

### 📌 API Türleri
📍 <strong>REST API:</strong> HTTP protokolünü kullanarak çalışan, en yaygın API türüdür.<br>
📍 <strong>SOAP API:</strong> XML tabanlı daha ağır bir API standardıdır.<br>
📍 <strong>GraphQL API:</strong> Tek bir istekte yalnızca ihtiyaç duyulan verileri çekmeye odaklanan API modelidir.<br>
📍 <strong>WebSocket API:</strong> Gerçek zamanlı veri akışı sağlayan bir API türüdür.<br>

### 📌 API Kullanım Alanları
✅Web siteleri ve mobil uygulamalar arası veri paylaşımı<br>
✅Üçüncü taraf entegrasyonları (örneğin: ödeme sistemleri, harita servisleri)<br>
✅IoT (Nesnelerin İnterneti) cihazları ile veri alışverişi<br>
✅Bulut servisleriyle entegrasyon<br>

Özetle, API’ler farklı sistemlerin uyumlu şekilde çalışmasını sağlayan bir köprü görevi görür.

Tekrardan katmanımıza gelerek Entities isminde bir tane klasör oluşturuyoruz.

## 🖥️ #3 Api Proje Kampı - Entitylerin Oluşturulması
### 📆 Tarih: 3 Şubat 2025
<br>

Hazır şablonda yer alan tüm öğeleri dinamik hale getirecek şekilde entitylerimizi oluşturuyoruz. Burada Code First yaklaşımını kullanıyoruz.

![image](https://github.com/user-attachments/assets/4d63fe90-2a8c-4c61-a713-caeada160847)

📌 <strong>Birinci Entity:</strong> Dinamik olarak gelen Feature alanı olacaktır. Öne çıkan kısım gibi düşünebilirsiniz.

Entities klasörüne sağ tıklayıp Add kısmından Class seçiyoruz ve ismini Feature olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/6775f582-ec4f-49eb-a0ca-3a09bc9d5f12)

✅ Feature alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/961aedd0-c414-4e23-bbe0-35c81c9c617e)

Bundan bir önceki kısım olan About bölümünü en sona bırakacağız.

📌 <strong>İkinci Entity:</strong> Burası Hizmetlerimiz kısmı olacaktır. İsmini Service olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/3a0e604a-5101-46d7-921a-74795275e8f6)

✅ Service alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/51faefdf-f806-44ae-a648-1adcaf31f262)

📌 <strong>Üçüncü ve Dördüncü Entity:</strong> Burada iki tane entity kullanacağız. İsimlerini Product ve Category olarak belirliyoruz. Category dediğimiz temada yer alan Starters, Breakfast kısmı olacaktır.
Kategorilerin bir Product ile ilişkili olması gerekmektedir. Şimdilik bu adımı atlıyoruz.

![image](https://github.com/user-attachments/assets/92d38bf1-822d-4007-994c-759fed39cf96)

![image](https://github.com/user-attachments/assets/e640b87f-40f2-4012-b1fb-1b4600a1bfb6)

✅ Category ve Product alanları için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/df13963e-9351-4ae1-b3a7-476cd1f7959c)

📌 <strong>Beşinci Entity:</strong> Burası müşterilere ait yorumlar kısmı olacaktır. İsmini Testimonial olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/6a6fee4a-c680-47cb-8359-81e896ade7d8)

✅ Testimonial alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/80f93b54-4501-448c-935f-8fc953876d99)

📌 <strong>Altıncı Entity:</strong> Burada şefler yer almaktadır. İsmini Chef olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/ebc34847-03d1-4a78-9aad-7ebec88c02b0)

✅ Chef alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/739b4ef4-ee25-49f3-874a-c808c18bb07a)

📌 <strong>Yedinci Entity:</strong> Burada rezervasyon işlemlerini yapacağız. İsmini Reservation olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/85efca6c-f379-4e33-ab79-66baaf3d687f)

✅ Reservation alanı için gerekli entitylerimizi hazırladık.

## 🖥️ #4 Api Proje Kampı - Entitylerin Tamamlanması ve Paketlerin Kurulması
### 📆 Tarih: 5 Şubat 2025
<br>

Entityleri oluşturmaya devam ediyoruz.

![image](https://github.com/user-attachments/assets/b62c72d6-e5c1-4880-be14-9d0f03598e44)

📌 <strong>Sekizinci Entity:</strong> Burada galeri işlemlerini yapacağız. İsmini Image olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/af48267f-5e26-4d2c-95cc-9b2366082adf)

✅ Image alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/64aee2ca-76b3-4660-9696-0c05cbdd7f9a)

📌 <strong>Dokuzuncu Entity:</strong> Burada haritayı ve diğer adres bilgilerinin tamamını tek bir entity üzerinden yapıyoruz. İsmini Contact olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/f5c3c92b-955e-4e2d-93bb-ab4465a4a71c)

✅ Contact alanı için gerekli entitylerimizi hazırladık.

![image](https://github.com/user-attachments/assets/8ec2e9c9-a46c-41c1-bd66-e956007ca4a0)

📌 <strong>Onuncu Entity:</strong> Burada bir mesaj kısmı bulunmaktadır. İsmini Message olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/4e685b0f-09d6-420b-ad95-3da42f898906)

✅ Message alanı için gerekli entitylerimizi hazırladık.

Entityleri yazdıktan sonra katmanımıza sağ tıklayıp "Manage NuGet Packages diyoruz.

![image](https://github.com/user-attachments/assets/2402b954-a423-4c12-9c19-a47cee44234c)

Sol üst köşede yer alan Browse kısmına tıklayıp arama çubuğuna entityframework core yazıyoruz. Kurmamız gereken paketler şunlardır;

📍<strong>Microsoft.EntityFrameworkCore</strong><br>
📍<strong>Microsoft.EntityFrameworkCore.Design</strong><br>
📍<strong>Microsoft.EntityFrameworkCore.SqlServer</strong><br>
📍<strong>Microsoft.EntityFrameworkCore.Tools</strong><br>

![image](https://github.com/user-attachments/assets/75a713ce-4a8d-42d8-871f-2e7d87c1dc4f)

Bu paketleri kurarken seçeceğimiz sürüm, ASP.NET Core 6.0 ile çalıştığımız için 6.0'a ait sürümü seçmemiz gerekecektir. Burada en son sürüm hangisiyse onu seçiyoruz ve Install diyoruz.

![image](https://github.com/user-attachments/assets/a2739e5d-c0a3-400e-b488-9e917bb11090)

Paketlerimiz yüklenmiştir. Dependencies kısmından Packages olana tıkladığımızda burada kurulan paketleri görebiliriz.

