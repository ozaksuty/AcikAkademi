using Ders3.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Data
{
    public class MVAFactory
    {
        public class MVA
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
            public DateTime PublishDate { get; set; }
        }

        public static IList<MVA> MVAData { get; set; }

        //public static IList<MVA> MVADataWithGrouping { get; set; }

        public static int RefreshCount { get; set; } = 0;

        static MVAFactory()
        {
            MVAData = new ObservableCollection<MVA>
            {
                new MVA
                {
                    Title = "Engin Polat'ın Universal App eğitiminin devamını izleyin.",
                    Description = "19 Şubat'ta gerçekleşen Engin Polat'ın Universal App eğitiminin devamını izleyin.",
                    PublishDate = new DateTime(2015, 2, 19),
                    ImageUrl = "enginpolat.jpeg"
                },
                new MVA
                {
                    Title = "Engin Polat'ın 'Universal App' dersini izleyin.",
                    Description = "5 Şubat'ta gerçekleşen Engin Polat'ın 'Universal App' dersini izleyin.",
                    PublishDate = new DateTime(2015, 2, 5),
                    ImageUrl = "enginpolat.jpeg"
                },
                new MVA
                {
                    Title = "Onur Tırpan'ın 'Windows Azure Mobile Services' dersini dinleyin.",
                    Description = "17 Temmuz'da gerçekleşen Onur Tırpan'ın sanal sınıfını izleyin.",
                    PublishDate = new DateTime(2014, 7, 17),
                    ImageUrl = "onurtirpan.jpeg"
                },
                new MVA
                {
                    Title = "Erol Hacısüleyman'ın 'TFS' dersini izleyin.",
                    Description = "10 Temmuz'da gerçekleşen Erol Hacısüleyman'ın 'TFS' dersini izleyin.",
                    PublishDate = new DateTime(2014, 7, 10),
                    ImageUrl = "erolhacisuleyman.jpeg"
                },
                new MVA
                {
                    Title = "Tuğberk Uğurlu'nun 'ASP.NET vNext'e Giriş' dersini izleyin.",
                    Description = "26 Haziran'da gerçekleşen Tuğberk Uğurlu'nun Sanal Sınıfı'nı izleyin.",
                    PublishDate = new DateTime(2014, 6, 26),
                    ImageUrl = "tugberkugurlu.jpeg"
                },
                new MVA
                {
                    Title = "Mesut Aladağ'ın 'Active Directory' dersini izleyin.",
                    Description = "5 Haziran'da gerçekleşen Mesut Aladağ'ın 'Active Directory' dersini dinleyin.",
                    PublishDate = new DateTime(2014, 6, 5),
                    ImageUrl = "mesutaladag.jpeg"
                },
                new MVA
                {
                    Title = "Arda Otuk'un 'Web Tasarım'a Giriş' dersini izleyin.",
                    Description = "29 Mayıs'ta Arda Otuk'un 'Web Tasarım'a Giriş' dersini izleyin.",
                    PublishDate = new DateTime(2014, 5, 29),
                    ImageUrl = "ardaotuk.jpeg"
                },
                new MVA
                {
                    Title = "Özkan Altuner'in 'Mobil Trendler' konulu sanal sınıfını izleyin.",
                    Description = "22 Mayıs'ta gerçekleşen Özkan Altuner'in sanal sınıfını izleyin.",
                    PublishDate = new DateTime(2014, 5, 22),
                    ImageUrl = "ozkanaltuner.jpeg"
                },
                new MVA
                {
                    Title = "Ümit Bilen'in Dynamics Ürün Ailesini anlattığı sanal sınıfı izleyin.",
                    Description = "15 Mayıs'ta gerçekleşen Ümit Bilen'in sanal sınıfını kaçırmayın.",
                    PublishDate = new DateTime(2014, 5, 15),
                    ImageUrl = "umitbilen.jpeg"
                },
                new MVA
                {
                    Title = "Oğuz Pastırmacı'nın 'IT'de nasıl kariyer yapılır?' sunumunu izleyin.",
                    Description = "8 Mayıs'ta Oğuz Pastırmacı'nın gerçekleştirdiği sanal sınıfı izleyin.",
                    PublishDate = new DateTime(2014, 5, 8),
                    ImageUrl = "oguzpastirmaci.jpeg"
                },
                new MVA
                {
                    Title = "Beray Benteşen'in Imaging SDK ile ilgili dersini izleyin!",
                    Description = "1 Mayıs'ta gerçekleşen Beray Benteşen'in Imaging SDK ile ilgili dersini izleyin.",
                    PublishDate = new DateTime(2014, 5, 1),
                    ImageUrl = "beraybentesen.jpeg"
                },
                new MVA
                {
                    Title = "Onur Tırpan'ın App Studio ile ilgili sanal sınıfını izleyin.",
                    Description = "17 Nisan'da gerçekleşen App Studio dersimizi izleyin.",
                    PublishDate = new DateTime(2014, 4, 17),
                    ImageUrl = "onurtirpan.jpeg"
                },
                new MVA
                {
                    Title = "Deniz Demircioğlu'nun anlattığı Process Lifetime Management dinleyin.",
                    Description = "3 Nisan'da gerçekleşen Deniz Demircioğlu'nun anlattığı 'Process Lifetime Management' sunumunu dinleyin.",
                    PublishDate = new DateTime(2014, 4, 3),
                    ImageUrl = "denizdemircioglu.jpeg"
                },
                new MVA
                {
                    Title = "Müge Behram'ın 'SQL Server 2014 Yenilikleri' sunumunu izleyin.",
                    Description = "27 Mart'ta gerçekleşen Müge Behram'ın 'SQL Server 2014 Yenilikleri' hakkında yaptığı sunumu kaçırmayın.",
                    PublishDate = new DateTime(2014, 3, 27),
                    ImageUrl = "mugebehram.jpeg"
                },
                new MVA
                {
                    Title = "Hasan Özdemir'in Big Data ile uygulamalar gösterdiği dersi izleyin.",
                    Description = "13 Mart'ta gerçekleşen Hasan Özdemir'in sanal sınıfını izleyin.",
                    PublishDate = new DateTime(2014, 3, 13),
                    ImageUrl = "hasanozdemir.jpeg"
                },
                new MVA
                {
                    Title = "Ömer Bilge Ersoy'un 'KPI' konulu sunumunu izleyin.",
                    Description = "20 Mart'ta gerçekleşen Arcademonk oyun stüdyosu kurucusu Ömer Bilge Ersoy'un KPI sunumunu kaçırmayın!",
                    PublishDate = new DateTime(2014, 3, 20),
                    ImageUrl = "omerbilgeersoy.jpeg"
                },
                new MVA
                {
                    Title = "İbrahim Kıvanç'ın 'Uygulama Tasarım İncelikleri' dersini izleyin.",
                    Description = "6 Mart'ta gerçekleşen İbrahim Kıvanç'ın 'Uygulamada Tasarım İncelikleri' dersini kaçırmayın.",
                    PublishDate = new DateTime(2014, 3, 6),
                    ImageUrl = "ibrahimkivanc.jpeg"
                },
                new MVA
                {
                    Title = "Gürcan Serbest'in 'Oyun Programlama' dersini dinleyin.",
                    Description = "Gürcan Serbest'in 20 Şubat'ta anlattığı 'Oyun Programlama' dersini dinleyin.",
                    PublishDate = new DateTime(2014, 2, 20),
                    ImageUrl = "gurcanserbest.jpeg"
                },
                new MVA
                {
                    Title = "Gürcan Serbest'in 'Unity' dersini izleyin.",
                    Description = "30 Ocak'ta yapılan Unity dersini izleyin.",
                    PublishDate = new DateTime(2014, 1, 30),
                    ImageUrl = "gurcanserbest.jpeg"
                },
                new MVA
                {
                    Title = "Şahin Boydaş ve Taner Akçok'un İnovasyon Yönetimi sunumunu dinleyin.",
                    Description = "MovieLaLa şirketinin Kurucusu ve Genel Müdür Yardımcısı'ndan İnovasyon Yönetimi konulu semineri dinleyin.",
                    PublishDate = new DateTime(2014, 2, 6),
                    ImageUrl = "sahinboydas.jpeg"
                },
                new MVA
                {
                    Title = "Yavuz Buruk'un 'Müşteri Memnuniyeti' dersini izleyin.",
                    Description = "Microsoft Müşteri ve iş Ortakları Memnuniyeti Müdürü Yavuz Buruk'tan 'Müşteri Memnuniyeti'ni' dinleyin.",
                    PublishDate = new DateTime(2014, 1, 27),
                    ImageUrl = "yavuzburuk.jpeg"
                },
                new MVA
                {
                    Title = "Engin Polat'ın Windows Phone 8 Uygulama Geliştirme dersini dinleyin!",
                    Description = "Engin Polat'ın Windows Phone 8 içn geliştirdiği uygulamaları görmek için tıklayınız.",
                    PublishDate = new DateTime(2014, 1, 15),
                    ImageUrl = "enginpolat.jpeg"
                },
                new MVA
                {
                    Title = "Uğur Tadık'tan Akbank Uygulama Geliştirme Öyküsü'nü izleyin",
                    Description = "Akbank’ın Windows Phone uygulama geliştirme öyküsünü Akbank Mobil Platformlar Uygulama Geliştirme Yöneticisi Uğur Tadık’tan dinleyin!",
                    PublishDate = new DateTime(2014, 1, 13),
                    ImageUrl = "ugurtadik.jpeg"
                },
                new MVA
                {
                    Title = "Sema Kudu'nun Windows Phone Uygulamalarında Here Maps dersini izleyin!",
                    Description = "Sema Kudu'nun Windows Phone Uygulamalarında Here Maps dersini izleyin!",
                    PublishDate = new DateTime(2014, 1, 8),
                    ImageUrl = "semakudu.jpeg"
                },
                new MVA
                {
                    Title = "Umut Erkal'ın .NET ile mikrodenetleyici programlama dersini dinleyin!",
                    Description = "Umut Erkal'ın .NET ile mikrodenetleyici programlama dersini dinleyin",
                    PublishDate = new DateTime(2013, 12, 30),
                    ImageUrl = "umuterkal.jpeg"
                },
                new MVA
                {
                    Title = "Ümit Sunar'ın Azure Web Site ve Web Servisleri dersini dinleyin!",
                    Description = "Ümit Sunar'ın Windows Azure Web Site ve Web Servisleri dersini dinleyin!",
                    PublishDate = new DateTime(2013, 12, 20),
                    ImageUrl = "umitsunar.jpeg"
                },
                new MVA
                {
                    Title = "Daron Yöndem'in Windows Azure ve Web konulu dersini izleyin!",
                    Description = "Daron Yöndem'in Windows Azure ve Web konulu dersini izleyin!",
                    PublishDate = new DateTime(2013, 12, 18),
                    ImageUrl = "daronyondem.jpeg"
                },
                new MVA
                {
                    Title = "Ümit Sunar'ın Windows Azure & Hadoop konulu dersini izleyin.",
                    Description = "Ümit Sunar'ın Windows Azure ve Hadoop konulu Sanal Sınıfı'nı izleyin!",
                    PublishDate = new DateTime(2013, 11, 29),
                    ImageUrl = "umitsunar.jpeg"
                },
                new MVA
                {
                    Title = "Ümit Sunar'ın Windows Azure konulu ders kaydını izleyin!",
                    Description = "28 Kasım'da Sanal Sınıf'ta Ümit Sunar'ın verdiği 'Windows Azure ve Geliştirme / Test Yönetimi' dersini izleyin.",
                    PublishDate = new DateTime(2013, 11, 28),
                    ImageUrl = "umitsunar.jpeg"
                },
                new MVA
                {
                    Title = "Özgür Erecekler 'İş Zekası' konulu Sanal Sınıfını izleyin",
                    Description = "Kariyerini Microsoft araçları ile iş zekası üzerine kurmuş olan Özgür Erecekler, daha önceki işindeki uçtan uca BI çözümü geliştirme tecrübesinin ardından, bir senedir Bilge Adam Kurumsal’da görev yapmaktadır. Bu kurumdaki danışmanlık rolü kapsamında iş zekası projelerinde geliştirme yapmasının yanısıra iş zekası altyapı ve üstyapı eğitimleri vermektedir.",
                    PublishDate = new DateTime(2013, 11, 18),
                    ImageUrl = "ozgurerecekler.jpeg"
                },
                new MVA
                {
                    Title = "Daron Yöndem'in Sanal Sınıf kaydını izleyin!",
                    Description = "Windows Azure ve Mobile Services kullanımı konusunda Daron Yöndem'in verdiği ders kaydını izleyin.",
                    PublishDate = new DateTime(2013, 11, 8),
                    ImageUrl = "daronyondem.jpeg"
                },
                new MVA
                {
                    Title = "Selçuk Uzun'un 'Yazılımcı Olmak' konulu Sanal Sınıf kaydını izleyin!",
                    Description = "Bu haftaki Sanal Sınıf’ta Selçuk Uzun 'Yazılımcı Olmak' konusunu ele alıyor.",
                    PublishDate = new DateTime(2013, 11, 6),
                    ImageUrl = "selcukuzun.jpeg"
                },
                new MVA
                {
                    Title = "Kerem Özsu’nun verdiği sanal sınıfı mutlaka izleyin.",
                    Description = "'Uygulama Geliştirmede Proje Yönetiminin Önemi' konulu Sanal Sınıfı izlemek için tıklayın.",
                    PublishDate = new DateTime(2013, 11, 5),
                    ImageUrl = "keremozsu.jpeg"
                }
            };
        }

        public static ObservableCollection<Grouping<string, MVA>>
            BindingWithGrouping(string searchText = "")
        {
            var result = MVAData;

            if (!String.IsNullOrEmpty(searchText) && searchText.Length > 3)
            {
                result = result.Where(x => x.Title.ToLower().StartsWith(
                    searchText.ToLower())).ToList();
            }

            var list = new ObservableCollection<Grouping<string, MVA>>
                (result.
                OrderBy(c => RefreshCount % 2 == 0 ? c.PublishDate.ToString() : c.Title).
                GroupBy(c => c.Title[0].ToString()
                ).Select(k => new Grouping<string, MVA>(k.Key, k)));

            return list;
        }
    }
}
