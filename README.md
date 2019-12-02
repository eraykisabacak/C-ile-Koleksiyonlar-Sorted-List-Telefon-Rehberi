# C-ile-Koleksiyonlar-Sorted-List-Telefon-Rehberi

## C# ile Koleksiyonlar Sorted List kullanarak Dosyadan Okuduğumuz Verilerle Telefon Rehberi Uygulaması Yapımı

Kayıtları metin dosyasında tutulan bir telefon rehberi üzerinde bazı sıralama ve listeleme işlemlerinin yapılması 
istenmektedir. Kişi isimleri, bu kimselerin şehirleri ve telefon numaralarının bulunduğu bu dosyanın şablonu aşağıda görülmektedir.

![](http://eraykisabacak.com/Koleksiyonlar1.png)

Hazırlayacağınız programın rehberdeki şehir isimlerini alfabetik olarak listelemesi ve bunun altında kişi isimlerini yine 
alfabetik sırada telefon numaralarıyla birlikte göstermesi gerekmektedir. Bu problem birçok farklı yolla çözülebilir. 
Ancak burada istenen herhangi bir ekstra sıralama işlemi yapmadan; dosyadan okuma esnasında veri yapısının oluşturulmasıyla 
problemin çözülmesidir. Alınması gereken ekran çıktısı örneği aşağıdaki gibi olmadır:

![](http://eraykisabacak.com/Koleksiyonlar2.png)
	
	
Bu amaçla dengeli-arama-ağacı veri yapısına dayanan SortedDictionary<K,T> koleksiyonunu hakkında araştırma yapmanız ve problemi 
bu koleksiyon ile çözmeniz istenmektedir.

SortedDictionary<string, SortedDictionary<string, string>>