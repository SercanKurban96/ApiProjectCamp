#  API EĞİTİM KAMPI
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

