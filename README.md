# ![api_3231329 (1)](https://github.com/user-attachments/assets/8804a245-7f0d-4bae-8666-e5ac9047a212) PROJE KAMPI
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

## 🖥️ #5 Api Proje Kampı - Migration İşlemleri
### 📆 Tarih: 5 Şubat 2025
<br>

Migration işlemleri için bizim bir Context sınıfına ihtiyacımız olacaktır. Bunun için katmanımıza Context isminde bir tane klasör oluşturuyoruz. Ardından Context klasörüne sağ tıklayıp yeni bir Class oluşturuyoruz. Class'ımızın ismini "ApiContext" olarak belirledik.

Burada Server kısmı sizin SQL adresiniz, initial catalog kısmı veri tabana vereceğiniz isim, integrated security kısmı ise bağlantının güvenli olduğunu, herhangi bir kullanıcı adı şifre kullanmadan erişim sağladığımızı bildirir.

Burada Code First aracılığıyla veri tabanı bağlantısını gerçekleştireceğiz.

![image](https://github.com/user-attachments/assets/b41d04f5-3278-4226-9a77-c22523953613)

Burada ilk olarak DbContext sınıfından miras alıyoruz. Ardından kısayol olarak override onconfiguring yazdığımız zaman gelen metni seçiyoruz. Ardından optionsbuilder.UseSqlServer kodunu yazdıktan sonra ilgili veri tabanı adresini yazıyoruz.

Buradaki işlemler tamamlandıktan sonra bu kez veri tabanına yansıtacağımız tabloların isimlerini oluşturacağız. DbSet türünde burada bütün entityleri tek tek yazıyoruz.

![image](https://github.com/user-attachments/assets/bdf89c7d-3c59-442a-8c71-bcc91c8121e8)

Burada yer alan bütün entityleri DbSet türünden yazdık. DbSet içerisine yazdığımız entityler yaln isim C#'taki sınıfın ismini, sağ taraftaki çoğul isim SQL'e yansıyacak olan tablonun ismidir.

Migration işlemlerini yapabilmek için bu kez Package Manager Console açmamız gerekecektir. Birkaç yöntemle konsol açılabilir. Visual Studio'nun sol üst kısmında yer alan View kısmına gelinir, ardından Other Windows'a gelinir ve oradan Package Manager Console seçilir. Diğer bir yöntem üst kısımda yer alan Tools kısmına gelinir, ardından NuGet Package Manager, ardından Package Manager Console seçtiğiniz zaman konsol açılacaktır.

![image](https://github.com/user-attachments/assets/bb9b787d-37d6-4180-985a-1ebdf70441c4)

Package Manager Console bu şekilde çıkacaktır. Başlangıçta sizde yazılar gelecektir, bunları silmek için Default Project: ApiProjectCamp.WebApi yazılan yerin sağ tarafındaki ikona tıkladığınız zaman ekranı temizleyecektir.

Migration kelime anlamı göç demektir. Burada aslında Visual Studio'dan SQL'e bir göç, bir taşıma işlemi vardır. Yazacağımız kod şu şekildedir;

![image](https://github.com/user-attachments/assets/0f8b3abd-5e19-4776-9a27-f17798083477)

Burada add-migration dedikten sonra istediğiniz bir isim verebilirsiniz. Burada mig1 olarak belirlememizin sebebi migrationların sıralamasını unutmamak için hiyerarşik yapıyı korumak adına bu şekilde adlandırıyoruz. Ardından Enter'a basıyoruz ve biraz bekliyoruz.

![image](https://github.com/user-attachments/assets/b0749e56-a32f-4896-99bd-553afa752d52)

Migration işleminde herhangi bir sıkıntı çıkmadıysa karşımıza bu şekilde çıkacaktır. Burası bir önizleme ekranıdır. Veri tabanına yansıtmak için yazacağımız kod şu şekildedir;

![image](https://github.com/user-attachments/assets/1eefa0fc-eb98-4aba-9a59-3b9ee70e727c)

update-database dedikten sonra biraz bekliyoruz.

![image](https://github.com/user-attachments/assets/a36a08a5-ef78-45f7-8bca-e3c70605547c)

Done yazısı çıkarsa migration işlemi tamamlanmış demektir. Veri tabanımıza gidiyoruz.

![image](https://github.com/user-attachments/assets/0572bab7-9d4b-4f62-a120-90aa3575c2c1)

Veri tabanımız ve tablolar oluşturuldu.
