# C-ile-Koleksiyonlar-Sorted-List-Telefon-Rehberi

##C# ile Koleksiyonlar Sorted List kullanarak Dosyadan Okuduğumuz Verilerle Telefon Rehberi Uygulaması Yapımı

Kayıtları metin dosyasında tutulan bir telefon rehberi üzerinde bazı sıralama ve listeleme işlemlerinin yapılması 
istenmektedir. Kişi isimleri, bu kimselerin şehirleri ve telefon numaralarının bulunduğu bu dosyanın şablonu aşağıda görülmektedir.

Tahir | Konya | 332-223-3336
Selahattin | Ankara | 312-123-4567
Okan | İzmir | 232-147-2589
Ayşe | Ankara | 312-258-3698
Deniz | Konya | 332-369-7896

Hazırlayacağınız programın rehberdeki şehir isimlerini alfabetik olarak listelemesi ve bunun altında kişi isimlerini yine 
alfabetik sırada telefon numaralarıyla birlikte göstermesi gerekmektedir. Bu problem birçok farklı yolla çözülebilir. 
Ancak burada istenen herhangi bir ekstra sıralama işlemi yapmadan; dosyadan okuma esnasında veri yapısının oluşturulmasıyla 
problemin çözülmesidir. Alınması gereken ekran çıktısı örneği aşağıdaki gibi olmadır:

Ankara :
	Ayşe - 312-258-3698
	Selahattin - 312-123-4567
İzmir :
	Okan - 232-147-2589
Konya :
	Deniz - 332-369-7896
	Tahir - 332-223-3336
	
	
Bu amaçla dengeli-arama-ağacı veri yapısına dayanan SortedDictionary<K,T> koleksiyonunu hakkında araştırma yapmanız ve problemi 
bu koleksiyon ile çözmeniz istenmektedir.

SortedDictionary<string, SortedDictionary<string, string>>