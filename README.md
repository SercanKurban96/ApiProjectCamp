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

<hr>

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

<hr>

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

<hr>

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

<hr>

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

<hr>

## 🖥️ #6 Api Proje Kampı - Swagger Aracı, DI ve Kategori Ekleme İşlemi
### 📆 Tarih: 10 Şubat 2025
<br>

![image](https://github.com/user-attachments/assets/22b53870-9081-42b7-93bb-a703adc2cfbd)

Burada artık Controller kısmını oluşturabiliriz. Burada API'lerimizin testini gerçekleştirebilmek için Controller oluşturup bu Controller'dan gitmemiz gerekmektedir. Controllers klasörüne sağ tıklayıp Add kısmından Controller diyoruz.

![image](https://github.com/user-attachments/assets/d640b467-4da8-4b4c-b899-834a8d873499)

Sol tarafta yer alan API olanı seçiyoruz ve en üstte yer alan API Controller - Empty olanı seçip Add diyoruz.

![image](https://github.com/user-attachments/assets/2bb7b64c-303f-4d17-b540-1c92c02116b1)

Burada ismini CategoriesController olarak belirliyoruz. Genellikle API'lerde Controller oluştururken çoğul isimler kullanılır. Biz de burada çoğul isim kullanarak Categories şeklinde ismini vermiş olduk.

![image](https://github.com/user-attachments/assets/f36f684e-69bb-4ef3-8919-a39d03480ee0)

CategoriesController API bu şekilde karşımıza çıkmaktadır. API dediğimiz aracın burada bir arayüzü yoktur. Sadece bunları test edebileceğimiz Swagger isminde bir tool gelmektedir. Bu tool üzerinden testimizi gerçekleştirebiliriz. Burada her bir API'ın türünün ne olduğunu belirtmemiz gerekmektedir. Ekleme, silme, güncelleme, listeleme veya herhangi bir işlem için burada bütün API'lerin mutlaka türünün belirtmesi gerekmektedir. Aksi halde hata verecektir.

Context sınıfımızda yer alan ApiContext işlemi için, burada Dependency Injection'ı biraz daha uygulayıp sürdürülebilir kod yazabilmek adına API Context'ten bir nesne örneği türetmek yerine bunu private readonly üzerinden API Context'ten bir nesne örneği türetip sonrasında Constructor (yapıcı metot) olarak yapacağız.

![image](https://github.com/user-attachments/assets/321d594f-e045-4fe4-b2af-c7ad633a32e5)

Buradan private readonly üzerinden bir nesne örneği türettik ve ardından bir tane Constructor oluşturduk.

### !!! Eğer bir yerde constructor yapıyorsak registration yapılması gerekmektedir. Buradan Program.cs sınıfını seçiyoruz.

![image](https://github.com/user-attachments/assets/e2c7bc88-ad34-4e48-a48f-4a31fda99c3c)

7. satırda yazacağımız kod bu şekilde olacaktır. ApiContext sınıfını constructor olarak kullandığını belirtiyoruz ve bunu Program.cs üzerinden bildirmiş oluyoruz.

Tekrardan CategoriesController'a dönüyoruz.

Burada ilk olarak yeni bir kategori ekleme işlemini gerçekleştiriyoruz.

![image](https://github.com/user-attachments/assets/fea799c0-b4a1-4cbf-a95b-5a14dc5c7d9a)

📍<strong>[HttpPost]:</strong> Ekleme işlemleri için kullanılan bir özelliktir.

📍 Burada public IActionResult dedikten sonra bir metot ismi belirliyoruz ve ismini CreateCategory olarak belirliyoruz. Parantez içerisine bizden bir parametre beklemektedir. Category türünden bir category parametresi oluşturuyoruz.<br>
📍 Ardından yapacağımız işlem, _context.Categories.Add dedikten sonra parametreden gelen değeri Categories sınıfına ekleme işlemini yapıyoruz. Bu sınıf bizim SQL'e yansıtmış olduğumuz sınıftan gelmektedir.<br>
📍 Ardından _context.SaveChanges kısmı değişiklikleri kaydetmeyi sağlar.<br>
📍 En sonunda return Ok diyerek bize bir mesaj vermesini sağlıyoruz.<br>
📍 Programımızı çalıştırmak için CTRL + F5 yapıyoruz.<br>

![image](https://github.com/user-attachments/assets/3bcf3c82-e535-4a19-8b06-16aad552bc3c)

Burada bir POST işlemi oluştu. Üzerine tıklıyoruz.

![image](https://github.com/user-attachments/assets/7d5ea85e-1f2c-43c9-9234-229c135c3052)

Sağ tarafta yer alan "Try it out" butonuna basıyoruz.

![image](https://github.com/user-attachments/assets/e4f7d2eb-c895-4e22-983d-9c7f76d19932)

Burada gelen bir data var. Request body istek yapılar için burada bize application/json türünden vermektedir. Burada gelen kod bloğu süslü parantezin içindeki kod bloğu json türündedir. Kategori eklemesi yaparken ID değerini girmiyoruz. Bu nedenle ID kısmını silebiliriz. Kategori adını giriyoruz.

![image](https://github.com/user-attachments/assets/007bcd06-172b-43ff-85b0-3f1aca3e34e9)

Örnek olarak kategorinin ismini Çorbalar olarak belirledik. Çalıştırmak için aşağıda bulunan Execute butonuna basıyoruz.

![image](https://github.com/user-attachments/assets/4932d228-0206-400f-9b55-2ead6e5ac6d7)

Execute dedikten sonra biraz aşağıya iniyoruz. Bizim yazmış olduğumuz mesaj karşımıza çıkmış oldu.

Birkaç tane veri girişi yaptıktan sonra SQL'e dönüyoruz ve verilerimiz veri tabana yansımış mı kontrol ediyoruz.

![image](https://github.com/user-attachments/assets/b49295bd-e309-4bb1-8c60-ae5d999cecd9)

Kategorilerimiz SQL veri tabanına yansımış oldu.

<hr>

## 🖥️ #7 Api Proje Kampı - Kategori Api İşlemlerinin Tamamlanması
### 📆 Tarih: 10 Şubat 2025
<br>

Kategoriye ait geri kalan tüm CRUD işlemlerini tamamlıyoruz. Bunun için ilk olarak listeleme işlemiyle başlayacağız.

![image](https://github.com/user-attachments/assets/c42a4028-2c74-4647-9789-19789106aef0)

Listeleme işlemi için herhangi bir attribute (özellik) kullanmadık. Programımızı çalıştırıyoruz.

![image](https://github.com/user-attachments/assets/a89957cc-60d5-4837-b3d0-52412382591c)

Çalıştırdığımız zaman bize 500 kodlu bir hata karşımıza çıkacaktır. Bu hatanın sebebi herhangi bir metodun başına o metodun attribute türü yazılmazsa hata döndürecektir. Bu nedenle metodun üst kısmına [HttpGet] özelliğini ekliyoruz.

![image](https://github.com/user-attachments/assets/cc5380b9-8c74-4f08-b3fc-22b5544a8d5a)

HttpGet özelliğini ekledik. Programımızı şimdi çalıştırabiliriz.

![image](https://github.com/user-attachments/assets/c0a9bc52-f975-4332-8bed-4b3132afd051)

GET özelliği karşımıza çıktı. Buraya tıklıyoruz. Bir önceki POST işlemde yaptığımız gibi önce Try it out, ardından Execute diyoruz.

![image](https://github.com/user-attachments/assets/e7c29807-721a-468d-867d-8fa843ba927f)

Burada veriler JSON formatında gelmektedir. Sağ tarafta Download kısmına tıklayarak verileri JSON formatında indirebilirsiniz. Sol tarafta yer alan 200 kodu, HTTP durum kodları içerisinde başarılı olduğunu bildirmektedir.

## ![website_6156496](https://github.com/user-attachments/assets/e8bcd0f5-804b-4fbf-b847-1f5e6abd6f3b) HTTP Durum Kodları
HTTP durum kodları, istemci (tarayıcı) ile sunucu arasındaki iletişimin sonucunu belirten üç haneli sayılardır. Bu kodlar 5 ana kategoriye ayrılır:

### ℹ️ 1xx - Bilgilendirici Yanıtlar
📌 100 Continue → Devam et, işlem sürdürülmeli.<br>
📌 101 Switching Protocols → Protokol değişimi yapılıyor.<br>
📌 103 Early Hints → Önbellekleme için erken ipuçları veriliyor.<br>

### ✅ 2xx - Başarılı Yanıtlar
📌 200 OK → İstek başarıyla tamamlandı.<br>
📌 201 Created → Yeni bir kaynak oluşturuldu.<br>
📌 202 Accepted → İstek kabul edildi ancak henüz işlenmedi.<br>
📌 204 No Content → Başarıyla işlendi, ama içerik yok.<br>

### ⚠️ 3xx - Yönlendirme Yanıtları
📌 301 Moved Permanently → Kaynak kalıcı olarak taşındı.<br>
📌 302 Found → Kaynak geçici olarak taşındı.<br>
📌 304 Not Modified → İçerik değişmemiş, önbellek kullanılabilir.<br>
📌 307 Temporary Redirect → Geçici yönlendirme, HTTP metodunu korur.<br>
📌 308 Permanent Redirect → Kalıcı yönlendirme, HTTP metodunu korur.<br>

### ❌ 4xx - İstemci Hata Yanıtları
📌 400 Bad Request → Geçersiz istek.<br>
📌 401 Unauthorized → Kimlik doğrulama gerekli.<br>
📌 403 Forbidden → Erişim yasak.<br>
📌 404 Not Found → Kaynak bulunamadı.<br>
📌 405 Method Not Allowed → Kullanılan HTTP metodu desteklenmiyor.<br>
📌 408 Request Timeout → İstek zaman aşımına uğradı.<br>
📌 429 Too Many Requests → Çok fazla istek gönderildi, sınır aşıldı.<br>

### ‼️ 5xx - Sunucu Hata Yanıtları
📌 500 Internal Server Error → Sunucu tarafında bilinmeyen hata.<br>
📌 502 Bad Gateway → Geçersiz ara sunucu (proxy) yanıtı.<br>
📌 503 Service Unavailable → Sunucu geçici olarak kullanılamıyor.<br>
📌 504 Gateway Timeout → Sunucu, diğer sunucudan yanıt alamadı.<br>

Silme işlemi için kullanacağımız attribute [HttpDelete] olacaktır.

![image](https://github.com/user-attachments/assets/41f6129a-d3ac-4bb8-877f-cf4714b79d93)

HttpDelete özelliğini kullandıktan sonra DeleteCategory isminde bir metot oluşturuyoruz ve içerisinde int türünden id değerini alıyoruz.<br>
Ardından var türünden value isminde bir değişken oluşturup id değerini bulmak için Find metodunu kullanıyoruz.<br>
Bulduğumuz bu id değerini silmek için Remove metodunu kullanıyoruz ve değişiklikleri kaydediyoruz.<br>

![image](https://github.com/user-attachments/assets/8470eca4-a635-4d9e-aa0d-9cdb3bf7930b)

DELETE özelliği karşımıza bu şekilde çıkacaktır. Buraya gelip silmek istediğimiz id değerini giriyoruz.

![image](https://github.com/user-attachments/assets/594f0ee9-91c0-4a78-83e8-f674869486e3)

Buradan 4 numaralı id değerini giriyoruz ve Execute diyoruz. Silme işleminde herhangi bir sorun yoksa 200 kodu dönderecektir. Peki id değeri olmayan bir değer silmeye çalışalım.

![image](https://github.com/user-attachments/assets/42de0178-a33f-4150-bdca-3ada0543521b)

Değeri 55 girdiğimiz zaman bu kez 500 hata kodunu dönderecektir.

ID getirme işlemini yapıyoruz. Bunun için [HttpGet] özelliğini kullanıyoruz.

![image](https://github.com/user-attachments/assets/ec7dd53b-0885-42b3-ab13-803543f532c3)

Kodları yazdıktan sonra çalıştırmayı deneyelim.

![image](https://github.com/user-attachments/assets/5981121e-71ba-4f56-a803-323155ac2cdf)

Programı çalıştırdığımız zaman karşımıza bu şekilde bir hata gelecektir. Bu hatanın sebebi; bir Controller içerisinde aynı attribute türündeki metotlar birden fazla kez kullanılamaz. Daha önce listeleme işlemi için HttpGet kullanmıştık. Bu yüzden bir daha bu metodu bu şekilde kullanamıyoruz. Bu hatanın önüne geçebilmek için yazacağımız kod şu şekildedir;

![image](https://github.com/user-attachments/assets/34145b31-5e91-41c6-9957-ffc4eeb403cd)

HttpGet dedikten sonra bir parantez açıp çift tırnak içerisine oluşturduğumuz GetCategory ismindeki metodun aynısını yazıyoruz.

![image](https://github.com/user-attachments/assets/65aed652-ac2d-4dfa-9c79-b267654b37e6)

Programı çalıştırdığımız zaman gördüğünüz gibi en altta GET türünde bir özellik çıksa da Categories kısmın sonunda GetCategory yer almaktadır. Buraya girip getireceğimiz id değerini giriyoruz.

![image](https://github.com/user-attachments/assets/ebd72ae2-00ee-4896-b83a-2be3044cd59c)

ID değerini 2 girdiğimiz zaman "Tatlılar" ismindeki kategoriyi ekrana getirmektedir.

Güncelleme işlemi için kullanacağımız özellik [HttpPut] olacaktır.

![image](https://github.com/user-attachments/assets/08b9a17c-be87-42f2-bb38-3703600fe6ef)

Güncelleme işlemi için kodlar bu şekildedir. Ekleme metodundaki kodlar ile aynıdır ancak buradaki tek fark, Add yerine Update metodunu kullanıyoruz.

![image](https://github.com/user-attachments/assets/1ffa0d4d-4bcd-4722-98fa-c646292d1992)

Artık PUT işlemi de gelmektedir. Güncellemek istediğimiz değeri girelim.

![image](https://github.com/user-attachments/assets/5939e9f9-d9b2-454d-8e62-c46b6395b2e2)

Burada önce ID değerini yazıyoruz. Ardından güncelleyeceğimiz değerin ismini yazıyoruz. Örneğin id değeri 1 olan kategorinin ismi "Çorbalar" iken burayı "aaaa" olarak değiştirdik. SQL tablomuza gidelim.

![image](https://github.com/user-attachments/assets/3405e742-db69-458c-b664-acd24000539a)

Gördüğünüz gibi 1 numaralı olan kategorinin ismi aaaa olarak belirlenmiş oldu.

<hr>

## 🖥️ #8 Api Proje Kampı - Chef Api İşlemleri
### 📆 Tarih: 10 Şubat 2025
<br>

Bu kez Şefler üzerinden API CRUD işlemlerimizi yapıyoruz. Oluşturacağımız Controller ismi ChefsController olacaktır.

![image](https://github.com/user-attachments/assets/cc505209-9c13-4c1e-bad4-c411fb4eb9aa)

![image](https://github.com/user-attachments/assets/bdbb3c48-abe5-45b9-9ab5-f5ed1acfdafc)

Bir önceki CategoriesController'da yer alan CRUD işlemlerinin aynısını bu kez ChefsController için oluşturduk.

![image](https://github.com/user-attachments/assets/7e515f4d-d818-4dfd-991e-5b26cdcc90cc)

Artık iki tane alanımız oldu. Şefler üzerinden CRUD işlemlerimizi yapabiliriz.

<hr>

## 🖥️ #9 Api Proje Kampı - Dto ile Manuel Mapleme İşlemi
### 📆 Tarih: 20 Şubat 2025
<br>

![image](https://github.com/user-attachments/assets/d3d9a19e-8931-4b45-9286-d4a4b0a8b116)

<br>
Katmanımıza sağ tıklayarak yeni bir klasör oluşturuyoruz. Klasörümüzün ismini "Dtos" olarak belirliyoruz.<br><br>
Category ve Chef işlemlerini tamamlamıştık. Şimdiki yapacağımız işlem "Contact" olacaktır.<br>

![image](https://github.com/user-attachments/assets/c6cf325e-9e1c-48c6-9a0b-366b099bd0a7)<br><br>

📍 Dtos klasörüne sağ tıklayıp yeni bir klasör oluşturuyoruz ve ismini "ContactDtos" olarak belirliyoruz.<br>
ℹ️ Dtos bize burada entitylerimiz ile yapmak istediğimiz işlemlerdeki propertyler arasında bir köprü görevi görmektedir.<br>
📍 Dto işlemlerinde Listeleme, Ekleme, Güncelleme ve ID'ye Göre Getirme işlemleri yapılacaktır.<br>
‼️ Silme işlemi <b>yapılmayacaktır!</b><br><br>
📍 ContactDtos klasörüne sağ tıklayıp yeni bir class oluşturacağız. İlk önce listeleme işlemi yapacağız. Listeleme işlemi için ismini "ResultContactDto" olarak belirliyoruz.<br> 
✅ Entities klasöründe yer alan Contact class'ına gelip içerisindeki bütün propertyleri kopyalayıp ResultContactDto içerisine yapıştırıyoruz.<br>
