# ApiConsume

**ApiConsume** .NET Core tabanlı bir proje olup, üçüncü taraf API'leri (RESTful servisler) çağırmak ve bu verileri işlemeye yönelik bir örnek uygulamadır. Bu proje, HTTP istemci kullanımı, veri dönüşümü, hata yönetimi ve temiz katmanlı mimari konseptlerini içerir.

## ⚙️ Teknolojiler & Yaklaşımlar

- .NET 6/7/8 (veya kullanılan sürüm)
- `HttpClientFactory` ile doğru HTTP istemci ömrü yönetimi
- JSON (de)serializasyonu için `System.Text.Json` veya `Newtonsoft.Json`
- Asenkron `async / await` ile çağrılar
- Hata yönetimi ve retry mekanizmaları (örneğin `Polly`)
- Dependency Injection ile servis çözümlemesi
- (Opsiyonel) Web API katmanında controller örnekleri

## 🔄 Kurulum & Çalıştırma

```bash
git clone https://github.com/ulasaktas07/ApiConsume.git
cd ApiConsume
dotnet restore
dotnet build
dotnet run
