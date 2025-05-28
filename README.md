HWID SPOOFER SIMULATOR 
Bu proje, Windows işletim sisteminde donanımsal kimlik bilgilerini (Hardware ID - HWID) okuyarak, kullanıcıya 
bu bilgileri sahte (spoofed) değerlerle değiştirme yeteneği sunan bir masaüstü uygulamasıdır. Uygulama, C# dili ve 
Windows Forms arayüz kütüphanesi kullanılarak geliştirilmiş olup, kullanıcı dostu bir grafiksel arayüz (GUI) ile 
birlikte karanlık, “hacker” temalı bir görsel tasarıma sahiptir. 
Uygulamanın temel amacı, kullanıcı bilgisayarında yer alan üç kritik HWID bileşeninin: BIOS serial number, Disk 
volume ID ve CPU ID değerlerini okuyarak hem gerçek hem de sahte versiyonlarını görsel olarak sunmaktır. 
Kullanıcı, arayüzde yer alan “Spoof” butonuna tıklayarak bu değerleri rastgele üretilmiş hexadecimal formatta yeni 
sahte değerlerle değiştirebilir. Rastgele değer üretimi, System.Random sınıfı ve hexadecimal karakter kümesi 
kullanılarak gerçekleştirilmiştir. 
Arayüzde görsellik ve deneyim artırımı için ses ve görsel efektler entegre edilmiştir. Program başlatıldığında 
otomatik olarak bir .wav formatındaki müzik döngüye alınarak çalınır. Ayrıca, spoof butonuna tıklanmasıyla birlikte 
kısa bir ses efekti tetiklenmektedir. Görsel arka plan olarak matrix-stili karanlık bir görsel kullanılmıştır. Tüm bu 
ögeler, uygulamanın “dark hacker interface” tarzını yansıtmasını sağlamaktadır. 
Proje, .NET 6 platformu kullanılarak hazırlanmıştır ve Visual Studio ortamında derlenebilir. Uygulama derlendikten 
sonra çalıştırılabilir .exe formatında, bin\Debug\net6.0-windows\ klasörü altında erişilebilir hale gelmektedir. 
Proje yapısı içerisinde ana form (MainForm.cs), HWID yönetim sınıfı (HWIDReader.cs) ve ses/görsel kaynaklar 
da dahil edilmiştir. 
Sonuç olarak, HWID Spoofer projesi; temel sistem bilgilerine erişim, rastgele veri üretimi, ses ve görsel medya 
kullanımı gibi birçok yazılım tekniğini bir arada barındıran, işlevsel ve tematik olarak özgün bir bitirme projesidir.
